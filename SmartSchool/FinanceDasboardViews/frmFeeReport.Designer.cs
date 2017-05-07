using SmartSchool.DataSets;

namespace SmartSchool
{
    partial class frmFeeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeeReport));
            this.gvFeeReport = new System.Windows.Forms.DataGridView();
            this.cbBalanceFees = new System.Windows.Forms.CheckBox();
            this.gvStudentInfo = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMSDataSet = new SmartSchool.DataSets.SMSDataSet();
            this.studentTableAdapter = new SmartSchool.DataSets.SMSDataSetTableAdapters.studentTableAdapter();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboScholarShip = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvFeeReport
            // 
            this.gvFeeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFeeReport.Location = new System.Drawing.Point(140, 228);
            this.gvFeeReport.Name = "gvFeeReport";
            this.gvFeeReport.Size = new System.Drawing.Size(884, 134);
            this.gvFeeReport.TabIndex = 0;
            // 
            // cbBalanceFees
            // 
            this.cbBalanceFees.AutoSize = true;
            this.cbBalanceFees.Location = new System.Drawing.Point(140, 157);
            this.cbBalanceFees.Name = "cbBalanceFees";
            this.cbBalanceFees.Size = new System.Drawing.Size(191, 17);
            this.cbBalanceFees.TabIndex = 1;
            this.cbBalanceFees.Text = "Show Students With Balance Fees";
            this.cbBalanceFees.UseVisualStyleBackColor = true;
            this.cbBalanceFees.CheckedChanged += new System.EventHandler(this.cbBalanceFees_CheckedChanged);
            // 
            // gvStudentInfo
            // 
            this.gvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudentInfo.Location = new System.Drawing.Point(140, 401);
            this.gvStudentInfo.Name = "gvStudentInfo";
            this.gvStudentInfo.Size = new System.Drawing.Size(747, 150);
            this.gvStudentInfo.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 378);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(447, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Student Info (Before Clicking Please Click On The Record Which Detail You Wa" +
    "nt)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboID
            // 
            this.comboID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "stdid", true));
            this.comboID.DataSource = this.studentBindingSource;
            this.comboID.DisplayMember = "stdid";
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(903, 142);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(121, 21);
            this.comboID.TabIndex = 4;
            this.comboID.ValueMember = "stdid";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.sMSDataSetBindingSource;
            // 
            // sMSDataSetBindingSource
            // 
            this.sMSDataSetBindingSource.DataSource = this.sMSDataSet;
            this.sMSDataSetBindingSource.Position = 0;
            // 
            // sMSDataSet
            // 
            this.sMSDataSet.DataSetName = "SMSDataSet";
            this.sMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(903, 172);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(121, 21);
            this.comboMonth.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate Report By Month";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate Report For Specific Student ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Generate Report By Scholar Ship";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboScholarShip
            // 
            this.comboScholarShip.FormattingEnabled = true;
            this.comboScholarShip.Location = new System.Drawing.Point(903, 199);
            this.comboScholarShip.Name = "comboScholarShip";
            this.comboScholarShip.Size = new System.Drawing.Size(121, 21);
            this.comboScholarShip.TabIndex = 11;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(140, 180);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(309, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Show Those Students Who Donot Paid Their Fees On Time";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(140, 199);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(191, 23);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Remaining Balance Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fee Reports";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmFeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.comboScholarShip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gvStudentInfo);
            this.Controls.Add(this.cbBalanceFees);
            this.Controls.Add(this.gvFeeReport);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFeeReport";
            this.ShowIcon = false;
            this.Text = "Fees Reports";
            this.Load += new System.EventHandler(this.frmFeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFeeReport;
        private System.Windows.Forms.CheckBox cbBalanceFees;
        private System.Windows.Forms.DataGridView gvStudentInfo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.BindingSource sMSDataSetBindingSource;
        private SMSDataSet sMSDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DataSets.SMSDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboScholarShip;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}