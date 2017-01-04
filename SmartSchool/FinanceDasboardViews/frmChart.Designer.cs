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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // cSalary
            // 
            chartArea1.Name = "ChartArea1";
            this.cSalary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cSalary.Legends.Add(legend1);
            this.cSalary.Location = new System.Drawing.Point(95, 67);
            this.cSalary.Name = "cSalary";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.cSalary.Series.Add(series1);
            this.cSalary.Size = new System.Drawing.Size(300, 300);
            this.cSalary.TabIndex = 0;
            this.cSalary.Text = "SalaryChart";
            title1.Name = "Title1";
            title1.Text = "Salary Chart";
            this.cSalary.Titles.Add(title1);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(312, 384);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 431);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cSalary);
            this.Name = "frmChart";
            this.Text = "frmChart";
            ((System.ComponentModel.ISupportInitialize)(this.cSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cSalary;
        private System.Windows.Forms.Button btnLoad;
    }
}