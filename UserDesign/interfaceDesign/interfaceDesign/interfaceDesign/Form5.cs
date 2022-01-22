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
    public partial class UserForm5 : Form
    {
       
       string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;

        public UserForm5()
        {
            InitializeComponent();
            
        }


        void BindGridView()
        {
           
            SqlConnection con = new SqlConnection(cs);
            string query3 = "select id,name,district,tutors_gender,qualification,photo from Tutor_TABLE; ";
            SqlDataAdapter sda = new SqlDataAdapter(query3, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[5];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
          
           

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 80;

            data.Dispose();
        }




        private void Form5_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
