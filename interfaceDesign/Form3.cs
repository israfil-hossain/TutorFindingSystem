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
    public partial class ParentForm3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        public static string tutorsId;
        public ParentForm3()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            button2.Visible = true;

        }

        void BindGridView()
        {
            string dist = comboBox1.Text;
            string gender = comboBox2.Text;
            SqlConnection con = new SqlConnection(cs);
            string query3 = "select id,name,district,tutors_gender,qualification,photo from tutor_table where district ='"+dist+"' and tutors_gender='"+gender+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query3,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[5];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 70;
            data.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGridView();

            dataGridView1.Visible = true;
            label2.Visible = true;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            button2.Visible = false;
            tutorsId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            button3.Visible = true;
            button4.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tutorsId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ParentForm6 f6 = new ParentForm6();
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
