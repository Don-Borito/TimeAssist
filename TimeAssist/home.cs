using System.Data.SqlClient;
using System.Data;

namespace TimeAssist
{
    public partial class home : Form
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

        public home()
        {
            InitializeComponent();
        }

        private void newTask_btn_Click(object sender, EventArgs e)
        {
            new NewTask().Show();
            this.Hide();
        }

        private void newFreeTime_btn_Click(object sender, EventArgs e)
        {
            new FreeTime().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                string getTimeTableQuery = "SELECT tasks.task_id AS [Aufgabe Nr.], tasks.task AS Aufgabe, freeTime.day_id AS Wochentag, tasks.estimatedTime AS [geschätzte Zeit], tasks.realTime AS [tatsächliche Zeit] FROM tasks JOIN freeTime ON freeTime.assingedTask_id = tasks.task_id";
                SqlDataAdapter da = new SqlDataAdapter(getTimeTableQuery, connection);
                DataSet ds = new DataSet();
                transaction.Commit();
                da.Fill(ds, "tasks");

                // Wochentag ID in Wochentag Name umwandeln
                ds.Tables["tasks"].Columns.Add("WochentagString", typeof(string));

                foreach (DataRow row in ds.Tables["tasks"].Rows)
                {
                    int dayId = Convert.ToInt32(row["Wochentag"]);
                    Wochentag wochentag = (Wochentag)dayId;
                    row["WochentagString"] = wochentag.ToString();
                }

                ds.Tables["tasks"].Columns.Remove("Wochentag");
                ds.Tables["tasks"].Columns["WochentagString"].ColumnName = "Wochentag";

                timeTable.DataSource = ds.Tables["tasks"].DefaultView;
            }
        }

        private void realTime_btn_Click(object sender, EventArgs e)
        {
            new realTime().Show();
            this.Hide();
        }
    }
}
