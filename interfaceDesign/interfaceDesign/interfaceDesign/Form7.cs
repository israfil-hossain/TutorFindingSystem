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
using System.Threading;


namespace interfaceDesign
{
    public partial class ParentForm7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        string id;
        Thread th;
        public ParentForm7()
        {
            InitializeComponent();
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
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
            id ="1233";       
            SqlConnection cont = new SqlConnection(cs);
            string query = "update parent_table set picture=@picture ,name=@name,email=@email, phone_number=@phone_number, username= @username,password=@password where id=" + id + "";
            SqlCommand cmd = new SqlCommand(query, cont);


            cmd.Parameters.AddWithValue("@picture", SavePhoto());
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone_number", textBox3.Text);
            cmd.Parameters.AddWithValue("@username", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);




            cont.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Profile edit successful !");
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Failed !");
            }

            
        }

        private void ParentForm7_Load(object sender, EventArgs e)
        {
            
            SqlConnection cont = new SqlConnection(cs);
            string query2 = "select * from parent_table where id=1233;";
            SqlCommand cmd2 = new SqlCommand(query2, cont);
            SqlDataAdapter da;
            da = new SqlDataAdapter(cmd2);

            DataTable table = new DataTable();
            da.Fill(table);


            label8.Text = table.Rows[0][0].ToString();
            textBox1.Text = table.Rows[0][1].ToString();
            byte[] img = (byte[])table.Rows[0][2];
            textBox3.Text = table.Rows[0][3].ToString();
            textBox2.Text = table.Rows[0][4].ToString();
            textBox4.Text = table.Rows[0][5].ToString();
            textBox5.Text = table.Rows[0][6].ToString();

            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void opennewform()
        {
            Application.Run(new ParentForm1());
        }
    }
}
