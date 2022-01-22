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

namespace Tutor_Student_Interface
{
    public partial class UpdateProfile : Form
    {
        string imgLoc = "";
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Update_Tbl values(@img,@fname,@gender,@bcn,@district,@city,@specilalisms,@salary,@Description,@expr,@language,@education,@Cno,@email,@fb_id,@Li_id)";
            SqlCommand cmd = new SqlCommand(query, con);
           // cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());
            cmd.Parameters.AddWithValue("@fname", txtName.Text);
            cmd.Parameters.AddWithValue("@gender",Cmbgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@bcn",txtBcn.Text);
            cmd.Parameters.AddWithValue("@district", txtDistrict.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@specilalisms", txtSp.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@Description", txtDes.Text);
            cmd.Parameters.AddWithValue("@expr", txtExp.Text);
            cmd.Parameters.AddWithValue("@language", txtLang.Text);
            cmd.Parameters.AddWithValue("@education", txtEdu.Text);
            cmd.Parameters.AddWithValue("@Cno", txtCnum.Text.ToString());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToString());
            cmd.Parameters.AddWithValue("@fb_id", txtFb.Text.ToString());
            cmd.Parameters.AddWithValue("@Li_id", txtLi.Text.ToString());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully !");
                
                //this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the form ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            picture.Image.Save(ms, picture.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picture.Image = null;
            txtName.Clear();
            Cmbgender.Items.Clear();
            txtBcn.Clear();
            txtDistrict.Clear();
            txtCity.Clear();
            txtSp.Clear();
            txtSalary.Clear();
            txtDes.Clear();
            txtExp.Clear();
            txtLang.Clear();
            txtEdu.Clear();
            txtCnum.Clear();
            txtEmail.Clear();
            txtFb.Clear();
            txtFb.Clear();
            txtLi.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG File (*png) | *.png";
            // ofd.Filter = "Image File (All files) (*.png,*.jpg) | *.png, *.jpg";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLoc = ofd.FileName.ToString();
                picture.ImageLocation = imgLoc;
                //picture.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
