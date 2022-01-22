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
using System.IO;

namespace Tutor_Student_Interface
{
    public partial class TutorLogin : Form
    {
        public static string fk_ad;
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;

        public TutorLogin()
        {
            InitializeComponent();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername,"Enter your Username please!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string password = txtpassword.Text;
            string userdb, passworddb;
            returnclass rc = new returnclass();
            userdb = rc.scalarReturn("select count(id) from Tutor_Registration where name='" + user + "'");
            if(userdb.Equals("0"))
            {
                MessageBox.Show("Invalid user name!");
            }
            else
            {
                passworddb = rc.scalarReturn("select password from Tutor_Registration where password ='" + password + "'");
                if(passworddb.Equals(password))
                {
                    fk_ad = rc.scalarReturn("select id from Tutor_Registration where name ='" + user + "'");
                    Tutor T = new Tutor();
                    T.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                }
            }
            /*
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from Registration where Email=@email and Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tutor Tu = new Tutor();
                    Tu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("error Username and Password","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }

        private void Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TutorRegistration Reg = new TutorRegistration();
            Reg.Show();
            this.Hide();
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

       
    }
}
