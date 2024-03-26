using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeAssist
{
    public partial class NewTask : Form
    {
        enum Wochentag
        {
            Sonntag = 0,
            Montag = 1,
            Dienstag = 2,
            Mittwoch = 3,
            Donnerstag = 4,
            Freitag = 5,
            Samstag = 6
        }

        public NewTask()
        {
            InitializeComponent();
        }

        private void createTask_btn_Click(object sender, EventArgs e)
        {
            string task = task_text.Text;
            int minutes = Int32.Parse(estimatedTime_text.Text);

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //Anzahl Tasks ermitteln um id zu setzen
                    string getTasksQuery = "SELECT COUNT (*) FROM tasks ";
                    SqlCommand getTasksCommand = new SqlCommand(getTasksQuery, connection, transaction);
                    int countTasks = (int)getTasksCommand.ExecuteScalar();

                    //durchschnittliche abweichung in % finden
                    string getAverageDiffrenceQuery = "SELECT AVG((estimatedTime  - realTime)/ CAST(realTime AS FLOAT)) AS [Average change] FROM [tasks]";
                    SqlCommand getAverageDiffrenceCommand = new SqlCommand(getAverageDiffrenceQuery, connection, transaction);
                    double averageDiffrence = (double)getAverageDiffrenceCommand.ExecuteScalar();

                    //fragen ob die Zeit angepasst werden soll
                    DialogResult result = MessageBox.Show("Deine tatsächliche Zeit war Durchschnittlich " + averageDiffrence + "% deiner geschätzten Zeit, möchtest du diese Aufgabe danach anpassen (" + (minutes - (minutes * averageDiffrence)) + " Minuten)?", "Auswahl", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        double doubleMinutes = minutes;
                        doubleMinutes = doubleMinutes - (doubleMinutes * averageDiffrence);
                        minutes = Convert.ToInt32(doubleMinutes);
                    }
                    else if (result == DialogResult.No)
                    {
                        minutes = minutes;
                    }

                    //Task einfügen
                    string newTaskQuery = "INSERT INTO tasks (task, estimatedTime, realTime, task_id) VALUES (@task, @minutes, @minutes, @task_id)";
                    SqlCommand newTaskCommand = new SqlCommand(newTaskQuery, connection, transaction);
                    newTaskCommand.Parameters.AddWithValue("@task", task);
                    newTaskCommand.Parameters.AddWithValue("@minutes", minutes);
                    newTaskCommand.Parameters.AddWithValue("@task_id", countTasks);
                    newTaskCommand.ExecuteScalar();

                    //freie Zeit suchen
                    string getFreeTimeQuery = "SELECT COUNT (*) FROM freeTime WHERE freetimeAmount > @minutes AND assingedTask_id IS NULL";
                    SqlCommand getFreeTimeCommand = new SqlCommand(getFreeTimeQuery, connection, transaction);
                    getFreeTimeCommand.Parameters.AddWithValue("@minutes", minutes);
                    int count = (int)getFreeTimeCommand.ExecuteScalar();


                    if (count > 0)
                    {
                        int[] timeSuggestion = new int[2];

                        string getFirstFreeTimeQuery = "SELECT TOP 1 day_id, timeWindow_id FROM freeTime WHERE freetimeAmount > @minutes AND assingedTask_id IS NULL";
                        SqlCommand getFirstFreeTimeCommand = new SqlCommand(getFirstFreeTimeQuery, connection, transaction);
                        getFirstFreeTimeCommand.Parameters.AddWithValue("@minutes", minutes);

                        using (SqlDataReader reader = getFirstFreeTimeCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                timeSuggestion[0] = reader.GetInt32(0);
                                timeSuggestion[1] = reader.GetInt32(1);
                            }
                        }

                        string updateTimeWindowQuery = "UPDATE freeTime SET assingedTask_id= @task_id WHERE timeWindow_id= @timeWindow_id";
                        SqlCommand updateTimeWindowCommand = new SqlCommand(updateTimeWindowQuery, connection, transaction);
                        updateTimeWindowCommand.Parameters.AddWithValue("@task_id", countTasks);
                        updateTimeWindowCommand.Parameters.AddWithValue("@timeWindow_id", timeSuggestion[1]);
                        updateTimeWindowCommand.ExecuteScalar();


                        Wochentag wochentag = (Wochentag)timeSuggestion[0];
                        MessageBox.Show("Deine neue Aufgabe wurde am " + wochentag + " eingeteilt, viel Erfolg!");
                    }
                    else
                    {
                        MessageBox.Show("Deine Woche hat keine Freie Zeit mehr vorhanden.");
                        transaction.Rollback();
                        return;
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                    transaction.Rollback();
                }

            }
        }

        private void chancel_btn_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Close();
        }
    }
}
