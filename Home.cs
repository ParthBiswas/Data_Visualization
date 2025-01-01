using System;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Windows.Forms;

namespace WOW_DATA_LOG
{
    public partial class Home : Form
    {
        OdbcConnection con = new OdbcConnection("Dsn=WOW");
        OdbcCommand mcd;
        private Timer timer; // Timer instance

        public Home()
        {
            InitializeComponent();
            InitializeTimer(); // Initialize timer
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Set interval to 60 seconds
            timer.Tick += Timer_Tick; // Attach Tick event
            timer.Start(); // Start the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("Timer Tick Triggered");

            try
            {
                // Check PLC statuses
                bool plc1On = IsPlc1On();
                bool plc2On = IsPlc2On();

                // Log specific data based on which PLC is ON
                if (plc1On)
                {
                    LogDataForPlc1();
                }
                else
                {
                    LogDefaultDataForPlc1();
                }

                if (plc2On)
                {
                    LogDataForPlc2();
                }
                else
                {
                    LogDefaultDataForPlc2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Timer_Tick: {ex.Message}");
            }
        }

        private bool IsPlc1On()
        {
            try
            {
                string[] plc1Status = opcDaCom1.Read("plc.s7-200.RUN_IND_R1", 1);
                return plc1Status.Length > 0 && (plc1Status[0].Trim().ToLower() == "1" || plc1Status[0].Trim().ToLower() == "true");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error reading PLC1 status: " + ex.Message);
                return false;
            }
        }

        private bool IsPlc2On()
        {
            try
            {
                string[] plc2Status = opcDaCom1.Read("plc.S7_200.RUN_IND_R2", 1);
                return plc2Status.Length > 0 && (plc2Status[0].Trim().ToLower() == "1" || plc2Status[0].Trim().ToLower() == "true");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error reading PLC2 status: " + ex.Message);
                return false;
            }
        }

        private void LogDataForPlc1()
        {
            try
            {
                //// Read data specific to PLC1
                //string[] tempR1 = opcDaCom1.Read("plc.s7-200.TEMP_R1", 1);
                //string[] R1_P1 = opcDaCom1.Read("plc.s7-200.1ST_TANK_PRESSURE_R1", 1);
                //string[] R1_P2 = opcDaCom1.Read("plc.s7-200.2ND_TANK_PRESSURE_R1", 1);

                //// Prepare SQL insert command
                //mcd = con.CreateCommand();
                //mcd.CommandText = "INSERT INTO Rector1 (TEMP_R1, TANK1_PRESSURE_R1, TANK2_PRESSURE_R1) VALUES (?, ?, ?)";
                //mcd.Parameters.AddWithValue("@TEMP_R1", tempR1[0]);
                //mcd.Parameters.AddWithValue("@TANK1_PRESSURE_R1", R1_P1[0]);
                //mcd.Parameters.AddWithValue("@TANK2_PRESSURE_R1", R1_P2[0]);

                string[] tempR1 = opcDaCom1.Read("Simulation Examples.Functions.Ramp1", 1);
                string[] R1_P1 = opcDaCom1.Read("Simulation Examples.Functions.Ramp3", 1);
                string[] R1_P2 = opcDaCom1.Read("Simulation Examples.Functions.Random2", 1);

                // Prepare SQL insert command
                mcd = con.CreateCommand();
                mcd.CommandText = "INSERT INTO Rector1 (TEMP_R1, TANK1_PRESSURE_R1, TANK2_PRESSURE_R1) VALUES (?, ?, ?)";
                mcd.Parameters.AddWithValue("@TEMP_R1", tempR1[0]);
                mcd.Parameters.AddWithValue("@TANK1_PRESSURE_R1", R1_P1[0]);
                mcd.Parameters.AddWithValue("@TANK2_PRESSURE_R1", R1_P2[0]);

                //Execute SQL command
                opencon();
                mcd.ExecuteNonQuery();
                closecon();

                temp_1.Text = tempR1[0];

                Debug.WriteLine("Data logged to Reactor1 successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging data for PLC1: {ex.Message}");
            }
        }

        private void LogDataForPlc2()
        {
            try
            {
                ////Read data specific to PLC2
                //string[] tempR2 = opcDaCom1.Read("plc.S7_200.R2_TEMP_F", 1);
                //string[] R2_p1 = opcDaCom1.Read("plc.S7_200.1ST_TANK_PRESSURE_R2", 1);
                //string[] R2_p2 = opcDaCom1.Read("plc.S7_200.2ND_TANK_PRESSURE_R2", 1);

                //// Prepare SQL insert command
                //mcd = con.CreateCommand();
                //mcd.CommandText = "INSERT INTO Rector2 (TEMP_R2, TANK1_PRESSURE_R2, TANK2_PRESSURE_R2) VALUES (?, ?, ?)";
                //mcd.Parameters.AddWithValue("@TEMP_R2", tempR2[0]);
                //mcd.Parameters.AddWithValue("@TANK1_PRESSURE_R2", R2_p1[0]);
                //mcd.Parameters.AddWithValue("@TANK2_PRESSURE_R2", R2_p2[0]);

                string[] tempR2 = opcDaCom1.Read("Simulation Examples.Functions.Ramp1", 1);
                string[] R2_p1 = opcDaCom1.Read("Simulation Examples.Functions.Ramp3", 1);
                string[] R2_p2 = opcDaCom1.Read("Simulation Examples.Functions.Random2", 1);

                // Prepare SQL insert command
                mcd = con.CreateCommand();
                mcd.CommandText = "INSERT INTO Rector2 (TEMP_R2, TANK1_PRESSURE_R2, TANK2_PRESSURE_R2) VALUES (?, ?, ?)";
                mcd.Parameters.AddWithValue("@TEMP_R2", tempR2[0]);
                mcd.Parameters.AddWithValue("@TANK1_PRESSURE_R2", R2_p1[0]);
                mcd.Parameters.AddWithValue("@TANK2_PRESSURE_R2", R2_p2[0]);

                 //Execute SQL command
                opencon();
                mcd.ExecuteNonQuery();
                closecon();

                temp_2.Text = tempR2[0];

                Debug.WriteLine("Data logged to Reactor2 successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging data for PLC2: {ex.Message}");
            }
        }

        private void LogDefaultDataForPlc1()
        {
            try
            {
                Debug.WriteLine("Logging default data for Reactor1 (PLC1 is OFF).");

                // Prepare SQL insert command for default values
                mcd = con.CreateCommand();
                mcd.CommandText = "INSERT INTO Rector1 (TEMP_R1, TANK1_PRESSURE_R1, TANK2_PRESSURE_R1) VALUES (?, ?, ?)";
                mcd.Parameters.AddWithValue("@TEMP_R1", 0);
                mcd.Parameters.AddWithValue("@TANK1_PRESSURE_R1", 0);
                mcd.Parameters.AddWithValue("@TANK2_PRESSURE_R1", 0);

                // Execute SQL command
                opencon();
                mcd.ExecuteNonQuery();
                closecon();

                Debug.WriteLine("Default data logged to Reactor1 successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging default data for PLC1: {ex.Message}");
            }
        }

        private void LogDefaultDataForPlc2()
        {
            try
            {
                Debug.WriteLine("Logging default data for Reactor2 (PLC2 is OFF).");

                // Prepare SQL insert command for default values
                mcd = con.CreateCommand();
                mcd.CommandText = "INSERT INTO Rector2 (TEMP_R2, TANK1_PRESSURE_R2, TANK2_PRESSURE_R2) VALUES (?, ?, ?)";
                mcd.Parameters.AddWithValue("@TEMP_R2", 0);
                mcd.Parameters.AddWithValue("@TANK1_PRESSURE_R2", 0);
                mcd.Parameters.AddWithValue("@TANK2_PRESSURE_R2", 0);

                // Execute SQL command
                opencon();
                mcd.ExecuteNonQuery();
                closecon();

                Debug.WriteLine("Default data logged to Reactor2 successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging default data for PLC2: {ex.Message}");
            }
        }

        private void opencon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closecon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form h = new Trend_R1();
            h.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form h = new Trend_R2();
            h.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionally, load data on form load
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void gauge4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
