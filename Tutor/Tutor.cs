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
    public partial class Tutor : Form
    {
        //public static string fk_ad;
        public Tutor()
        {
            InitializeComponent();
        }

       private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void viewProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProfile view = new ViewProfile();
            view.Show();
        }

        private void resumeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resume resum = new Resume();
            resum.Show();
        }

        private void appliedTutionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobBoard job = new JobBoard();
            job.Show();
        }

        private void addHomeWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quiz qu = new Quiz();
            qu.Show();
            //this.Hide();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateProfile up = new UpdateProfile();
            up.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment P = new Payment();
            P.Show();
        }

        private void tutionAlertsToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Applied_Tution ap = new Applied_Tution();
            ap.Show();

        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProfile dp = new DeleteProfile();
            dp.Show();
        }
    }
}
