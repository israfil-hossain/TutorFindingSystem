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
    public partial class TutorRegistration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public TutorRegistration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btnSignup.Enabled = true; 
            }
            else
            {
                btnSignup.Enabled = false;
            }
        }

       

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Tutor_Registration values(@name,@phone,@gender,@Email,@Password)";
            SqlCommand cmd = new SqlCommand(query, con);
           // cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
            cmd.Parameters.AddWithValue("@gender", CmbGender.SelectedItem.ToString()); 
            cmd.Parameters.AddWithValue("@Email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password",txtPass.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery(); 
            if(a>0)
            {
                MessageBox.Show("Data Inserted Successfully !","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TutorLogin Tu =new TutorLogin();
                Tu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the form ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Id as int )),0)+1 from Tutor_Registration", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtId.Text = dt.Rows[0][0].ToString();
            //txtName.Focus();
            this.ActiveControl = txtName;
            btnSignup.Enabled = false;
        }

        private void check_Show_CheckedChanged(object sender, EventArgs e)
        {
            bool status = check_Show.Checked; 
            switch(status)
            {
                case true:
                    txtPass.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPass.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void CmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TutorLogin Tl = new TutorLogin();
            Tl.Show();
            this.Close();
        }
    }
}
