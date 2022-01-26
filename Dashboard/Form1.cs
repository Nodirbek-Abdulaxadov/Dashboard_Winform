using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            AllHide();
            home1.Visible = true;
        }

        private void AllHide()
        {
            home1.Visible = false;
            tables1.Visible = false;
            profile1.Visible = false;
        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            AllHide();
            tables1.Visible = true;
        }

        private void xuiSuperButton3_Click(object sender, EventArgs e)
        {
            AllHide();
            profile1.Visible = true;
        }
    }
}
