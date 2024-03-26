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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TimeAssist
{
    public partial class FreeTime : Form
    {
        public FreeTime()
        {
            InitializeComponent();
        }

        private void setFreeTime_btn_Click(object sender, EventArgs e)
        {
            int day_id = dayOfWeek_drop.SelectedIndex;
            int minutes = Int32.Parse(freeTimeMin_text.Text);


            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string newFreeTimeQuery = "INSERT INTO freeTime (freetimeAmount, day_id) VALUES (@minutes, @day_id)";
                    SqlCommand newFreeTimeCommand = new SqlCommand(newFreeTimeQuery, connection, transaction);
                    newFreeTimeCommand.Parameters.AddWithValue("@minutes", minutes);
                    newFreeTimeCommand.Parameters.AddWithValue("@day_id", day_id);
                    newFreeTimeCommand.ExecuteScalar();

                    transaction.Commit();
                    MessageBox.Show("Freie Zeit wurde hinzugefügt.");
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
