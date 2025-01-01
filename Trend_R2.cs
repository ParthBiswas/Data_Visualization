using System;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WOW_DATA_LOG
{
    public partial class Trend_R2 : Form
    {
        private Timer dataTimer;
        private string connectionString = "DSN=WOW";
        private Label cursorDataLabel;
        private ToolTip toolTip;
        private DateTimePicker datePicker;
        private int zeroTemperatureCount = 0;
        private DateTime lastValidTime;
        private double lastValidTemperature;
        private const int MaxZeroTemperatureCount = 480; // 6 * 5 minutes = 30 minutes
        private bool isReloading = false;

        public Trend_R2()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTimer();
            InitializeCursorLabel();
            toolTip = new ToolTip();

            chartr2.MouseClick += Chartr2_MouseClick;

            // Initialize DateTimePicker control
            datePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(20, 50),
                Size = new Size(120, 30)
            };
            Controls.Add(datePicker);
        }

        private void InitializeChart()
        {
            DateTime now = DateTime.Now;
            ChartArea chartArea = new ChartArea
            {
                Name = "TemperatureChartArea",
                AxisY =
                {
                    Maximum = 400,
                    Minimum = 0,
                    Interval = 40,
                    Title = "Temperature (°C)"
                },
                AxisX =
                {
                    Minimum = now.ToOADate(), // Start from the current time
                    Maximum = now.AddHours(20).ToOADate(), // Set maximum 20 hours from now
                    IntervalType = DateTimeIntervalType.Hours,
                    Interval = 1,
                    LabelStyle = { Format = "HH:mm:ss" },
                    Title = "Time"
                },
                AxisX2 =
                {
                    Enabled = AxisEnabled.True,
                    Title = "Fixed Points Time",
                    LabelStyle = { Format = "HH:mm", Enabled = false },
                    IntervalType = DateTimeIntervalType.Hours,
                    Interval = 1,
                    Minimum = DateTime.Today.ToOADate(),
                    Maximum = DateTime.Today.AddHours(24).ToOADate(),
                    LineWidth = 0, // Hide the axis line
                    MajorGrid = { LineWidth = 0 }, // Hide grid lines
                    MajorTickMark = { LineWidth = 0 }
                }
            };

            chartr2.ChartAreas.Clear();
            chartr2.ChartAreas.Add(chartArea);

            // Temperature series
            Series temperatureSeries = new Series
            {
                Name = "Temperature",
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double
            };

            chartr2.Series.Clear();
            chartr2.Series.Add(temperatureSeries);

            // Fixed line series
            Series fixedLineSeries = new Series
            {
                Name = "Target Line",
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2,
                IsVisibleInLegend = true,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = Color.Red,
                XAxisType = AxisType.Secondary // Bind to secondary X-axis
            };

            AddFixedPoint(fixedLineSeries, DateTime.Today.AddHours(0).AddMinutes(0), 30);
            AddFixedPoint(fixedLineSeries, DateTime.Today.AddHours(3).AddMinutes(50), 180);
            AddFixedPoint(fixedLineSeries, DateTime.Today.AddHours(5).AddMinutes(50), 250);
            AddFixedPoint(fixedLineSeries, DateTime.Today.AddHours(6).AddMinutes(50), 290);
            AddFixedPoint(fixedLineSeries, DateTime.Today.AddHours(9).AddMinutes(50), 380);
            AddFixedPoint(fixedLineSeries, DateTime.Today.AddHours(19).AddMinutes(25), 70);

            chartr2.Series.Add(fixedLineSeries);

            // Cursor settings
            chartr2.Cursor = Cursors.Cross;
            chartr2.MouseMove += Chartr2_MouseMove;
        }

        private void AddFixedPoint(Series series, DateTime time, double temperature)
        {
            int pointIndex = series.Points.AddXY(time.ToOADate(), temperature);
            series.Points[pointIndex].Label = $"{temperature:F1}°C";
            series.Points[pointIndex].LabelForeColor = Color.Transparent;
        }

        private void Chartr2_MouseClick(object sender, MouseEventArgs e)
        {
            var hitTestResult = chartr2.HitTest(e.X, e.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint && hitTestResult.Series != null)
            {
                var series = hitTestResult.Series;

                if (series.Name == "Temperature" || series.Name == "Target Line")
                {
                    bool allLabelsVisible = true;
                    foreach (var point in series.Points)
                    {
                        if (point.LabelForeColor == Color.Transparent)
                        {
                            allLabelsVisible = false;
                            break;
                        }
                    }

                    foreach (var point in series.Points)
                    {
                        if (allLabelsVisible)
                        {
                            point.LabelForeColor = Color.Transparent;
                        }
                        else
                        {
                            point.LabelForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void InitializeCursorLabel()
        {
            cursorDataLabel = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(20, 20),
                BackColor = System.Drawing.Color.White
            };

            Controls.Add(cursorDataLabel);
        }

        private void Chartr2_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestResult = chartr2.HitTest(e.X, e.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int pointIndex = hitTestResult.PointIndex;
                var series = chartr2.Series[hitTestResult.Series.Name];

                double xValue = series.Points[pointIndex].XValue;
                double yValue = series.Points[pointIndex].YValues[0];

                DateTime time = DateTime.FromOADate(xValue);
                string tooltipText = $"Date: {time:dd-MM-yyyy}, Time: {time:HH:mm:ss}, Temp: {yValue:F2}°C";

                toolTip.SetToolTip(chartr2, tooltipText);
            }
        }

        private void InitializeTimer()
        {
            dataTimer = new Timer();
            dataTimer.Interval = 2000;
            dataTimer.Tick += DataTimer_Tick;
            dataTimer.Start();
        }

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            UpdateChartData();
        }

        private void UpdateChartData()
        {
            // If already reloading, return early to prevent recursion
            if (isReloading)
            {
                return;
            }

            isReloading = true;

            chartr2.Series["Temperature"].Points.Clear();

            string query = "SELECT TEMP_R2, Cur_timestamp FROM Rector2 ORDER BY Cur_timestamp";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                bool allZero = true;

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime timestamp = Convert.ToDateTime(row["Cur_timestamp"]);
                    double temperature = Convert.ToDouble(row["TEMP_R2"]);

                    // Check if the temperature is non-zero, indicating valid data
                    if (temperature != 0)
                    {
                        allZero = false;
                        lastValidTime = timestamp;
                        lastValidTemperature = temperature;
                        zeroTemperatureCount = 0;
                    }
                    else
                    {
                        // If temperature is 0, increment the zero temperature count
                        zeroTemperatureCount++;
                    }

                    chartr2.Series["Temperature"].Points.AddXY(timestamp, temperature);
                }

                // If the last 30 minutes have all zero temperatures, reload the chart
                if (zeroTemperatureCount >= MaxZeroTemperatureCount)
                {
                    ReloadChartFromCurrentTime();
                }

                // If there was a valid temperature, reset the zero count
                if (!allZero)
                {
                    zeroTemperatureCount = 0;
                }
            }

            isReloading = false; // Reset the flag after processing
        }

        private void ReloadChartFromCurrentTime()
        {
            // Clear the existing chart data and reset the chart
            chartr2.Series["Temperature"].Points.Clear();

            // Reload the chart from the current time
            DateTime now = DateTime.Now;
            ChartArea chartArea = chartr2.ChartAreas["TemperatureChartArea"];

            chartArea.AxisX.Minimum = now.ToOADate();
            chartArea.AxisX.Maximum = now.AddHours(20).ToOADate();

            // Since UpdateChartData checks the flag, it will not call itself again
            // Instead, we simply avoid calling UpdateChartData directly in this method
            // This prevents the recursion issue.
        }

        

        private void Chart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataTimer != null)
            {
                dataTimer.Stop();
                dataTimer.Dispose();
            }

            if (toolTip != null)
            {
                toolTip.Dispose();
            }

            if (chartr2 != null)
            {
                chartr2.Annotations.Clear();
                chartr2.Series.Clear();
                chartr2.Dispose();
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form Trend_R2 = new Trend_HR2();
            Trend_R2.Show();
        }

        private void Trend_R2_Load_1(object sender, EventArgs e)
        {
            this.FormClosing += Chart_FormClosing;
        }
    }
}
