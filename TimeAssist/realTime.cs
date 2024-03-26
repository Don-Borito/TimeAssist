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
    public partial class realTime : Form
    {
        public realTime()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string task_id = taskId_text.Text;
            string minutes = realTime_text.Text;

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string taskExistsQuery = "SELECT COUNT (*) FROM tasks WHERE task_id = @task_id";
                    SqlCommand taskExistsCommand = new SqlCommand(taskExistsQuery, connection, transaction);
                    taskExistsCommand.Parameters.AddWithValue("@task_id", task_id);
                    int count = (int)taskExistsCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Diese Aufgabe exisisiert nicht!");
                        transaction.Rollback();
                        return;
                    }

                    string getTaskTimeQuery = "SELECT estimatedTime FROM tasks WHERE task_id = @task_id";
                    SqlCommand getTaskTimeCommand = new SqlCommand(getTaskTimeQuery, connection, transaction);
                    getTaskTimeCommand.Parameters.AddWithValue("@task_id", task_id);
                    int estimatedTime = (int)getTaskTimeCommand.ExecuteScalar();

                    string updateTaskQuery = "UPDATE tasks SET realTime= @minutes WHERE task_id= @task_id";
                    SqlCommand updateTaskCommand = new SqlCommand(updateTaskQuery, connection, transaction);
                    updateTaskCommand.Parameters.AddWithValue("@minutes", minutes);
                    updateTaskCommand.Parameters.AddWithValue("@task_id", task_id);
                    updateTaskCommand.ExecuteScalar();

                    transaction.Commit();

                    int timediffrence = estimatedTime - Convert.ToInt32(minutes);
                    if (timediffrence > 0)
                    {
                        MessageBox.Show("du hattest für die Aufgabe " +timediffrence+ " min. weniger als geplant.");
                    }
                    else
                    {
                        MessageBox.Show("du hattest für die Aufgabe " +timediffrence*(-1) + " min. mehr als geplant.");
                    }
                    
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
