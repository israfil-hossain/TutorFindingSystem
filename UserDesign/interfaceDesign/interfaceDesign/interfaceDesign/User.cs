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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            Tutor_Student_Interface.TutorLogin Tu = new Tutor_Student_Interface.TutorLogin();
            Tu.Show();
            //this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Tutor_Student_Interface.StudentLogin st = new Tutor_Student_Interface.StudentLogin();
            st.Show();
            //this.Hide();
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            UserInterface.Parentlogin pr = new UserInterface.Parentlogin();
            pr.Show();
            //this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserInterface.Adminlogin Ad = new UserInterface.Adminlogin();
            Ad.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Close();
        }
    }
}
