namespace SmartSchool
{
    partial class frmSubjectView
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
            this.gvsubject = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchCode = new System.Windows.Forms.ComboBox();
            this.tbSearchSubject = new System.Windows.Forms.TextBox();
            this.btnLoadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvsubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Subject View";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvsubject
            // 
            this.gvsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsubject.Location = new System.Drawing.Point(37, 106);
            this.gvsubject.Name = "gvsubject";
            this.gvsubject.Size = new System.Drawing.Size(345, 350);
            this.gvsubject.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Subject Name:";
            // 
            // cbSearchCode
            // 
            this.cbSearchCode.FormattingEnabled = true;
            this.cbSearchCode.Location = new System.Drawing.Point(186, 79);
            this.cbSearchCode.Name = "cbSearchCode";
            this.cbSearchCode.Size = new System.Drawing.Size(54, 21);
            this.cbSearchCode.TabIndex = 21;
            this.cbSearchCode.SelectionChangeCommitted += new System.EventHandler(this.cbSearchCode_SelectionChangeCommitted);
            // 
            // tbSearchSubject
            // 
            this.tbSearchSubject.Location = new System.Drawing.Point(36, 79);
            this.tbSearchSubject.Name = "tbSearchSubject";
            this.tbSearchSubject.Size = new System.Drawing.Size(144, 20);
            this.tbSearchSubject.TabIndex = 20;
            this.tbSearchSubject.TextChanged += new System.EventHandler(this.tbSearchSubject_TextChanged);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(37, 462);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(121, 23);
            this.btnLoadAll.TabIndex = 24;
            this.btnLoadAll.Text = "Load All Record";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // frmSubjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 637);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearchCode);
            this.Controls.Add(this.tbSearchSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gvsubject);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubjectView";
            this.ShowIcon = false;
            this.Text = "View Subjects";
            this.Load += new System.EventHandler(this.frmSubjectView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvsubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvsubject;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchCode;
        private System.Windows.Forms.TextBox tbSearchSubject;
        private System.Windows.Forms.Button btnLoadAll;
    }
}