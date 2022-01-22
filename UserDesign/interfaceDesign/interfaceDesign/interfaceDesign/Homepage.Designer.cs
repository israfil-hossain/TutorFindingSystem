
namespace UserInterface
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.button4 = new XanderUI.XUIButton();
            this.button3 = new XanderUI.XUIButton();
            this.button2 = new XanderUI.XUIButton();
            this.button1 = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(307, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 91);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(61, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(117, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(676, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Exit";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(116, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 255);
            this.panel1.TabIndex = 9;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiBanner1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(0, 0);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(757, 46);
            this.xuiBanner1.TabIndex = 10;
            this.xuiBanner1.Text = "WELCOME TO TUTORS POINT";
            // 
            // button4
            // 
            this.button4.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.button4.ButtonImage = null;
            this.button4.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.button4.ButtonText = "Available Post";
            this.button4.ClickBackColor = System.Drawing.Color.White;
            this.button4.ClickTextColor = System.Drawing.Color.White;
            this.button4.CornerRadius = 5;
            this.button4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button4.HoverBackgroundColor = System.Drawing.Color.White;
            this.button4.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.button4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button4.Location = new System.Drawing.Point(37, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 36);
            this.button4.TabIndex = 11;
            this.button4.TextColor = System.Drawing.Color.White;
            this.button4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.button3.ButtonImage = null;
            this.button3.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.button3.ButtonText = "Tutor List";
            this.button3.ClickBackColor = System.Drawing.Color.White;
            this.button3.ClickTextColor = System.Drawing.Color.White;
            this.button3.CornerRadius = 5;
            this.button3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button3.HoverBackgroundColor = System.Drawing.Color.White;
            this.button3.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.button3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button3.Location = new System.Drawing.Point(303, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 36);
            this.button3.TabIndex = 12;
            this.button3.TextColor = System.Drawing.Color.White;
            this.button3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.button2.ButtonImage = null;
            this.button2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button2.ButtonText = "Create Account";
            this.button2.ClickBackColor = System.Drawing.Color.White;
            this.button2.ClickTextColor = System.Drawing.Color.White;
            this.button2.CornerRadius = 5;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button2.HoverBackgroundColor = System.Drawing.Color.White;
            this.button2.HoverTextColor = System.Drawing.Color.RoyalBlue;
            this.button2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button2.Location = new System.Drawing.Point(398, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 36);
            this.button2.TabIndex = 11;
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.button1.ButtonImage = null;
            this.button1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button1.ButtonText = "Login";
            this.button1.ClickBackColor = System.Drawing.Color.White;
            this.button1.ClickTextColor = System.Drawing.Color.White;
            this.button1.CornerRadius = 5;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button1.HoverBackgroundColor = System.Drawing.Color.White;
            this.button1.HoverTextColor = System.Drawing.Color.RoyalBlue;
            this.button1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button1.Location = new System.Drawing.Point(539, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 12;
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.xuiBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIBanner xuiBanner1;
        private XanderUI.XUIButton button3;
        private XanderUI.XUIButton button4;
        private XanderUI.XUIButton button2;
        private XanderUI.XUIButton button1;
    }
}

