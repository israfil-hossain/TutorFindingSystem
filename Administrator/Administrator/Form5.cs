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

namespace interfaceDesign
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K8H5OEQ\\SQLEXPRESS01;Initial Catalog=TutorsPointAdmin;Integrated Security=True");
        //string cs = ConfigurationManager.ConnectionStrings["Admin"].ConnectionString;
        //SqlConnection con = new SqlConnection(cs);

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int id;
        public Form5()
        {
            InitializeComponent();
            displayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update tutor_table set name=@name, phone_number=@phone_number,email=@email,comments=@comments,report=@report where id ="+id+"", con);
            cmd.Parameters.AddWithValue("@name",textBox1.Text);
            cmd.Parameters.AddWithValue("@phone_number", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@comments", textBox3.Text);
            cmd.Parameters.AddWithValue("@report", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Your Data has been Saved");

            con.Close();
            displayData();
            Clear();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            //con.Open();
            //cmd = new SqlCommand("insert into Tutor values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox4.Text+"')",con);
            //cmd.ExecuteNonQuery();
           // MessageBox.Show(" Your Data has been Saved");
            
            //con.Close();
            //displayData();
           // Clear();
       // }
        public void displayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from tutor_table", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[9];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 70;
            con.Close();
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from tutor_table where id="+id+"",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Data has been Deleted");
            con.Close();
            displayData();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
