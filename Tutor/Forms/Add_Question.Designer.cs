
namespace Tutor_Student_Interface.Forms
{
    partial class Add_Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Question));
            this.panel2 = new System.Windows.Forms.Panel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.btnAdd = new XanderUI.XUIButton();
            this.btnReset = new XanderUI.XUIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtqus = new System.Windows.Forms.TextBox();
            this.txtans = new System.Windows.Forms.TextBox();
            this.txtop4 = new System.Windows.Forms.TextBox();
            this.txtop3 = new System.Windows.Forms.TextBox();
            this.txtop2 = new System.Windows.Forms.TextBox();
            this.txtop1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tutorsPointDataSet = new Tutor_Student_Interface.TutorsPointDataSet();
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examsTableAdapter = new Tutor_Student_Interface.TutorsPointDataSetTableAdapters.examsTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorsPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.xuiButton1);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 37);
            this.panel2.TabIndex = 53;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Next";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(382, 6);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(74, 28);
            this.xuiButton1.TabIndex = 17;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ButtonImage")));
            this.btnAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAdd.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.CornerRadius = 5;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAdd.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdd.Location = new System.Drawing.Point(170, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 28);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ButtonImage")));
            this.btnReset.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnReset.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.CornerRadius = 5;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReset.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnReset.Location = new System.Drawing.Point(279, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 28);
            this.btnReset.TabIndex = 15;
            this.btnReset.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Subject Name : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(177, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 51;
            this.label7.Text = "Question : ";
            // 
            // txtqus
            // 
            this.txtqus.Location = new System.Drawing.Point(180, 96);
            this.txtqus.Multiline = true;
            this.txtqus.Name = "txtqus";
            this.txtqus.Size = new System.Drawing.Size(386, 54);
            this.txtqus.TabIndex = 50;
            // 
            // txtans
            // 
            this.txtans.Location = new System.Drawing.Point(180, 506);
            this.txtans.Multiline = true;
            this.txtans.Name = "txtans";
            this.txtans.Size = new System.Drawing.Size(271, 44);
            this.txtans.TabIndex = 49;
            // 
            // txtop4
            // 
            this.txtop4.Location = new System.Drawing.Point(180, 429);
            this.txtop4.Multiline = true;
            this.txtop4.Name = "txtop4";
            this.txtop4.Size = new System.Drawing.Size(271, 44);
            this.txtop4.TabIndex = 48;
            // 
            // txtop3
            // 
            this.txtop3.Location = new System.Drawing.Point(180, 349);
            this.txtop3.Multiline = true;
            this.txtop3.Name = "txtop3";
            this.txtop3.Size = new System.Drawing.Size(271, 44);
            this.txtop3.TabIndex = 47;
            // 
            // txtop2
            // 
            this.txtop2.Location = new System.Drawing.Point(180, 267);
            this.txtop2.Multiline = true;
            this.txtop2.Name = "txtop2";
            this.txtop2.Size = new System.Drawing.Size(271, 44);
            this.txtop2.TabIndex = 46;
            // 
            // txtop1
            // 
            this.txtop1.Location = new System.Drawing.Point(180, 196);
            this.txtop1.Multiline = true;
            this.txtop1.Name = "txtop1";
            this.txtop1.Size = new System.Drawing.Size(271, 44);
            this.txtop1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(177, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Answer : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(177, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Option 4 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(178, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Option 3 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(177, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Option 2 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(176, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Option 1 : ";
            // 
            // txtSet
            // 
            this.txtSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSet.BackColor = System.Drawing.SystemColors.Window;
            this.txtSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSet.Enabled = false;
            this.txtSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSet.Location = new System.Drawing.Point(28, 34);
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(37, 17);
            this.txtSet.TabIndex = 39;
            this.txtSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSet.TextChanged += new System.EventHandler(this.txtSet_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Set";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.examsBindingSource;
            this.comboBox1.DisplayMember = "exam_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(494, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.ValueMember = "ex_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tutorsPointDataSet
            // 
            this.tutorsPointDataSet.DataSetName = "TutorsPointDataSet";
            this.tutorsPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examsBindingSource
            // 
            this.examsBindingSource.DataMember = "exams";
            this.examsBindingSource.DataSource = this.tutorsPointDataSet;
            // 
            // examsTableAdapter
            // 
            this.examsTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 623);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtqus);
            this.Controls.Add(this.txtans);
            this.Controls.Add(this.txtop4);
            this.Controls.Add(this.txtop3);
            this.Controls.Add(this.txtop2);
            this.Controls.Add(this.txtop1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Question";
            this.Text = "Add_Question";
            this.Load += new System.EventHandler(this.Add_Question_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorsPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtqus;
        private System.Windows.Forms.TextBox txtans;
        private System.Windows.Forms.TextBox txtop4;
        private System.Windows.Forms.TextBox txtop3;
        private System.Windows.Forms.TextBox txtop2;
        private System.Windows.Forms.TextBox txtop1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private XanderUI.XUIButton xuiButton1;
        private TutorsPointDataSet tutorsPointDataSet;
        private System.Windows.Forms.BindingSource examsBindingSource;
        private TutorsPointDataSetTableAdapters.examsTableAdapter examsTableAdapter;
        //private masterDataSet1TableAdapters.examsTableAdapter examsTableAdapter;
    }
}