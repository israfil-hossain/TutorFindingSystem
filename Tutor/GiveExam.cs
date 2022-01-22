using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_Student_Interface
{
    public partial class GiveExam : Form
    {
        int i,score = 0;
        string correctop;
        public GiveExam()
        {
            InitializeComponent();
        }

        returnclass rc = new returnclass();

        private void GiveExam_Load(object sender, EventArgs e)
        {
            lblScore.Text = score.ToString();
           i =  Convert.ToInt32(rc.scalarReturn("select min(q_id) from questions"));
            txt1.Text = rc.scalarReturn("select q_title from questions where q_id =" + i);
            txt2.Text = rc.scalarReturn("select q_opa from questions where q_id =" + i);
            txt3.Text = rc.scalarReturn("select q_opb from questions where q_id =" + i);
            txt4.Text = rc.scalarReturn("select q_opc from questions where q_id =" + i);
            txt5.Text = rc.scalarReturn("select q_opd from questions where q_id =" + i);
            correctop = rc.scalarReturn("select q_opcorrect from questions where q_id=" + i);
        }

        string s, selectedvalue;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            if(txt2.Checked == true)
            {
                selectedvalue = txt2.Text;
            }
            else if (txt3.Checked == true)
            {
                selectedvalue = txt3.Text;
            }
            else if (txt4.Checked == true)
            {
                selectedvalue = txt4.Text;
            }
            else if (txt5.Checked == true)
            {
                selectedvalue = txt5.Text;
            }
            else
            {
                MessageBox.Show("Please Select One Option ");
            }

            if(selectedvalue.Equals(correctop))
            {
                score++;
                lblScore.Text = lblScore.Text = score.ToString();
            }


            s = rc.scalarReturn("select min(q_id) from questions where q_id >" + i);
            if (s.Equals(""))
            {
                MessageBox.Show("quiz over !");
                btnNxt.Enabled = false;
            }

            else
            {
                i = Convert.ToInt32(s);
                txt1.Text = rc.scalarReturn("select q_title from questions where q_id =" + i);
                txt2.Text = rc.scalarReturn("select q_opa from questions where q_id =" + i);
                txt3.Text = rc.scalarReturn("select q_opb from questions where q_id =" + i);
                txt4.Text = rc.scalarReturn("select q_opc from questions where q_id =" + i);
                txt5.Text = rc.scalarReturn("select q_opd from questions where q_id =" + i);
                correctop = rc.scalarReturn("select q_opcorrect from questions where q_id=" + i);
            }

            radiobtn();
        }
        public void radiobtn()
        {
            txt2.Checked = false;
            txt3.Checked = false;
            txt4.Checked = false;
            txt5.Checked = false;
        }
    }
}
