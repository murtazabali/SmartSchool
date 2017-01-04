namespace SmartSchool
{
    partial class frmStudentView
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
            this.gvstudent = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchStudent = new System.Windows.Forms.ComboBox();
            this.tbSearchStudentLName = new System.Windows.Forms.TextBox();
            this.tbSearchStudentFname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gvstudent
            // 
            this.gvstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvstudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstudent.Location = new System.Drawing.Point(33, 133);
            this.gvstudent.Name = "gvstudent";
            this.gvstudent.Size = new System.Drawing.Size(947, 350);
            this.gvstudent.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(885, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student View";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Std ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name:";
            // 
            // cbSearchStudent
            // 
            this.cbSearchStudent.FormattingEnabled = true;
            this.cbSearchStudent.Location = new System.Drawing.Point(333, 107);
            this.cbSearchStudent.Name = "cbSearchStudent";
            this.cbSearchStudent.Size = new System.Drawing.Size(54, 21);
            this.cbSearchStudent.TabIndex = 32;
            this.cbSearchStudent.SelectionChangeCommitted += new System.EventHandler(this.cbSearchStudent_SelectionChangeCommitted);
            // 
            // tbSearchStudentLName
            // 
            this.tbSearchStudentLName.Location = new System.Drawing.Point(183, 107);
            this.tbSearchStudentLName.Name = "tbSearchStudentLName";
            this.tbSearchStudentLName.Size = new System.Drawing.Size(144, 20);
            this.tbSearchStudentLName.TabIndex = 31;
            // 
            // tbSearchStudentFname
            // 
            this.tbSearchStudentFname.Location = new System.Drawing.Point(33, 107);
            this.tbSearchStudentFname.Name = "tbSearchStudentFname";
            this.tbSearchStudentFname.Size = new System.Drawing.Size(144, 20);
            this.tbSearchStudentFname.TabIndex = 30;
            this.tbSearchStudentFname.TextChanged += new System.EventHandler(this.tbSearchStudentFname_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(528, 105);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(121, 23);
            this.btnLoadAll.TabIndex = 36;
            this.btnLoadAll.Text = "Load All Record";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // frmStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearchStudent);
            this.Controls.Add(this.tbSearchStudentLName);
            this.Controls.Add(this.tbSearchStudentFname);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gvstudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentView";
            this.ShowIcon = false;
            this.Text = "View Students";
            this.Load += new System.EventHandler(this.frmStudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvstudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchStudent;
        private System.Windows.Forms.TextBox tbSearchStudentLName;
        private System.Windows.Forms.TextBox tbSearchStudentFname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoadAll;
    }
}

