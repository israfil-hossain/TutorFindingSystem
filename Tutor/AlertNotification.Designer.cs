
namespace Tutor_Student_Interface
{
    partial class AlertNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timelbl = new System.Windows.Forms.Label();
            this.NotifyMe = new System.Windows.Forms.CheckBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.BIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.Location = new System.Drawing.Point(84, 44);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(42, 19);
            this.Timelbl.TabIndex = 0;
            this.Timelbl.Text = "Time";
            // 
            // NotifyMe
            // 
            this.NotifyMe.AutoSize = true;
            this.NotifyMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyMe.Location = new System.Drawing.Point(163, 142);
            this.NotifyMe.Name = "NotifyMe";
            this.NotifyMe.Size = new System.Drawing.Size(98, 24);
            this.NotifyMe.TabIndex = 1;
            this.NotifyMe.Text = "NotifyMe";
            this.NotifyMe.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // BIcon
            // 
            this.BIcon.Image = global::Tutor_Student_Interface.Properties.Resources.Bell;
            this.BIcon.Location = new System.Drawing.Point(318, 30);
            this.BIcon.Name = "BIcon";
            this.BIcon.Size = new System.Drawing.Size(71, 56);
            this.BIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BIcon.TabIndex = 2;
            this.BIcon.TabStop = false;
            // 
            // AlertNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 230);
            this.Controls.Add(this.BIcon);
            this.Controls.Add(this.NotifyMe);
            this.Controls.Add(this.Timelbl);
            this.Name = "AlertNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertNotification";
            ((System.ComponentModel.ISupportInitialize)(this.BIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.CheckBox NotifyMe;
        private System.Windows.Forms.PictureBox BIcon;
        private System.Windows.Forms.Timer Time;
    }
}