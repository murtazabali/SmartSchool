using SmartSchool.DataSets;

namespace SmartSchool
{
    partial class frmSalaryReport
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
            this.comboBonus = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMSDataSet = new SmartSchool.DataSets.SMSDataSet();
            this.gvStaffInfo = new System.Windows.Forms.DataGridView();
            this.gvsalReport = new System.Windows.Forms.DataGridView();
            this.salaryTableAdapter = new SmartSchool.DataSets.SMSDataSetTableAdapters.salaryTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsalReport)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBonus
            // 
            this.comboBonus.FormattingEnabled = true;
            this.comboBonus.Location = new System.Drawing.Point(699, 80);
            this.comboBonus.Name = "comboBonus";
            this.comboBonus.Size = new System.Drawing.Size(121, 21);
            this.comboBonus.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Generate Report By Bonus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Generate Report For Specific Staff ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate Report By Month";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(699, 53);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(121, 21);
            this.comboMonth.TabIndex = 13;
            // 
            // comboID
            // 
            this.comboID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salaryBindingSource, "salid", true));
            this.comboID.DataSource = this.salaryBindingSource;
            this.comboID.DisplayMember = "salid";
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(699, 23);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(121, 21);
            this.comboID.TabIndex = 12;
            this.comboID.ValueMember = "salid";
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "salary";
            this.salaryBindingSource.DataSource = this.sMSDataSet;
            // 
            // sMSDataSet
            // 
            this.sMSDataSet.DataSetName = "SMSDataSet";
            this.sMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvStaffInfo
            // 
            this.gvStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStaffInfo.Location = new System.Drawing.Point(33, 292);
            this.gvStaffInfo.Name = "gvStaffInfo";
            this.gvStaffInfo.Size = new System.Drawing.Size(747, 150);
            this.gvStaffInfo.TabIndex = 19;
            // 
            // gvsalReport
            // 
            this.gvsalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsalReport.Location = new System.Drawing.Point(33, 127);
            this.gvsalReport.Name = "gvsalReport";
            this.gvsalReport.Size = new System.Drawing.Size(884, 134);
            this.gvsalReport.TabIndex = 18;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "For Staff Info";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(797, 267);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 23);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "All Salary Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmSalaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gvStaffInfo);
            this.Controls.Add(this.gvsalReport);
            this.Controls.Add(this.comboBonus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalaryReport";
            this.ShowIcon = false;
            this.Text = "Salary Reports";
            this.Load += new System.EventHandler(this.frmSalaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaffInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsalReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBonus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.DataGridView gvStaffInfo;
        private System.Windows.Forms.DataGridView gvsalReport;
        private SMSDataSet sMSDataSet;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private DataSets.SMSDataSetTableAdapters.salaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReport;
    }
}