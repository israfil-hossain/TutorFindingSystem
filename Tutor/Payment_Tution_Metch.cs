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
    public partial class Payment_Tution_Metch : Form
    {
        public Payment_Tution_Metch()
        {
            InitializeComponent();
        }

        private void btngen_Click(object sender, EventArgs e)
        {
            txtrich.Clear();
            txtrich.Text += "**********************************************\n\n";
            txtrich.Text += " **  Fees Receipt System ** \n";
            txtrich.Text += "**********************************************\n\n";
            txtrich.Text += "Date :" + DateTime.Now.ToShortDateString() + "\n\n";

            txtrich.Text += "Tutor ID : " + txtId.Text + "\n\n";
            txtrich.Text += "Tutor Name : " + txtName.Text + "\n\n";
            txtrich.Text += "Phone  : " + txtPhone.Text + "\n\n";
            txtrich.Text += "Fees  : " + txtFees.Text + "\n\n";

            txtrich.Text += "\n        PAID ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtrich.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtFees.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
