using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_Student_Interface.Forms
{
    public partial class Update_Question : Form
    {
        int selectedRow;
        function fn = new function();
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public Update_Question()
        {
            InitializeComponent();
            
        }


        private void Update_Question_Load(object sender, EventArgs e)
        {
            BindGridView();
        }
        void BindGridView()
        {
            string q = "select * from questions";
            ViewClass vc = new ViewClass(q);
            dataGridView1.DataSource = vc.showrecord();
        }



        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedIndex.ToString() ;
            //string item1 = comboBox1.SelectedValue.ToString();
            // txtSet.Text = comboBox1.SelectedValue.ToString();
            txtid.Text = item;

            string query = "select * from questions where q_fk_ex  = '" + item + "' ";
            DataSet ds = fn.getData(query); //return a dataset  
            SqlConnection con = new SqlConnection(cs);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader rd = com.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    txtop1.Text = rd.GetValue(2).ToString();
                    txtop2.Text = rd.GetValue(3).ToString();
                    txtop3.Text = rd.GetValue(4).ToString();
                    txtop4.Text = rd.GetValue(5).ToString();
                    txtans.Text = rd.GetValue(6).ToString();
                }
                else
                {
                    MessageBox.Show("This is does not exist.");
                }
                //com.Dispose();
                con.Close();


            }
            else
            {
                MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(cs);
            string query = "update questions set q_title=@q_title,q_opa=@q_opa,q_opb=@q_opb,q_opc=@q_opc,q_opd=@q_opd,q_opcorrect=@q_opcorrect ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@q_id", txtid.Text);
            cmd.Parameters.AddWithValue("@q_title", txtqus.Text);
            cmd.Parameters.AddWithValue("@q_opa", txtop1.Text);
            cmd.Parameters.AddWithValue("@q_opb", txtop2.Text);
            cmd.Parameters.AddWithValue("@q_opc", txtop3.Text);
            cmd.Parameters.AddWithValue("@q_opd", txtop4.Text);
            cmd.Parameters.AddWithValue("@q_opcorrect", txtans.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("Data Updated Successfully ! ");
                BindGridView();
                ResetContro();
            }
            else
            {
                MessageBox.Show("Data not Updated !");
            }*/



            questions q = new questions();
            q.q_title = txtqus.Text;
            q.q_opa = txtop1.Text;
            q.q_opb = txtop2.Text;
            q.q_opc = txtop3.Text;
            q.q_opd = txtop4.Text;
            q.q_opcorrect = txtans.Text;
            q.q_addeddate = DateTime.Now.ToShortDateString();
            q.q_fk_ad = TutorLogin.fk_ad;
            q.q_fk_ex = txtid.Text;

            InsertClass ic = new InsertClass();
            string msg = ic.insert_srecord2(q);
            MessageBox.Show(msg);

        }

        


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            
            txtqus.Text = row.Cells[1].Value.ToString();
            txtop1.Text = row.Cells[2].Value.ToString();
            txtop2.Text = row.Cells[3].Value.ToString();
            txtop3.Text = row.Cells[4].Value.ToString();
            txtop4.Text = row.Cells[5].Value.ToString();
            txtans.Text = row.Cells[6].Value.ToString();
            txtid.Text = row.Cells[9].Value.ToString();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            ResetContro();
        }
        void ResetContro()
        {
            txtid.Clear();
            txtans.Clear();
            txtop1.Clear();
            txtop2.Clear();
            txtop3.Clear();
            txtop4.Clear();
            txtans.Clear();
        }

    }
}
