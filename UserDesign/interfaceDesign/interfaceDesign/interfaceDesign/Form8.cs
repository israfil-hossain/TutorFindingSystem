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

namespace UserInterface
{
    
    public partial class UserForm8 : Form
    {
        string cons = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public UserForm8()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (All Files)*.* |*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "NULL";
            SqlConnection cont = new SqlConnection(cons);
            string query = "insert into tutor_table values (@name,@tutors_gender,@district,@email,@phone_number,@qualification,@comments,@report,@photo,@username,@password)";
            SqlCommand cmd = new SqlCommand(query, cont);
           
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            
            cmd.Parameters.AddWithValue("@tutors_gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@district", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone_number", textBox2.Text);
            cmd.Parameters.AddWithValue("@qualification", textBox6.Text);
            cmd.Parameters.AddWithValue("@comments",s);
            cmd.Parameters.AddWithValue("@report",s);
            cmd.Parameters.AddWithValue("@photo", SavePhoto());
            cmd.Parameters.AddWithValue("@username", textBox7.Text);
            cmd.Parameters.AddWithValue("@password", textBox8.Text);


            cont.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Account Created!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Account  not Created!");
            }
           
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Enter name first..");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox5, "Enter address first..");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider3.SetError(this.textBox2, "Enter phonenumber first..");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider4.SetError(this.textBox4, "Enter email first..");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text) == true)
            {
                textBox6.Focus();
                errorProvider5.SetError(this.textBox6, "Enter qualification first..");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text) == true)
            {
                textBox7.Focus();
                errorProvider6.SetError(this.textBox7, "Enter username first..");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text) == true)
            {
                textBox8.Focus();
                errorProvider7.SetError(this.textBox8, "Enter password first..");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
