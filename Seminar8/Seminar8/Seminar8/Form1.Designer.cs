namespace Seminar8
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.companiiComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.preturiInchidereTabPage = new System.Windows.Forms.TabPage();
            this.volumTranzactionatTabPage = new System.Windows.Forms.TabPage();
            this.chartPret = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.evolutieTabPage = new System.Windows.Forms.TabPage();
            this.volumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.evolutieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.preturiInchidereTabPage.SuspendLayout();
            this.volumTranzactionatTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPret)).BeginInit();
            this.evolutieTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolutieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.companiiComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // companiiComboBox
            // 
            this.companiiComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companiiComboBox.FormattingEnabled = true;
            this.companiiComboBox.Location = new System.Drawing.Point(3, 3);
            this.companiiComboBox.Name = "companiiComboBox";
            this.companiiComboBox.Size = new System.Drawing.Size(870, 21);
            this.companiiComboBox.TabIndex = 0;
            this.companiiComboBox.SelectedIndexChanged += new System.EventHandler(this.companiiComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.preturiInchidereTabPage);
            this.tabControl1.Controls.Add(this.volumTranzactionatTabPage);
            this.tabControl1.Controls.Add(this.evolutieTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 486);
            this.tabControl1.TabIndex = 1;
            // 
            // preturiInchidereTabPage
            // 
            this.preturiInchidereTabPage.Controls.Add(this.chartPret);
            this.preturiInchidereTabPage.Location = new System.Drawing.Point(4, 22);
            this.preturiInchidereTabPage.Name = "preturiInchidereTabPage";
            this.preturiInchidereTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.preturiInchidereTabPage.Size = new System.Drawing.Size(862, 460);
            this.preturiInchidereTabPage.TabIndex = 0;
            this.preturiInchidereTabPage.Text = "Preturi inchidere";
            this.preturiInchidereTabPage.UseVisualStyleBackColor = true;
            // 
            // volumTranzactionatTabPage
            // 
            this.volumTranzactionatTabPage.Controls.Add(this.volumChart);
            this.volumTranzactionatTabPage.Location = new System.Drawing.Point(4, 22);
            this.volumTranzactionatTabPage.Name = "volumTranzactionatTabPage";
            this.volumTranzactionatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.volumTranzactionatTabPage.Size = new System.Drawing.Size(862, 460);
            this.volumTranzactionatTabPage.TabIndex = 1;
            this.volumTranzactionatTabPage.Text = "Volum tranzactionat";
            this.volumTranzactionatTabPage.UseVisualStyleBackColor = true;
            // 
            // chartPret
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPret.ChartAreas.Add(chartArea1);
            this.chartPret.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartPret.Legends.Add(legend1);
            this.chartPret.Location = new System.Drawing.Point(3, 3);
            this.chartPret.Name = "chartPret";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPret.Series.Add(series1);
            this.chartPret.Size = new System.Drawing.Size(856, 454);
            this.chartPret.TabIndex = 0;
            this.chartPret.Text = "chartPret";
            // 
            // evolutieTabPage
            // 
            this.evolutieTabPage.Controls.Add(this.evolutieChart);
            this.evolutieTabPage.Location = new System.Drawing.Point(4, 22);
            this.evolutieTabPage.Name = "evolutieTabPage";
            this.evolutieTabPage.Size = new System.Drawing.Size(862, 460);
            this.evolutieTabPage.TabIndex = 2;
            this.evolutieTabPage.Text = "Evolutie";
            this.evolutieTabPage.UseVisualStyleBackColor = true;
            // 
            // volumChart
            // 
            chartArea2.Name = "ChartArea1";
            this.volumChart.ChartAreas.Add(chartArea2);
            this.volumChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.volumChart.Legends.Add(legend2);
            this.volumChart.Location = new System.Drawing.Point(3, 3);
            this.volumChart.Name = "volumChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.volumChart.Series.Add(series2);
            this.volumChart.Size = new System.Drawing.Size(856, 454);
            this.volumChart.TabIndex = 0;
            this.volumChart.Text = "chart1";
            // 
            // evolutieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.evolutieChart.ChartAreas.Add(chartArea3);
            this.evolutieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.evolutieChart.Legends.Add(legend3);
            this.evolutieChart.Location = new System.Drawing.Point(0, 0);
            this.evolutieChart.Name = "evolutieChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.evolutieChart.Series.Add(series3);
            this.evolutieChart.Size = new System.Drawing.Size(862, 460);
            this.evolutieChart.TabIndex = 2;
            this.evolutieChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.preturiInchidereTabPage.ResumeLayout(false);
            this.volumTranzactionatTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPret)).EndInit();
            this.evolutieTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolutieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox companiiComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage preturiInchidereTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPret;
        private System.Windows.Forms.TabPage volumTranzactionatTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart volumChart;
        private System.Windows.Forms.TabPage evolutieTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart evolutieChart;
    }
}

