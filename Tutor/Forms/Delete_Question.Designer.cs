
namespace Tutor_Student_Interface.Forms
{
    partial class Delete_Question
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
            this.cmbbox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnget = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new XanderUI.XUIButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tutorsPointDataSet1 = new Tutor_Student_Interface.TutorsPointDataSet1();
            this.studentRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_RegistrationTableAdapter = new Tutor_Student_Interface.TutorsPointDataSet1TableAdapters.Student_RegistrationTableAdapter();
            this.tutorsPointDataSet2 = new Tutor_Student_Interface.TutorsPointDataSet2();
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examsTableAdapter = new Tutor_Student_Interface.TutorsPointDataSet2TableAdapters.examsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorsPointDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorsPointDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbox
            // 
            this.cmbbox.AutoCompleteCustomSource.AddRange(new string[] {
            "All Questions"});
            this.cmbbox.DataSource = this.studentRegistrationBindingSource;
            this.cmbbox.DisplayMember = "std_batchcode";
            this.cmbbox.FormattingEnabled = true;
            this.cmbbox.Location = new System.Drawing.Point(114, 16);
            this.cmbbox.Name = "cmbbox";
            this.cmbbox.Size = new System.Drawing.Size(143, 21);
            this.cmbbox.TabIndex = 73;
            this.cmbbox.ValueMember = "std_id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 33);
            this.panel2.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Batch Code :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 231);
            this.dataGridView1.TabIndex = 74;
            // 
            // btnget
            // 
            this.btnget.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnget.ButtonImage = null;
            this.btnget.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnget.ButtonText = "Get";
            this.btnget.ClickBackColor = System.Drawing.Color.White;
            this.btnget.ClickTextColor = System.Drawing.Color.White;
            this.btnget.CornerRadius = 5;
            this.btnget.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnget.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnget.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnget.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnget.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnget.Location = new System.Drawing.Point(207, 46);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(50, 21);
            this.btnget.TabIndex = 75;
            this.btnget.TextColor = System.Drawing.Color.White;
            this.btnget.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Student ID : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 77;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.ButtonImage = null;
            this.btnAdd.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ClickBackColor = System.Drawing.Color.White;
            this.btnAdd.ClickTextColor = System.Drawing.Color.White;
            this.btnAdd.CornerRadius = 5;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnAdd.HoverTextColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdd.Location = new System.Drawing.Point(207, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 21);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(404, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(330, 237);
            this.dataGridView2.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Exam Name : ";
            // 
            // cmbbox2
            // 
            this.cmbbox2.DataSource = this.examsBindingSource;
            this.cmbbox2.DisplayMember = "exam_name";
            this.cmbbox2.FormattingEnabled = true;
            this.cmbbox2.Location = new System.Drawing.Point(114, 82);
            this.cmbbox2.Name = "cmbbox2";
            this.cmbbox2.Size = new System.Drawing.Size(143, 21);
            this.cmbbox2.TabIndex = 83;
            this.cmbbox2.ValueMember = "ex_id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.cmbbox);
            this.panel1.Controls.Add(this.cmbbox2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnget);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 216);
            this.panel1.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 551);
            this.panel3.TabIndex = 85;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 24);
            this.panel4.TabIndex = 71;
            // 
            // tutorsPointDataSet1
            // 
            this.tutorsPointDataSet1.DataSetName = "TutorsPointDataSet1";
            this.tutorsPointDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentRegistrationBindingSource
            // 
            this.studentRegistrationBindingSource.DataMember = "Student_Registration";
            this.studentRegistrationBindingSource.DataSource = this.tutorsPointDataSet1;
            // 
            // student_RegistrationTableAdapter
            // 
            this.student_RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // tutorsPointDataSet2
            // 
            this.tutorsPointDataSet2.DataSetName = "TutorsPointDataSet2";
            this.tutorsPointDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examsBindingSource
            // 
            this.examsBindingSource.DataMember = "exams";
            this.examsBindingSource.DataSource = this.tutorsPointDataSet2;
            // 
            // examsTableAdapter
            // 
            this.examsTableAdapter.ClearBeforeFill = true;
            // 
            // Delete_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 623);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Question";
            this.Text = "Delete_Question";
            this.Load += new System.EventHandler(this.Delete_Question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorsPointDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorsPointDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private XanderUI.XUIButton btnget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private XanderUI.XUIButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private TutorsPointDataSet1 tutorsPointDataSet1;
        private System.Windows.Forms.BindingSource studentRegistrationBindingSource;
        private TutorsPointDataSet1TableAdapters.Student_RegistrationTableAdapter student_RegistrationTableAdapter;
        private TutorsPointDataSet2 tutorsPointDataSet2;
        private System.Windows.Forms.BindingSource examsBindingSource;
        private TutorsPointDataSet2TableAdapters.examsTableAdapter examsTableAdapter;
    }
}