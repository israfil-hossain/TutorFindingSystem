using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Tutor_Student_Interface
{
    public partial class ParentForm4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public static string tutorsId;
        public static string comments,rank;

        public ParentForm4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Fill all the information please.");
            }
            else
            {
                if(radioButton1.Checked==true)
                {
                    rank = "1 star\t.";
                }
                if (radioButton2.Checked == true)
                {
                    rank = "2 star\t.";
                }
                if (radioButton3.Checked == true)
                {
                    rank = "3 star\t.";
                }
                if (radioButton4.Checked == true)
                {
                    rank = "4 star\t.";
                }
                if (radioButton5.Checked == true)
                {
                    rank = "5 star\t.";
                }

                comments = textBox2.Text;
                SqlConnection c2 = new SqlConnection(cs);
                string query1 = "update tutor_table set comments='"+rank+""+comments+"' where id='"+tutorsId+"'";
                SqlCommand cmd1 = new SqlCommand(query1, c2);

                c2.Open();
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Rank is sucessful..");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Data no inserted!!");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input the Tutor's id.");
            }
            else
            {
                tutorsId = textBox1.Text;

                SqlConnection c1 = new SqlConnection(cs);
                string query = "SELECT PHOTO,NAME,ID,EMAIL FROM TUTOR_TABLE WHERE ID='" + tutorsId + "'";
                SqlCommand cmd = new SqlCommand(query, c1);

                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                byte[] img = (byte[])table.Rows[0][0];
                label6.Text = table.Rows[0][1].ToString();
                label7.Text = table.Rows[0][2].ToString();
                label10.Text = table.Rows[0][3].ToString();
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                da.Dispose();


                groupBox2.Visible = true;
                button2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ranking is canceled !");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}
