using System;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WOW_DATA_LOG
{
    public partial class Trend_HR2 : Form
    {
        private ToolTip toolTip;
        private Label cursorDataLabel;
        private string conn = "DSN=WOW";

        public Trend_HR2()
        {
            InitializeComponent();
            InitializeChart();
            InitializeCursorLabel();
            InitializeDatePickers();
            toolTip = new ToolTip();
        }

        private void InitializeChart()
        {
            // Initialize chart area
            ChartArea chartArea = new ChartArea
            {
                Name = "Tempchart",
                AxisY =
                {
                    Maximum = 400,
                    Minimum = 0,
                    Interval = 40,
                    Title = "Temperature (°C)"
                },
                AxisX =
                {
                    Minimum = DateTime.Today.ToOADate(),
                    Maximum = DateTime.Today.AddHours(20).ToOADate(),
                    IntervalType = DateTimeIntervalType.Hours,
                    Interval = 1,
                    LabelStyle = { Format = "HH:mm:ss" },
                    Title = "Time",
                    ScaleView = { Zoomable = true },
                    ScrollBar = { Enabled = true }
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

            charthr2.ChartAreas.Clear();
            charthr2.ChartAreas.Add(chartArea);

            // Initialize Temperature series
            Series temperatureSeries = new Series
            {
                Name = "Temperature",
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double
            };

            charthr2.Series.Clear();
            charthr2.Series.Add(temperatureSeries);

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

            charthr2.Series.Add(fixedLineSeries);

            // Cursor settings
            charthr2.Cursor = Cursors.Cross;
            charthr2.MouseMove += Charthr2_MouseMove;
        }

        private void AddFixedPoint(Series series, DateTime time, double temperature)
        {
            int pointIndex = series.Points.AddXY(time.ToOADate(), temperature);
            series.Points[pointIndex].Label = $"{temperature:F1}°C";
            series.Points[pointIndex].LabelForeColor = Color.Transparent;
        }

        private void InitializeCursorLabel()
        {
            cursorDataLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                BackColor = Color.White
            };

            Controls.Add(cursorDataLabel);
        }

        private void InitializeDatePickers()
        {
            // Configure date picker
            dateTimePicker9.Format = DateTimePickerFormat.Long;
            dateTimePicker9.ValueChanged += dateTimePicker9_ValueChanged;

            // Configure time picker
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {
            LoadDataForSelectedDateTime(dateTimePicker9.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadDataForSelectedDateTime(dateTimePicker9.Value, dateTimePicker2.Value);
        }

        private void LoadDataForSelectedDateTime(DateTime selectedDate, DateTime selectedTime)
        {
            // Combine selected date and time
            DateTime startDateTime = new DateTime(
                selectedDate.Year,
                selectedDate.Month,
                selectedDate.Day,
                selectedTime.Hour,
                selectedTime.Minute,
                selectedTime.Second);

            // Set the range to the next 20 hours
            DateTime endDateTime = startDateTime.AddHours(20);

            // Update the chart's X-axis to display the 20-hour range
            charthr2.ChartAreas["Tempchart"].AxisX.Minimum = startDateTime.ToOADate();
            charthr2.ChartAreas["Tempchart"].AxisX.Maximum = endDateTime.ToOADate();

            using (OdbcConnection connection = new OdbcConnection(conn))
            {
                try
                {
                    connection.Open();

                    // Query for data within the selected range
                    string query = "SELECT Cur_timestamp, TEMP_R2 FROM Rector2 WHERE Cur_timestamp >= ? AND Cur_timestamp < ?";
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.Add(new OdbcParameter("@start", OdbcType.DateTime)).Value = startDateTime;
                        command.Parameters.Add(new OdbcParameter("@end", OdbcType.DateTime)).Value = endDateTime;

                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            // Clear only the Temperature series data
                            charthr2.Series["Temperature"].Points.Clear();

                            // Plot available data within the selected range
                            while (reader.Read())
                            {
                                DateTime timestamp = reader.GetDateTime(0); // Cur_timestamp
                                double temperature = reader.GetDouble(1);   // TEMP_R1

                                charthr2.Series["Temperature"].Points.AddXY(timestamp, temperature);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void Charthr2_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestResult = charthr2.HitTest(e.X, e.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int pointIndex = hitTestResult.PointIndex;
                var series = charthr2.Series[hitTestResult.Series.Name];

                double xValue = series.Points[pointIndex].XValue;
                double yValue = series.Points[pointIndex].YValues[0];

                DateTime time = DateTime.FromOADate(xValue);
                string tooltipText = $"Date: {time:dd-MM-yyyy}, Time: {time:HH:mm:ss}, Temp: {yValue:F2}°C";

                toolTip.SetToolTip(charthr2, tooltipText);
            }
        }

        private void Trend_HR2_Load(object sender, EventArgs e)
        {
            // Load data for today and current time on form load
            //LoadDataForSelectedDateTime(DateTime.Today, DateTime.Now);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp",
                Title = "Save Chart as Image"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    charthr2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                    MessageBox.Show("Chart saved successfully!", "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving chart: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form dataLogForm = new Data_Log_1();
            dataLogForm.Show();
        }
    }
}
