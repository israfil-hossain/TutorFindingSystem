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
using System.IO;
using System.Drawing.Imaging;

namespace Tutor_Student_Interface
{
    public partial class ViewProfile : Form
    {
        function fn = new function();
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.ToString());
            String query = "select * from Update_Tbl where U_id = " + id + "";  //get data from database
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
                    byte[] img = (byte[])(rd[1]);


                    if (img == null)
                        imgbox.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        imgbox.Image = System.Drawing.Image.FromStream(ms);
                    }
                    txtName.Text = rd.GetValue(0).ToString();
                    txtName.Text = rd.GetValue(1).ToString();
                    txtGender.Text = rd.GetValue(2).ToString();
                    txtBCN.Text = rd.GetValue(3).ToString();
                    txtDes.Text = rd.GetValue(4).ToString();
                    txtDistrict.Text = rd.GetValue(5).ToString();
                    txtCity.Text = rd.GetValue(6).ToString();
                    txtSp.Text = rd.GetValue(7).ToString();
                    txtSalary.Text = rd.GetValue(8).ToString();
                    txtDes.Text = rd.GetValue(9).ToString();
                    txtExp.Text = rd.GetValue(10).ToString();
                    txtLang.Text = rd.GetValue(11).ToString();
                    txtEdu.Text = rd.GetValue(12).ToString();
                    txtCnum.Text = rd.GetValue(13).ToString();
                    txtEmail.Text = rd.GetValue(14).ToString();
                    txtFb.Text = rd.GetValue(15).ToString();
                    txtLi.Text = rd.GetValue(16).ToString();
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
        }
    }
}
