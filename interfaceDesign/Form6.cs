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
using System.IO;

namespace Tutor_Student_Interface
{
    public partial class ParentForm6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        string getId;
        public ParentForm6()
        {
            InitializeComponent();

            getId = ParentForm3.tutorsId;
            SqlConnection c1 = new SqlConnection(cs);
            string query = "SELECT PHOTO,NAME,ID,EMAIL,PHONE_NUMBER FROM TUTOR_TABLE WHERE ID='"+getId+"'";
            SqlCommand cmd = new SqlCommand(query, c1);

            SqlDataAdapter da;
            da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            da.Fill(table);

            byte[] img = (byte[])table.Rows[0][0];
            label2.Text = table.Rows[0][1].ToString();
            label2.Visible = true;
            label3.Text = table.Rows[0][2].ToString();
            label3.Visible = true;
            label4.Text = table.Rows[0][3].ToString();
            label4.Visible = true;
            label5.Text = table.Rows[0][4].ToString();
            label5.Visible = true;

            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application is Confirmed !!\nRequest is send to the Tutor.");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application is canceled !!");
            this.Close();

        }
    }
}
