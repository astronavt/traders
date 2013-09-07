namespace TradeExchangeMonitor
{
    partial class TradeChart
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkDisplay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 2D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 1D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisY2.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY2.MinorGrid.Enabled = true;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 95F;
            chartArea1.Name = "barchart";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 92F;
            chartArea1.Position.Width = 60F;
            chartArea1.Position.Y = 8F;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.Interval = 10D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 100F;
            chartArea2.InnerPlotPosition.Width = 100F;
            chartArea2.Name = "daychart";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 92F;
            chartArea2.Position.Width = 35F;
            chartArea2.Position.X = 65F;
            chartArea2.Position.Y = 8F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "barchart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Name = "barseries";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "daychart";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.CustomProperties = "PointWidth=0";
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "dayseries";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 200);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopRight;
            title1.DockedToChartArea = "barchart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.Moccasin;
            title1.IsDockedInsideChartArea = false;
            title1.Name = "captionActionSymbol";
            title1.Text = "CIAN";
            title2.Alignment = System.Drawing.ContentAlignment.TopRight;
            title2.DockedToChartArea = "daychart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.Moccasin;
            title2.IsDockedInsideChartArea = false;
            title2.Name = "captionBreakingCount";
            title2.Text = "256";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chkDisplay
            // 
            this.chkDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDisplay.AutoSize = true;
            this.chkDisplay.Checked = true;
            this.chkDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplay.Location = new System.Drawing.Point(3, 183);
            this.chkDisplay.Name = "chkDisplay";
            this.chkDisplay.Size = new System.Drawing.Size(15, 14);
            this.chkDisplay.TabIndex = 1;
            this.chkDisplay.UseVisualStyleBackColor = true;
            this.chkDisplay.CheckedChanged += new System.EventHandler(this.chkDisplay_CheckedChanged);
            // 
            // TradeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.chkDisplay);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.Color.Moccasin;
            this.Name = "TradeChart";
            this.Size = new System.Drawing.Size(300, 200);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox chkDisplay;
    }
}
