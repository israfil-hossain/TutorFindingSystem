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
using System.IO;
using System.Configuration;

namespace UserInterface
{
    public partial class UserForm2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public UserForm2()
        {
            InitializeComponent();
        }
        void BindGridView()
        {

            SqlConnection con = new SqlConnection(cs);
            string query3 = "select name,district,student_gender,school_name,parent_address,salary_range,additional_info from parent_post_tbl; ";
            SqlDataAdapter sda = new SqlDataAdapter(query3, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            dataGridView1.DataSource = data;

           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 80;

            data.Dispose();
        }





        private void Form2_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
