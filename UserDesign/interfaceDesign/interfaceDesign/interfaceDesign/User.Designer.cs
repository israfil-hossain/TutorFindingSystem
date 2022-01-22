
namespace UserInterface
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudent = new XanderUI.XUIButton();
            this.btnTutor = new XanderUI.XUIButton();
            this.btnParents = new XanderUI.XUIButton();
            this.btnAdmin = new XanderUI.XUIButton();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.circularPictureBox2 = new UserInterface.CircularPictureBox();
            this.circularPictureBox5 = new UserInterface.CircularPictureBox();
            this.circularPictureBox1 = new UserInterface.CircularPictureBox();
            this.circularPictureBox3 = new UserInterface.CircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.circularPictureBox2);
            this.panel1.Controls.Add(this.btnTutor);
            this.panel1.Controls.Add(this.btnParents);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.circularPictureBox5);
            this.panel1.Controls.Add(this.circularPictureBox1);
            this.panel1.Controls.Add(this.circularPictureBox3);
            this.panel1.Location = new System.Drawing.Point(33, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 265);
            this.panel1.TabIndex = 4;
            // 
            // btnStudent
            // 
            this.btnStudent.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnStudent.ButtonImage = null;
            this.btnStudent.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnStudent.ButtonText = "Student";
            this.btnStudent.ClickBackColor = System.Drawing.Color.White;
            this.btnStudent.ClickTextColor = System.Drawing.Color.White;
            this.btnStudent.CornerRadius = 5;
            this.btnStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStudent.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnStudent.HoverTextColor = System.Drawing.Color.DarkCyan;
            this.btnStudent.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnStudent.Location = new System.Drawing.Point(570, 175);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(111, 38);
            this.btnStudent.TabIndex = 9;
            this.btnStudent.TextColor = System.Drawing.Color.White;
            this.btnStudent.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTutor.ButtonImage = null;
            this.btnTutor.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnTutor.ButtonText = "Tutor";
            this.btnTutor.ClickBackColor = System.Drawing.Color.White;
            this.btnTutor.ClickTextColor = System.Drawing.Color.White;
            this.btnTutor.CornerRadius = 5;
            this.btnTutor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutor.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTutor.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnTutor.HoverTextColor = System.Drawing.Color.DarkCyan;
            this.btnTutor.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTutor.Location = new System.Drawing.Point(395, 175);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(111, 38);
            this.btnTutor.TabIndex = 8;
            this.btnTutor.TextColor = System.Drawing.Color.White;
            this.btnTutor.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnParents
            // 
            this.btnParents.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnParents.ButtonImage = null;
            this.btnParents.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnParents.ButtonText = "Parents";
            this.btnParents.ClickBackColor = System.Drawing.Color.White;
            this.btnParents.ClickTextColor = System.Drawing.Color.White;
            this.btnParents.CornerRadius = 5;
            this.btnParents.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParents.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnParents.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnParents.HoverTextColor = System.Drawing.Color.DarkCyan;
            this.btnParents.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnParents.Location = new System.Drawing.Point(208, 175);
            this.btnParents.Name = "btnParents";
            this.btnParents.Size = new System.Drawing.Size(111, 38);
            this.btnParents.TabIndex = 7;
            this.btnParents.TextColor = System.Drawing.Color.White;
            this.btnParents.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnParents.Click += new System.EventHandler(this.btnParents_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnAdmin.ButtonImage = null;
            this.btnAdmin.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnAdmin.ButtonText = "Admin";
            this.btnAdmin.ClickBackColor = System.Drawing.Color.White;
            this.btnAdmin.ClickTextColor = System.Drawing.Color.White;
            this.btnAdmin.CornerRadius = 5;
            this.btnAdmin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdmin.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnAdmin.HoverTextColor = System.Drawing.Color.DarkCyan;
            this.btnAdmin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdmin.Location = new System.Drawing.Point(33, 175);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(111, 38);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.TextColor = System.Drawing.Color.White;
            this.btnAdmin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(4, 12);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(752, 46);
            this.xuiBanner1.TabIndex = 5;
            this.xuiBanner1.Text = "USER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 33);
            this.panel2.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(708, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.BackColor = System.Drawing.Color.White;
            this.circularPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox2.Image")));
            this.circularPictureBox2.Location = new System.Drawing.Point(570, 13);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(104, 103);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox2.TabIndex = 1;
            this.circularPictureBox2.TabStop = false;
            // 
            // circularPictureBox5
            // 
            this.circularPictureBox5.BackColor = System.Drawing.Color.White;
            this.circularPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox5.Image")));
            this.circularPictureBox5.Location = new System.Drawing.Point(211, 13);
            this.circularPictureBox5.Name = "circularPictureBox5";
            this.circularPictureBox5.Size = new System.Drawing.Size(108, 103);
            this.circularPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox5.TabIndex = 5;
            this.circularPictureBox5.TabStop = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.White;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(33, 13);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(103, 103);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // circularPictureBox3
            // 
            this.circularPictureBox3.BackColor = System.Drawing.Color.White;
            this.circularPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox3.Image")));
            this.circularPictureBox3.Location = new System.Drawing.Point(404, 13);
            this.circularPictureBox3.Name = "circularPictureBox3";
            this.circularPictureBox3.Size = new System.Drawing.Size(102, 103);
            this.circularPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox3.TabIndex = 2;
            this.circularPictureBox3.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::UserInterface.Properties.Resources._252;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.xuiBanner1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
        private CircularPictureBox circularPictureBox3;
        private System.Windows.Forms.Panel panel1;
        private CircularPictureBox circularPictureBox5;
        private XanderUI.XUIButton btnStudent;
        private XanderUI.XUIButton btnTutor;
        private XanderUI.XUIButton btnParents;
        private XanderUI.XUIButton btnAdmin;
        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
    }
}