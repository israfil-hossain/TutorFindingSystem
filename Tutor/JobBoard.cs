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
    public partial class JobBoard : Form
    {
        int i;
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        string cs2 = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public JobBoard()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            JobBoard2 job2 = new JobBoard2();
            job2.Show();
            this.Hide();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        returnclass rc = new returnclass();
        private void JobBoard_Load(object sender, EventArgs e)
        {
            //lblScore.Text = score.ToString();
            i = Convert.ToInt32(rc.scalarReturn2("select min(ID) from PARENT_POST_TBL"));
            txtjobid.Text = rc.scalarReturn2("select ID from PARENT_POST_TBL where ID =" + i);
            txtname.Text = rc.scalarReturn2("select NAME from PARENT_POST_TBL where ID =" + i);
            txtdistrict.Text = rc.scalarReturn2("select DISTRICT from PARENT_POST_TBL where ID =" + i);
            txtgender.Text = rc.scalarReturn2("select STUDENT_GENDER from PARENT_POST_TBL where ID =" + i);
            txtschool.Text = rc.scalarReturn2("select SCHOOL_NAME from PARENT_POST_TBL where ID =" + i);
            txtphone.Text = rc.scalarReturn2("select PHONE_NUMBER from PARENT_POST_TBL where ID =" + i);
            txtaddress.Text = rc.scalarReturn2("select PARENT_ADDRESS from PARENT_POST_TBL where ID =" + i);
            txtsalary.Text = rc.scalarReturn2("select SALARY_RANGE from PARENT_POST_TBL where ID =" + i);
            txtinformation.Text = rc.scalarReturn2("select ADDITIONAL_INFO from PARENT_POST_TBL where ID =" + i);
            

        }
        string s;
        private void btnNxt_Click(object sender, EventArgs e)
        {
            {
                s = rc.scalarReturn2("select min(ID) from PARENT_POST_TBL Where ID >" + i );
               
                if (s.Equals(""))
                {
                    MessageBox.Show("Job is Over !");
                    btnNxt.Enabled = false;
                }

                else
                {
                    i = Convert.ToInt32(s);
                   
                    txtjobid.Text = rc.scalarReturn2("select ID from PARENT_POST_TBL where ID =" + i);
                    txtname.Text = rc.scalarReturn2("select NAME from PARENT_POST_TBL where ID =" + i);
                    txtdistrict.Text = rc.scalarReturn2("select DISTRICT from PARENT_POST_TBL where ID =" + i);
                    txtgender.Text = rc.scalarReturn2("select STUDENT_GENDER from PARENT_POST_TBL where ID =" + i);
                    txtschool.Text = rc.scalarReturn2("select SCHOOL_NAME from PARENT_POST_TBL where ID =" + i);
                    txtphone.Text = rc.scalarReturn2("select PHONE_NUMBER from PARENT_POST_TBL where ID =" + i);
                    txtaddress.Text = rc.scalarReturn2("select PARENT_ADDRESS from PARENT_POST_TBL where ID =" + i);
                    txtsalary.Text = rc.scalarReturn2("select SALARY_RANGE from PARENT_POST_TBL where ID =" + i);
                    txtinformation.Text = rc.scalarReturn2("select ADDITIONAL_INFO from PARENT_POST_TBL where ID =" + i);
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into JobBoard values(@std_id,@std_name,@district,@gender,@School_Name,@Phone,@p_address,@salary,@A_info)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@std_id", txtjobid.Text);
            cmd.Parameters.AddWithValue("@std_name", txtname.Text);
            cmd.Parameters.AddWithValue("@district", txtdistrict.Text);
            cmd.Parameters.AddWithValue("@gender", txtgender.Text);
            cmd.Parameters.AddWithValue("@School_Name", txtschool.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@p_address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@A_info", txtinformation.Text);

            
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Apply Successfully !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //StudentLogin st = new StudentLogin();
                //st.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the form ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
