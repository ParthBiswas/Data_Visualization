namespace WOW_DATA_LOG
{
    partial class Trend_R2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimeDisplay1 = new AdvancedHMIControls.DateTimeDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.chartr2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.opcDaCom1 = new AdvancedHMIDrivers.OpcDaCom(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartr2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeDisplay1
            // 
            this.dateTimeDisplay1.BackColor = System.Drawing.Color.Black;
            this.dateTimeDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeDisplay1.DisplayFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimeDisplay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateTimeDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimeDisplay1.Location = new System.Drawing.Point(0, 0);
            this.dateTimeDisplay1.Name = "dateTimeDisplay1";
            this.dateTimeDisplay1.Size = new System.Drawing.Size(169, 90);
            this.dateTimeDisplay1.TabIndex = 74;
            this.dateTimeDisplay1.Text = "22-11-2024 07:17:55";
            this.dateTimeDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-226, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1573, 92);
            this.label1.TabIndex = 73;
            this.label1.Text = "Rector 2 Trend  Chart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartr2
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.Interval = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.MaximumAutoSize = 50F;
            chartArea3.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 20;
            chartArea3.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            chartArea3.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.Name = "ChartArea1";
            this.chartr2.ChartAreas.Add(chartArea3);
            this.chartr2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            legend3.Name = "Legend1";
            legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chartr2.Legends.Add(legend3);
            this.chartr2.Location = new System.Drawing.Point(0, 94);
            this.chartr2.Margin = new System.Windows.Forms.Padding(2);
            this.chartr2.Name = "chartr2";
            this.chartr2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartr2.Series.Add(series3);
            this.chartr2.Size = new System.Drawing.Size(1347, 628);
            this.chartr2.SuppressExceptions = true;
            this.chartr2.TabIndex = 72;
            this.chartr2.Text = "chart1";
            this.chartr2.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title3.Name = "Title1";
            this.chartr2.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1152, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 90);
            this.button1.TabIndex = 75;
            this.button1.Text = "Historical chart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opcDaCom1
            // 
            this.opcDaCom1.DisableSubscriptions = false;
            this.opcDaCom1.OPCGroup = "";
            this.opcDaCom1.OPCServer = "Kepware.KEPServerEX.V6";
            this.opcDaCom1.OPCServerPath = "opcda://localhost";
            this.opcDaCom1.OPCTopic = null;
            this.opcDaCom1.PollRateOverride = 500;
            this.opcDaCom1.SynchronizingObject = this;
            // 
            // Trend_R2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.dateTimeDisplay1);
            this.Controls.Add(this.chartr2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Trend_R2";
            this.Text = "Trend_R2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trend_R2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartr2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedHMIControls.DateTimeDisplay dateTimeDisplay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartr2;
        private System.Windows.Forms.Button button1;
        private AdvancedHMIDrivers.OpcDaCom opcDaCom1;
    }
}