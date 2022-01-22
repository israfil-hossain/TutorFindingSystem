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

namespace Tutor_Student_Interface
{
    public partial class Applied_Tution : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public Applied_Tution()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Applied_Tution_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet2.JobBoard' table. You can move, or remove it, as needed.
            //this.jobBoardTableAdapter.Fill(this.masterDataSet2.JobBoard);

            string q = "select * from JobBoard";
            ViewClass vc = new ViewClass(q);
            dataGridView1.DataSource = vc.showrecord();
            SqlDataAdapter sda = new SqlDataAdapter("select Distinct std_id from JobBoard", cs);
            DataSet dset = new DataSet();
            sda.Fill(dset);
            comboBox1.DataSource = dset.Tables[0];
            comboBox1.DisplayMember = "std_id";
            comboBox1.ValueMember = "std_id";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from JobBoard where std_id = @std_id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@std_id", comboBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully !");
                //BindGridView();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Data not Deleted ! ");
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string q = "select * from JobBoard where std_id ='"+comboBox1.SelectedValue.ToString()+"'";
            ViewClass vc = new ViewClass(q);
            dataGridView1.DataSource = vc.showrecord();
        }
    }
}
