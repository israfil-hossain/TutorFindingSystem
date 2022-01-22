using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Tutor_Student_Interface.Forms
{
    public partial class Delete_Question : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;

        public Delete_Question()
        {
            InitializeComponent();
        }

        //*////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void Delete_Question_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tutorsPointDataSet2.exams' table. You can move, or remove it, as needed.
            this.examsTableAdapter.Fill(this.tutorsPointDataSet2.exams);
            // TODO: This line of code loads data into the 'tutorsPointDataSet1.Student_Registration' table. You can move, or remove it, as needed.
            this.student_RegistrationTableAdapter.Fill(this.tutorsPointDataSet1.Student_Registration);
            // TODO: This line of code loads data into the 'masterDataSet2.exams' table. You can move, or remove it, as needed.

            string q = "select * from  Student_Registration";
            ViewClass vc = new ViewClass(q);
            dataGridView1.DataSource = vc.showrecord();
            SqlDataAdapter sda = new SqlDataAdapter("select distinct std_batchcode from Student_Registration", cs);
            DataSet da = new DataSet();
            sda.Fill(da);
            cmbbox.DataSource = da.Tables[0];
            cmbbox.DisplayMember = "std_batchcode"; // to display rool no. in combobox 
            cmbbox.ValueMember = "std_batchcode"; // to store name as value of combobox for selected rool 



            SqlDataAdapter sda2 = new SqlDataAdapter("select * from exams", cs);
            DataSet ds = new DataSet();
            sda2.Fill(ds);
            cmbbox2.DataSource = ds.Tables[0];
            cmbbox2.DisplayMember = "exam_name"; // to display rool no. in combobox 
            cmbbox2.ValueMember = "ex_id"; // to store name as value of combobox for selected rool
        }

        //*////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnget_Click(object sender, EventArgs e)
        {
            string q = "select * from Student_Registration where std_id not in (select stu_id_fk from set_exam) and std_batchcode='" + cmbbox.SelectedValue.ToString()+"'";
            ViewClass vc = new ViewClass(q);
            dataGridView1.DataSource = vc.showrecord();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertClass ic = new InsertClass();
            ic.insert_setexam(System.DateTime.Now.ToShortDateString(), textBox1.Text, cmbbox2.SelectedValue.ToString());

            string q = "select * form set_exam";
            ViewClass vc = new ViewClass(q);
            dataGridView2.DataSource = vc.showrecord();
             q = "select * from Student_Registration where std_id not in (select stu_id_fk from set_exam) and std_batchcode='" + cmbbox.SelectedValue.ToString() + "'";
            
            ViewClass vc2 = new ViewClass(q);
            dataGridView1.DataSource = vc2.showrecord();


        }

    }
}
