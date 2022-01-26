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
    public partial class Tables : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nodirbek\Desktop\Dashboard_Winform\Dashboard\StudentsDB.mdf;Integrated Security=True";
        SqlConnection connection = null;
        SqlDataAdapter adapter = null;
        SqlCommand command = null;
        DataTable table = null;


        public Tables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string readQuery = "SELECT * FROM Students;";
            adapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
