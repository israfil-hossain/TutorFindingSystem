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
namespace Tutor_Student_Interface
{
    public partial class Payment_Verification : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public Payment_Verification()
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


            /*SET IDENTITY_INSERT archive_table ON;
            SqlConnection con = new SqlConnection(cs);
            // string query = "set identity_insert Payment_veri ON " +
           string query = "insert into PAYMENT_DETAILS values(@fid,@fname,@fphone,@f_fees)"; //,@Fe_fk
            //string query = "Set IDENTITY_INSERT[dbo].[Payment_veri] ON  Insert into [dbo].[Payment_veri] values(@[fid],@[fname],@[fphone],@[f_fees]) Set IDENTITY_INSERT[dbo].[Payment_veri] OFF ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fid", txtId.Text);
            cmd.Parameters.AddWithValue("@fname", txtName.Text);
            cmd.Parameters.AddWithValue("@fphone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@f_fees", txtFees.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //UserChoice fm =new UserSelect();
                //fm.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the form ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }


/*

            if (txtId.Text != "" && txtName.Text != "" && txtPhone.Text != "" && txtFees.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                //string query = "select *from Tutor_Registration where id=@id and Name=@Name and Phone=@Phone ";
                string query = " SELECT T.id=@id,T.Name=@Name,T.Phone=@Phone,F.fees=@fees FROM Tutor_Registration T JOIN Fees1 F ON(T.id = F.f_id)";

                /*SELECT E.first_name NAME, D.department_name DNAME
FROM employees E JOIN departments D
ON(E.department_id = D.department_id);

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@fees", txtFees.Text);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Tutor Tu = new Tutor();
                    //Tu.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("error Username and Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        private void btnExit_Click(object sender, EventArgs e)
        {
            Payment p =new Payment();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtrich.Text, new Font("Microsoft SansSerif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
