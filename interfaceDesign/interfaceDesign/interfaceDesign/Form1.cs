using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Threading;


namespace interfaceDesign
{
    public partial class ParentForm1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;
        Thread th;

        public ParentForm1()
        {
            InitializeComponent();

            SqlConnection c1 = new SqlConnection(cs);
            string query = "SELECT PICTURE,NAME,ID FROM PARENT_TABLE WHERE ID=1233";
            SqlCommand cmd = new SqlCommand(query, c1);

            SqlDataAdapter da;
            da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            da.Fill(table);

            byte[] img = (byte[])table.Rows[0][0];
            label3.Text = table.Rows[0][1].ToString();
            label3.Visible = true;
            label4.Text = table.Rows[0][2].ToString();
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParentForm2 f2 = new ParentForm2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParentForm3 f3 = new ParentForm3();
            f3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParentForm4 f4 = new ParentForm4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ParentForm5 f5 = new ParentForm5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

          
        }

        private void opennewform()
        {
            Application.Run(new ParentForm7());
        }
    }
}
