namespace SmartSchool
{
    partial class frmStaffView
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvstaff = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchStaff = new System.Windows.Forms.ComboBox();
            this.tbSearchStaffLName = new System.Windows.Forms.TextBox();
            this.tbSearchStaffFname = new System.Windows.Forms.TextBox();
            this.btnLoadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Staff View";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(899, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(407, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvstaff
            // 
            this.gvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstaff.Location = new System.Drawing.Point(47, 145);
            this.gvstaff.Name = "gvstaff";
            this.gvstaff.Size = new System.Drawing.Size(947, 350);
            this.gvstaff.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Staff ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name:";
            // 
            // cbSearchStaff
            // 
            this.cbSearchStaff.FormattingEnabled = true;
            this.cbSearchStaff.Location = new System.Drawing.Point(347, 118);
            this.cbSearchStaff.Name = "cbSearchStaff";
            this.cbSearchStaff.Size = new System.Drawing.Size(54, 21);
            this.cbSearchStaff.TabIndex = 25;
            this.cbSearchStaff.SelectionChangeCommitted += new System.EventHandler(this.cbSearchStaff_SelectionChangeCommitted);
            // 
            // tbSearchStaffLName
            // 
            this.tbSearchStaffLName.Location = new System.Drawing.Point(197, 118);
            this.tbSearchStaffLName.Name = "tbSearchStaffLName";
            this.tbSearchStaffLName.Size = new System.Drawing.Size(144, 20);
            this.tbSearchStaffLName.TabIndex = 24;
            // 
            // tbSearchStaffFname
            // 
            this.tbSearchStaffFname.Location = new System.Drawing.Point(47, 118);
            this.tbSearchStaffFname.Name = "tbSearchStaffFname";
            this.tbSearchStaffFname.Size = new System.Drawing.Size(144, 20);
            this.tbSearchStaffFname.TabIndex = 23;
            this.tbSearchStaffFname.TextChanged += new System.EventHandler(this.tbSearchStaffFname_TextChanged);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(542, 116);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(121, 23);
            this.btnLoadAll.TabIndex = 29;
            this.btnLoadAll.Text = "Load All Record";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // frmStaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearchStaff);
            this.Controls.Add(this.tbSearchStaffLName);
            this.Controls.Add(this.tbSearchStaffFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gvstaff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaffView";
            this.ShowIcon = false;
            this.Text = "View Staffs";
            this.Load += new System.EventHandler(this.frmStaffView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvstaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvstaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchStaff;
        private System.Windows.Forms.TextBox tbSearchStaffLName;
        private System.Windows.Forms.TextBox tbSearchStaffFname;
        private System.Windows.Forms.Button btnLoadAll;
    }
}