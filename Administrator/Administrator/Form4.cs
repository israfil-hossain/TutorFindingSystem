using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace interfaceDesign
{
    public partial class Form4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Admin"].ConnectionString;
        public static string postId;
        public void tutorlist()
        {
            SqlConnection con = new SqlConnection(cs);
            string query3 = "select * from parent_post_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query3, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 70;
            data.Dispose();
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            postId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(cs);
            string cmd = "delete  from parent_post_tbl where id='" + postId + "'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd,con);



            con.Open();


            MessageBox.Show("The Data has been Deleted");
            con.Close();
            tutorlist();
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            postId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Allowed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            postId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Denied");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tutorlist();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            postId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
