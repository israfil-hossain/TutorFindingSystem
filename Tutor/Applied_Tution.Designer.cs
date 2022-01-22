
namespace Tutor_Student_Interface
{
    partial class Applied_Tution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applied_Tution));
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndelete = new XanderUI.XUIButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jobBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.masterDataSet2 = new Login_page.masterDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            //this.jobBoardTableAdapter = new Login_page.masterDataSet2TableAdapters.JobBoardTableAdapter();
            this.btnGet = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBoardBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 47);
            this.panel1.TabIndex = 0;
            // 
            // xuiButton1
            // 
            this.xuiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(871, 9);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(22, 21);
            this.xuiButton1.TabIndex = 118;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(309, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Applied Tution ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 35);
            this.panel2.TabIndex = 119;
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackgroundColor = System.Drawing.Color.White;
            this.btndelete.ButtonImage = null;
            this.btndelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.ClickBackColor = System.Drawing.Color.Black;
            this.btndelete.ClickTextColor = System.Drawing.Color.Black;
            this.btndelete.CornerRadius = 5;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btndelete.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btndelete.HoverTextColor = System.Drawing.Color.White;
            this.btndelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btndelete.Location = new System.Drawing.Point(821, 7);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(64, 21);
            this.btndelete.TabIndex = 122;
            this.btndelete.TextColor = System.Drawing.Color.Red;
            this.btndelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.jobBoardBindingSource;
            this.comboBox1.DisplayMember = "std_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 120;
            // 
            // jobBoardBindingSource
            // 
            this.jobBoardBindingSource.DataMember = "JobBoard";
           // this.jobBoardBindingSource.DataSource = this.masterDataSet2;
            // 
            // masterDataSet2
            // 
           // this.masterDataSet2.DataSetName = "masterDataSet2";
            //this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 121;
            this.label2.Text = "Select Job ID : ";
            // 
            // jobBoardTableAdapter
            // 
          //  this.jobBoardTableAdapter.ClearBeforeFill = true;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.BackgroundColor = System.Drawing.Color.White;
            this.btnGet.ButtonImage = null;
            this.btnGet.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnGet.ButtonText = "Get";
            this.btnGet.ClickBackColor = System.Drawing.Color.Black;
            this.btnGet.ClickTextColor = System.Drawing.Color.Black;
            this.btnGet.CornerRadius = 5;
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGet.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnGet.HoverTextColor = System.Drawing.Color.White;
            this.btnGet.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGet.Location = new System.Drawing.Point(325, 105);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(42, 21);
            this.btnGet.TabIndex = 119;
            this.btnGet.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGet.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Applied_Tution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 637);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Applied_Tution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applied_Tution";
            this.Load += new System.EventHandler(this.Applied_Tution_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobBoardBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
       // private masterDataSet2 masterDataSet2;
        private System.Windows.Forms.BindingSource jobBoardBindingSource;
        //private masterDataSet2TableAdapters.JobBoardTableAdapter jobBoardTableAdapter;
        private XanderUI.XUIButton btnGet;
        private XanderUI.XUIButton btndelete;
    }
}