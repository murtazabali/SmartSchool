namespace SmartSchool
{
    partial class frmFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFees));
            this.dtpaid = new System.Windows.Forms.DateTimePicker();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfeeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtdue = new System.Windows.Forms.DateTimePicker();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.nmscholarship = new System.Windows.Forms.NumericUpDown();
            this.nmbalance = new System.Windows.Forms.NumericUpDown();
            this.nmtotal = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelStudentDetails = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblBform = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nmpaidfees = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nmFeeAmount = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmscholarship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtotal)).BeginInit();
            this.panelStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpaidfees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFeeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpaid
            // 
            this.dtpaid.Location = new System.Drawing.Point(554, 269);
            this.dtpaid.Margin = new System.Windows.Forms.Padding(5);
            this.dtpaid.Name = "dtpaid";
            this.dtpaid.Size = new System.Drawing.Size(184, 20);
            this.dtpaid.TabIndex = 5;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(554, 181);
            this.txtstudentid.Margin = new System.Windows.Forms.Padding(5);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(74, 20);
            this.txtstudentid.TabIndex = 2;
            this.txtstudentid.TextChanged += new System.EventHandler(this.txtstudentid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Scholarship";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Paid Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Student ID";
            // 
            // txtfeeid
            // 
            this.txtfeeid.Enabled = false;
            this.txtfeeid.Location = new System.Drawing.Point(553, 151);
            this.txtfeeid.Margin = new System.Windows.Forms.Padding(5);
            this.txtfeeid.Name = "txtfeeid";
            this.txtfeeid.Size = new System.Drawing.Size(75, 20);
            this.txtfeeid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fee ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Paid Fees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Total Fees";
            // 
            // dtdue
            // 
            this.dtdue.Location = new System.Drawing.Point(553, 239);
            this.dtdue.Margin = new System.Windows.Forms.Padding(5);
            this.dtdue.Name = "dtdue";
            this.dtdue.Size = new System.Drawing.Size(185, 20);
            this.dtdue.TabIndex = 4;
            // 
            // cbmonth
            // 
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(554, 209);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(120, 21);
            this.cbmonth.TabIndex = 3;
            // 
            // nmscholarship
            // 
            this.nmscholarship.Location = new System.Drawing.Point(553, 332);
            this.nmscholarship.Name = "nmscholarship";
            this.nmscholarship.Size = new System.Drawing.Size(120, 20);
            this.nmscholarship.TabIndex = 6;
            this.nmscholarship.ValueChanged += new System.EventHandler(this.nmscholarship_ValueChanged);
            // 
            // nmbalance
            // 
            this.nmbalance.Location = new System.Drawing.Point(553, 439);
            this.nmbalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmbalance.Name = "nmbalance";
            this.nmbalance.Size = new System.Drawing.Size(120, 20);
            this.nmbalance.TabIndex = 7;
            // 
            // nmtotal
            // 
            this.nmtotal.Location = new System.Drawing.Point(554, 369);
            this.nmtotal.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmtotal.Name = "nmtotal";
            this.nmtotal.Size = new System.Drawing.Size(120, 20);
            this.nmtotal.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 33);
            this.label10.TabIndex = 56;
            this.label10.Text = "Fees";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 534);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelStudentDetails
            // 
            this.panelStudentDetails.Controls.Add(this.pictureBox2);
            this.panelStudentDetails.Controls.Add(this.lblSection);
            this.panelStudentDetails.Controls.Add(this.lblClass);
            this.panelStudentDetails.Controls.Add(this.lblBform);
            this.panelStudentDetails.Controls.Add(this.lblGender);
            this.panelStudentDetails.Controls.Add(this.lblLastName);
            this.panelStudentDetails.Controls.Add(this.lblFirstname);
            this.panelStudentDetails.Controls.Add(this.label16);
            this.panelStudentDetails.Controls.Add(this.label15);
            this.panelStudentDetails.Controls.Add(this.label14);
            this.panelStudentDetails.Controls.Add(this.label13);
            this.panelStudentDetails.Controls.Add(this.label11);
            this.panelStudentDetails.Controls.Add(this.label12);
            this.panelStudentDetails.Controls.Add(this.label9);
            this.panelStudentDetails.Location = new System.Drawing.Point(803, 269);
            this.panelStudentDetails.Name = "panelStudentDetails";
            this.panelStudentDetails.Size = new System.Drawing.Size(362, 201);
            this.panelStudentDetails.TabIndex = 58;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(84, 166);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(0, 13);
            this.lblSection.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(84, 142);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 13);
            this.lblClass.TabIndex = 1;
            // 
            // lblBform
            // 
            this.lblBform.AutoSize = true;
            this.lblBform.Location = new System.Drawing.Point(84, 118);
            this.lblBform.Name = "lblBform";
            this.lblBform.Size = new System.Drawing.Size(0, 13);
            this.lblBform.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(84, 94);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 13);
            this.lblGender.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(84, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 13);
            this.lblLastName.TabIndex = 1;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(84, 46);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(0, 13);
            this.lblFirstname.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Section:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Class:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "BForm#:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Last Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Student Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(376, 439);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "Balance";
            // 
            // nmpaidfees
            // 
            this.nmpaidfees.Location = new System.Drawing.Point(553, 404);
            this.nmpaidfees.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmpaidfees.Name = "nmpaidfees";
            this.nmpaidfees.Size = new System.Drawing.Size(120, 20);
            this.nmpaidfees.TabIndex = 7;
            this.nmpaidfees.ValueChanged += new System.EventHandler(this.nmpaidfees_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(376, 303);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 20);
            this.label18.TabIndex = 43;
            this.label18.Text = "Fee Amount";
            // 
            // nmFeeAmount
            // 
            this.nmFeeAmount.Location = new System.Drawing.Point(553, 300);
            this.nmFeeAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmFeeAmount.Name = "nmFeeAmount";
            this.nmFeeAmount.Size = new System.Drawing.Size(120, 20);
            this.nmFeeAmount.TabIndex = 6;
            this.nmFeeAmount.ValueChanged += new System.EventHandler(this.nmFeeAmount_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(820, 148);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(204, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelStudentDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmtotal);
            this.Controls.Add(this.nmpaidfees);
            this.Controls.Add(this.nmbalance);
            this.Controls.Add(this.nmFeeAmount);
            this.Controls.Add(this.nmscholarship);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.dtdue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpaid);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfeeid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFees";
            this.ShowIcon = false;
            this.Text = "Add Fees";
            this.Load += new System.EventHandler(this.frmFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmscholarship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtotal)).EndInit();
            this.panelStudentDetails.ResumeLayout(false);
            this.panelStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpaidfees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFeeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpaid;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfeeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtdue;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.NumericUpDown nmscholarship;
        private System.Windows.Forms.NumericUpDown nmbalance;
        private System.Windows.Forms.NumericUpDown nmtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelStudentDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblBform;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nmpaidfees;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nmFeeAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}