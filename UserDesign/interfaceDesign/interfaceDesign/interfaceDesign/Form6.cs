using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UserForm6 : Form
    {
        public UserForm6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm7 f7 = new UserForm7();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm8 f8 = new UserForm8();
            f8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm3 f3 = new UserForm3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Hide();
        }
    }
}
