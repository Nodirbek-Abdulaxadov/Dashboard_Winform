﻿using System;
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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "Admin" && password.Text == "1234")
            {
                Form1 form1 = new Form1();                
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
