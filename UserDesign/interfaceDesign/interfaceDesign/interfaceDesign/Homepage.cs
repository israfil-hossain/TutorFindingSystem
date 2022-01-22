using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace UserInterface
{
    public partial class Homepage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public Homepage()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserForm6 f6 = new UserForm6();
            f6.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            User us = new User();
            us.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UserForm5 f5 = new UserForm5();
            f5.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            UserForm2 f2 = new UserForm2();
            f2.Show();
        }
    }
    }
