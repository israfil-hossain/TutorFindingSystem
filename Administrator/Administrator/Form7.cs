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

namespace interfaceDesign
{
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Admin"].ConnectionString;
        public static string Id;
        public int selectedRow;


        public Form7()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        void BindGridView()
        {

            SqlConnection con = new SqlConnection(cs);
            string query3 = "select * from student_table";
            SqlDataAdapter sda = new SqlDataAdapter(query3, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            textBox1.Text = data.Rows[0][0].ToString();
            Id = data.Rows[0][0].ToString();

            dataGridView1.DataSource = data;


            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[6];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 70;


            data.Dispose();
          
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //Id = textBox1.Text;

            SqlConnection con = new SqlConnection(cs);
            string query4 = "update student_table set status='blocked' where id=@Id";
            SqlCommand cmd = new SqlCommand(query4, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            // SqlDataAdapter sda = new SqlDataAdapter(query4, con);
           
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Blocked Successfully !");

                //this.Close();
            }
            else
            {
                MessageBox.Show("Blocking unsuccessful ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Blocked");

                BindGridView();
            }

        }
        //private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
            
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //Id = textBox1.Text;

            SqlConnection con = new SqlConnection(cs);
            string query5 = "update student_table set status='Unblocked' where id=@Id";
            SqlCommand cmd = new SqlCommand(query5, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            // SqlDataAdapter sda = new SqlDataAdapter(query4, con);
            

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("UnBlocked Successfully !");

                //this.Close();
            }
            else
            {
                MessageBox.Show("UnBlocking unsuccessful ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("UnBlocked");

                BindGridView();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[0].Value.ToString();
        }
    }
}
