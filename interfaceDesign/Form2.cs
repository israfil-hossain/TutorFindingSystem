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

namespace Tutor_Student_Interface
{
    public partial class ParentForm2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public ParentForm2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="" &&textBox5.Text!="")
            {
                SqlConnection c2 = new SqlConnection(cs);
                string query1 = "insert into parent_post_tbl values(@id,@name,@district,@student_gender,@school_name,@phone_number,@parent_address,@salary_range,@additional_info)";
                SqlCommand cmd1 = new SqlCommand(query1, c2);
                cmd1.Parameters.AddWithValue("@id", textBox6.Text);
                cmd1.Parameters.AddWithValue("@name", textBox1.Text);
                cmd1.Parameters.AddWithValue("@district", comboBox1.Text);
                cmd1.Parameters.AddWithValue("@student_gender", comboBox2.Text);
                cmd1.Parameters.AddWithValue("@school_name", textBox2.Text);
                cmd1.Parameters.AddWithValue("@phone_number", textBox3.Text);
                cmd1.Parameters.AddWithValue("@parent_address", textBox4.Text);
                cmd1.Parameters.AddWithValue("@salary_range", comboBox3.Text);
                cmd1.Parameters.AddWithValue("@additional_info", textBox5.Text);

                c2.Open();
                int a = cmd1.ExecuteNonQuery();
                if (a>0)
                {
                    MessageBox.Show("Form submitted successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Data no inserted!!");
                }

            }
            else
            {
                MessageBox.Show("Fillup all informations.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }   
}
