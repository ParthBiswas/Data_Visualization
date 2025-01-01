namespace WOW_DATA_LOG
{
    partial class Home
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
            this.opcDaCom1 = new AdvancedHMIDrivers.OpcDaCom(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.temp_1 = new System.Windows.Forms.Label();
            this.gauge1 = new AdvancedHMIControls.Gauge();
            this.gauge2 = new AdvancedHMIControls.Gauge();
            this.gauge4 = new AdvancedHMIControls.Gauge();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.temp_2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimeDisplay1 = new AdvancedHMIControls.DateTimeDisplay();
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.gauge3 = new AdvancedHMIControls.Gauge();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-209, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1555, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "WORTH OF WASTE PVT. LTD.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "RECTOR 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(972, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "RECTOR 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "1st Tank Pressure";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "2nd Tank Pressure";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 44);
            this.label6.TabIndex = 6;
            this.label6.Text = "1st Tank Pressure";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1152, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 42);
            this.label7.TabIndex = 7;
            this.label7.Text = "2nd Tank Pressure";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_1
            // 
            this.temp_1.BackColor = System.Drawing.Color.Black;
            this.temp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_1.ForeColor = System.Drawing.Color.Red;
            this.temp_1.Location = new System.Drawing.Point(235, 465);
            this.temp_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temp_1.Name = "temp_1";
            this.temp_1.Size = new System.Drawing.Size(176, 98);
            this.temp_1.TabIndex = 8;
            this.temp_1.Text = "Temp";
            this.temp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gauge1
            // 
            this.gauge1.AllowDragging = false;
            this.gauge1.BackColor = System.Drawing.Color.Transparent;
            this.gauge1.ComComponent = this.opcDaCom1;
            this.gauge1.HighlightColor = System.Drawing.Color.Red;
            this.gauge1.Location = new System.Drawing.Point(11, 194);
            this.gauge1.Margin = new System.Windows.Forms.Padding(2);
            this.gauge1.Maximum = 1000;
            this.gauge1.Minimum = 0;
            this.gauge1.Name = "gauge1";
            this.gauge1.NumericFormat = null;
            this.gauge1.PLCAddressText = "";
            this.gauge1.PLCAddressValue = "Simulation Examples.Functions.Ramp3";
            this.gauge1.PLCAddressVisible = "";
            this.gauge1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gauge1.Size = new System.Drawing.Size(253, 253);
            this.gauge1.SuppressErrorDisplay = true;
            this.gauge1.TabIndex = 9;
            this.gauge1.Text = "gauge1";
            this.gauge1.Value = 0D;
            this.gauge1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gauge2
            // 
            this.gauge2.AllowDragging = false;
            this.gauge2.BackColor = System.Drawing.Color.Transparent;
            this.gauge2.ComComponent = this.opcDaCom1;
            this.gauge2.HighlightColor = System.Drawing.Color.Red;
            this.gauge2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gauge2.Location = new System.Drawing.Point(393, 189);
            this.gauge2.Margin = new System.Windows.Forms.Padding(2);
            this.gauge2.Maximum = 500;
            this.gauge2.Minimum = 0;
            this.gauge2.Name = "gauge2";
            this.gauge2.NumericFormat = null;
            this.gauge2.PLCAddressText = "";
            this.gauge2.PLCAddressValue = "Simulation Examples.Functions.Ramp1";
            this.gauge2.PLCAddressVisible = "";
            this.gauge2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gauge2.Size = new System.Drawing.Size(258, 258);
            this.gauge2.TabIndex = 10;
            this.gauge2.Text = "gauge2";
            this.gauge2.Value = 0D;
            this.gauge2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gauge4
            // 
            this.gauge4.AllowDragging = false;
            this.gauge4.BackColor = System.Drawing.Color.Transparent;
            this.gauge4.ComComponent = this.opcDaCom1;
            this.gauge4.HighlightColor = System.Drawing.Color.Red;
            this.gauge4.Location = new System.Drawing.Point(1101, 181);
            this.gauge4.Margin = new System.Windows.Forms.Padding(2);
            this.gauge4.Maximum = 500;
            this.gauge4.Minimum = 0;
            this.gauge4.Name = "gauge4";
            this.gauge4.NumericFormat = null;
            this.gauge4.PLCAddressText = "";
            this.gauge4.PLCAddressValue = "Simulation Examples.Functions.Ramp1";
            this.gauge4.PLCAddressVisible = "";
            this.gauge4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gauge4.Size = new System.Drawing.Size(267, 267);
            this.gauge4.SuppressErrorDisplay = true;
            this.gauge4.TabIndex = 12;
            this.gauge4.Text = "gauge4";
            this.gauge4.Value = 0D;
            this.gauge4.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gauge4.Click += new System.EventHandler(this.gauge4_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "MLI(BAR)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(990, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "MLI(BAR)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_2
            // 
            this.temp_2.BackColor = System.Drawing.Color.Black;
            this.temp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_2.ForeColor = System.Drawing.Color.Red;
            this.temp_2.Location = new System.Drawing.Point(972, 465);
            this.temp_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temp_2.Name = "temp_2";
            this.temp_2.Size = new System.Drawing.Size(182, 98);
            this.temp_2.TabIndex = 15;
            this.temp_2.Text = "Temp";
            this.temp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(415, 477);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 49);
            this.label11.TabIndex = 20;
            this.label11.Text = "°C";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1158, 473);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 53);
            this.label12.TabIndex = 21;
            this.label12.Text = "°C";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(2, 565);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1344, 224);
            this.textBox1.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1003, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 78);
            this.button4.TabIndex = 23;
            this.button4.Text = "R1 Chart";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1179, -1);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 79);
            this.button5.TabIndex = 24;
            this.button5.Text = "R2 Chart";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimeDisplay1
            // 
            this.dateTimeDisplay1.BackColor = System.Drawing.Color.Black;
            this.dateTimeDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeDisplay1.DisplayFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimeDisplay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateTimeDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimeDisplay1.Location = new System.Drawing.Point(2, -1);
            this.dateTimeDisplay1.Name = "dateTimeDisplay1";
            this.dateTimeDisplay1.Size = new System.Drawing.Size(207, 80);
            this.dateTimeDisplay1.TabIndex = 47;
            this.dateTimeDisplay1.Text = "27-12-2024 01:03:45";
            this.dateTimeDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.2.5";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // gauge3
            // 
            this.gauge3.AllowDragging = false;
            this.gauge3.BackColor = System.Drawing.Color.Transparent;
            this.gauge3.ComComponent = this.opcDaCom1;
            this.gauge3.HighlightColor = System.Drawing.Color.Red;
            this.gauge3.Location = new System.Drawing.Point(733, 194);
            this.gauge3.Margin = new System.Windows.Forms.Padding(2);
            this.gauge3.Maximum = 1000;
            this.gauge3.Minimum = 0;
            this.gauge3.Name = "gauge3";
            this.gauge3.NumericFormat = null;
            this.gauge3.PLCAddressText = "";
            this.gauge3.PLCAddressValue = "Simulation Examples.Functions.Ramp3";
            this.gauge3.PLCAddressVisible = "";
            this.gauge3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gauge3.Size = new System.Drawing.Size(253, 253);
            this.gauge3.SuppressErrorDisplay = true;
            this.gauge3.TabIndex = 48;
            this.gauge3.Text = "gauge3";
            this.gauge3.Value = 0D;
            this.gauge3.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.gauge3);
            this.Controls.Add(this.dateTimeDisplay1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.temp_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gauge4);
            this.Controls.Add(this.gauge2);
            this.Controls.Add(this.gauge1);
            this.Controls.Add(this.temp_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdvancedHMIDrivers.OpcDaCom opcDaCom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label temp_1;
        private System.Windows.Forms.Label temp_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private AdvancedHMIControls.Gauge gauge4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private AdvancedHMIControls.DateTimeDisplay dateTimeDisplay1;
        private AdvancedHMIControls.Gauge gauge2;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.Gauge gauge1;
        private AdvancedHMIControls.Gauge gauge3;
    }
}

