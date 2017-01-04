namespace SmartSchool
{
    partial class frmSalary
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.ckconfirm = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nmbonus = new System.Windows.Forms.NumericUpDown();
            this.nmbasic = new System.Windows.Forms.NumericUpDown();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstaffid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsalaryid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelStaffDetails = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblSubjectheader = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbasic)).BeginInit();
            this.panelStaffDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 354);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 79;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(20, 354);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(125, 35);
            this.btnCreate.TabIndex = 78;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ckconfirm
            // 
            this.ckconfirm.AutoSize = true;
            this.ckconfirm.Location = new System.Drawing.Point(20, 309);
            this.ckconfirm.Margin = new System.Windows.Forms.Padding(5);
            this.ckconfirm.Name = "ckconfirm";
            this.ckconfirm.Size = new System.Drawing.Size(229, 17);
            this.ckconfirm.TabIndex = 77;
            this.ckconfirm.Text = "Please Confirm The Details Before Creation";
            this.ckconfirm.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 33);
            this.label10.TabIndex = 76;
            this.label10.Text = "Salary";
            // 
            // nmbonus
            // 
            this.nmbonus.Location = new System.Drawing.Point(240, 232);
            this.nmbonus.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmbonus.Name = "nmbonus";
            this.nmbonus.Size = new System.Drawing.Size(120, 20);
            this.nmbonus.TabIndex = 74;
            this.nmbonus.ValueChanged += new System.EventHandler(this.nmbonus_ValueChanged);
            // 
            // nmbasic
            // 
            this.nmbasic.Location = new System.Drawing.Point(239, 191);
            this.nmbasic.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmbasic.Name = "nmbasic";
            this.nmbasic.Size = new System.Drawing.Size(120, 20);
            this.nmbasic.TabIndex = 73;
            this.nmbasic.ValueChanged += new System.EventHandler(this.nmbasic_ValueChanged);
            // 
            // cbmonth
            // 
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(240, 150);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(99, 21);
            this.cbmonth.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Bonus";
            // 
            // txtstaffid
            // 
            this.txtstaffid.Location = new System.Drawing.Point(239, 118);
            this.txtstaffid.Margin = new System.Windows.Forms.Padding(5);
            this.txtstaffid.Name = "txtstaffid";
            this.txtstaffid.Size = new System.Drawing.Size(99, 20);
            this.txtstaffid.TabIndex = 67;
            this.txtstaffid.TextChanged += new System.EventHandler(this.txtstaffid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Basic Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Staff ID";
            // 
            // txtsalaryid
            // 
            this.txtsalaryid.Enabled = false;
            this.txtsalaryid.Location = new System.Drawing.Point(240, 82);
            this.txtsalaryid.Margin = new System.Windows.Forms.Padding(5);
            this.txtsalaryid.Name = "txtsalaryid";
            this.txtsalaryid.Size = new System.Drawing.Size(99, 20);
            this.txtsalaryid.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Salary ID";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(240, 269);
            this.txttotal.Margin = new System.Windows.Forms.Padding(5);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(120, 20);
            this.txttotal.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Total Salary";
            // 
            // panelStaffDetails
            // 
            this.panelStaffDetails.Controls.Add(this.lblSubject);
            this.panelStaffDetails.Controls.Add(this.lblDesignation);
            this.panelStaffDetails.Controls.Add(this.lblCNIC);
            this.panelStaffDetails.Controls.Add(this.lblContact);
            this.panelStaffDetails.Controls.Add(this.lblGender);
            this.panelStaffDetails.Controls.Add(this.lblLastname);
            this.panelStaffDetails.Controls.Add(this.lblFirstname);
            this.panelStaffDetails.Controls.Add(this.lblSubjectheader);
            this.panelStaffDetails.Controls.Add(this.label14);
            this.panelStaffDetails.Controls.Add(this.label13);
            this.panelStaffDetails.Controls.Add(this.label12);
            this.panelStaffDetails.Controls.Add(this.label11);
            this.panelStaffDetails.Controls.Add(this.label9);
            this.panelStaffDetails.Controls.Add(this.label8);
            this.panelStaffDetails.Controls.Add(this.label5);
            this.panelStaffDetails.Location = new System.Drawing.Point(399, 107);
            this.panelStaffDetails.Name = "panelStaffDetails";
            this.panelStaffDetails.Size = new System.Drawing.Size(212, 205);
            this.panelStaffDetails.TabIndex = 82;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(80, 177);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(0, 13);
            this.lblSubject.TabIndex = 2;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(80, 155);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(0, 13);
            this.lblDesignation.TabIndex = 2;
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(80, 132);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(0, 13);
            this.lblCNIC.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(80, 108);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(0, 13);
            this.lblContact.TabIndex = 2;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(80, 83);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 13);
            this.lblGender.TabIndex = 2;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(80, 61);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(0, 13);
            this.lblLastname.TabIndex = 2;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(80, 38);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(0, 13);
            this.lblFirstname.TabIndex = 2;
            // 
            // lblSubjectheader
            // 
            this.lblSubjectheader.AutoSize = true;
            this.lblSubjectheader.Location = new System.Drawing.Point(4, 177);
            this.lblSubjectheader.Name = "lblSubjectheader";
            this.lblSubjectheader.Size = new System.Drawing.Size(46, 13);
            this.lblSubjectheader.TabIndex = 1;
            this.lblSubjectheader.Text = "Subject:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Designation:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "CNIC:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Contact:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Staff Details:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(402, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 83;
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelStaffDetails);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.ckconfirm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmbonus);
            this.Controls.Add(this.nmbasic);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtstaffid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsalaryid);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalary";
            this.Text = "Add Salary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbasic)).EndInit();
            this.panelStaffDetails.ResumeLayout(false);
            this.panelStaffDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox ckconfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmbonus;
        private System.Windows.Forms.NumericUpDown nmbasic;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstaffid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsalaryid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelStaffDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSubjectheader;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblStatus;
    }
}