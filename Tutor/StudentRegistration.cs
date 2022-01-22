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
    public partial class StudentRegistration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public StudentRegistration()
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

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogin st = new StudentLogin();
            st.Show();
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Student_Registration values(@std_name,@std_batchcode,@std_phone,@std_gender,@std_email,@std_password)";
            SqlCommand cmd = new SqlCommand(query, con);
           // cmd.Parameters.AddWithValue("@std_id", txtId.Text);
            cmd.Parameters.AddWithValue("@std_name", txtName.Text);
            cmd.Parameters.AddWithValue("@std_batchcode", txtbatchcode.Text);
            cmd.Parameters.AddWithValue("@std_phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@std_gender", CmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@std_email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@std_password", txtPass.Text);
            //std_ad_id = TutorLogin.fk_ad;
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully !","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                StudentLogin st =new StudentLogin();
                st.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the form ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(std_id as int )),0)+1 from Student_Registration", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtId.Text = dt.Rows[0][0].ToString();
            //txtName.Focus();
            this.ActiveControl = txtName;
            btnSignup.Enabled = false;
        }
    }
}
