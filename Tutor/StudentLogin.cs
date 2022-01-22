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
    
    public partial class StudentLogin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentRegistration reg = new StudentRegistration();
            reg.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from Student_Registration where std_name = @std_name and std_password=@std_password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@std_name", txtusername.Text);
                cmd.Parameters.AddWithValue("@std_password", txtpassword.Text);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GiveExam ex = new GiveExam();
                    ex.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("error Username and Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername, "Enter your Username please!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider2.SetError(this.txtpassword, "Enter your Password please!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Hidepass_CheckedChanged(object sender, EventArgs e)
        {
            bool status = Hidepass.Checked;
            switch (status)
            {
                case true:
                    txtpassword.UseSystemPasswordChar = false;
                    break;
                default:
                    txtpassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
