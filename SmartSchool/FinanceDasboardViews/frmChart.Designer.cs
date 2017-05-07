namespace SmartSchool
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.cBonus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.btnLoadBonus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // cSalary
            // 
            chartArea3.Name = "ChartArea1";
            this.cSalary.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cSalary.Legends.Add(legend3);
            this.cSalary.Location = new System.Drawing.Point(87, 78);
            this.cSalary.Name = "cSalary";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Salary";
            this.cSalary.Series.Add(series3);
            this.cSalary.Size = new System.Drawing.Size(300, 300);
            this.cSalary.TabIndex = 0;
            this.cSalary.Text = "SalaryChart";
            title3.Name = "Title1";
            title3.Text = "Salary Chart";
            this.cSalary.Titles.Add(title3);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(305, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(87, 52);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(212, 20);
            this.tbId.TabIndex = 2;
            // 
            // cBonus
            // 
            chartArea4.Name = "ChartArea1";
            this.cBonus.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cBonus.Legends.Add(legend4);
            this.cBonus.Location = new System.Drawing.Point(504, 78);
            this.cBonus.Name = "cBonus";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Bonus";
            this.cBonus.Series.Add(series4);
            this.cBonus.Size = new System.Drawing.Size(300, 300);
            this.cBonus.TabIndex = 3;
            this.cBonus.Text = "Bonus Chart";
            title4.Name = "Bonus Chart";
            this.cBonus.Titles.Add(title4);
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(504, 52);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(212, 20);
            this.tbBonus.TabIndex = 4;
            // 
            // btnLoadBonus
            // 
            this.btnLoadBonus.Location = new System.Drawing.Point(722, 50);
            this.btnLoadBonus.Name = "btnLoadBonus";
            this.btnLoadBonus.Size = new System.Drawing.Size(82, 23);
            this.btnLoadBonus.TabIndex = 1;
            this.btnLoadBonus.Text = "Load";
            this.btnLoadBonus.UseVisualStyleBackColor = true;
            this.btnLoadBonus.Click += new System.EventHandler(this.btnLoadBonus_Click);
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 431);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.cBonus);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnLoadBonus);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cSalary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChart";
            this.ShowIcon = false;
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.cSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cSalary;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DataVisualization.Charting.Chart cBonus;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.Button btnLoadBonus;
    }
}