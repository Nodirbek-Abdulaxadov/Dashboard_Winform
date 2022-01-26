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

namespace Dashboard
{
    public partial class Profile : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nodirbek\Desktop\Dashboard_Winform\Dashboard\StudentsDB.mdf;Integrated Security=True";
        SqlConnection connection = null;
        SqlDataAdapter adapter = null;
        SqlCommand command = null;
        DataTable table = null;

        public Profile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (fname.Text != "" && pnumber.Text != "")
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string insertQuery = $"INSERT INTO Students (FirstName, LastName, Phone, Email) VALUES ('{fname.Text}', '{lname.Text}', '{pnumber.Text}', '{email.Text}')";
                    command = new SqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Successfully added new student!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Can't empty required fields!","Error!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void ClearAll()
        {
            fname.Clear();
            pnumber.Clear();
            email.Clear();
            lname.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
