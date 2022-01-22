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
    public partial class AlertNotification : Form
    {
        public AlertNotification()
        {
            InitializeComponent();
            Time.Start();
        }

        public void Notification()
        {
            if(NotifyMe.Checked == true )
            {
                BIcon.Image = Properties.Resources.Active;
            }
            else
            {
                BIcon.Image = Properties.Resources.Bell;
                
            }
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            Timelbl.Text = DateTime.Now.ToString("hh:mm:ss");
            Notification();
        }
    }
}
