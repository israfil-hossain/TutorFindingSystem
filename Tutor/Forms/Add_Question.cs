using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_Student_Interface.Forms
{
    public partial class Add_Question : Form
    {
        public Add_Question()
        {
            InitializeComponent();
        }

        private void Add_Question_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tutorsPointDataSet.exams' table. You can move, or remove it, as needed.
            this.examsTableAdapter.Fill(this.tutorsPointDataSet.exams);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedIndex.ToString();
            // txtSet.Text = comboBox1.SelectedValue.ToString();
            txtSet.Text = item;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            questions q = new questions();
            q.q_title = txtqus.Text;
            q.q_opa = txtop1.Text;
            q.q_opb = txtop2.Text;
            q.q_opc = txtop3.Text;
            q.q_opd = txtop4.Text;
            q.q_opcorrect = txtans.Text;
            q.q_addeddate = DateTime.Now.ToShortDateString();
            q.q_fk_ad = TutorLogin.fk_ad;
            q.q_fk_ex = comboBox1.SelectedValue.ToString();  

            InsertClass ic = new InsertClass();
            string msg = ic.insert_srecord(q);
            MessageBox.Show(msg);
    }

        private void btnReset_Click(object sender, EventArgs e) 
        {
            //txtSet.Clear();
            //comboBox1.Items.Clear();
            txtqus.Clear();
            txtop1.Clear();
            txtop2.Clear();
            txtop3.Clear();
            txtop4.Clear();
            txtans.Clear();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.examsBindingSource.EndEdit();
            this.Close();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            //txtSet.Clear();
            //comboBox1.Items.Clear();
            txtqus.Clear();
            txtop1.Clear();
            txtop2.Clear();
            txtop3.Clear();
            txtop4.Clear();
            txtans.Clear();
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
