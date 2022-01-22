using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_Student_Interface
{
    public partial class JobBoard2 : Form
    {
        public JobBoard2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apply Successfully ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apply Successfully ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apply Successfully ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apply Successfully ");
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            JobBoard job1 = new JobBoard();
            job1.Show();
            this.Hide();
        }
    }
}
