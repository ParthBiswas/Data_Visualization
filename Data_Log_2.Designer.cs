namespace WOW_DATA_LOG
{
    partial class Data_Log_2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rector2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wOWDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wOWDataSet4 = new WOW_DATA_LOG.WOWDataSet4();
            this.dateTimeDisplay1 = new AdvancedHMIControls.DateTimeDisplay();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rector2TableAdapter = new WOW_DATA_LOG.WOWDataSet4TableAdapters.Rector2TableAdapter();
            this.endDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPR2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANK1PRESSURER2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANK2PRESSURER2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curtimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rector2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tEMPR2DataGridViewTextBoxColumn,
            this.tANK1PRESSURER2DataGridViewTextBoxColumn,
            this.tANK2PRESSURER2DataGridViewTextBoxColumn,
            this.curtimestampDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rector2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 631);
            this.dataGridView1.TabIndex = 55;
            // 
            // rector2BindingSource
            // 
            this.rector2BindingSource.DataMember = "Rector2";
            this.rector2BindingSource.DataSource = this.wOWDataSet4BindingSource;
            // 
            // wOWDataSet4BindingSource
            // 
            this.wOWDataSet4BindingSource.DataSource = this.wOWDataSet4;
            this.wOWDataSet4BindingSource.Position = 0;
            // 
            // wOWDataSet4
            // 
            this.wOWDataSet4.DataSetName = "WOWDataSet4";
            this.wOWDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimeDisplay1
            // 
            this.dateTimeDisplay1.BackColor = System.Drawing.Color.Black;
            this.dateTimeDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeDisplay1.DisplayFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimeDisplay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateTimeDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimeDisplay1.Location = new System.Drawing.Point(0, 1);
            this.dateTimeDisplay1.Name = "dateTimeDisplay1";
            this.dateTimeDisplay1.Size = new System.Drawing.Size(161, 90);
            this.dateTimeDisplay1.TabIndex = 58;
            this.dateTimeDisplay1.Text = "21-11-2024 05:18:29";
            this.dateTimeDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1083, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 92);
            this.button3.TabIndex = 57;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1211, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 92);
            this.button2.TabIndex = 56;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-502, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1921, 91);
            this.label1.TabIndex = 54;
            this.label1.Text = "Data Log Rector 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rector2TableAdapter
            // 
            this.rector2TableAdapter.ClearBeforeFill = true;
            // 
            // endDateTimePicker1
            // 
            this.endDateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker1.Location = new System.Drawing.Point(762, 45);
            this.endDateTimePicker1.Name = "endDateTimePicker1";
            this.endDateTimePicker1.Size = new System.Drawing.Size(163, 26);
            this.endDateTimePicker1.TabIndex = 61;
            // 
            // startDateTimePicker1
            // 
            this.startDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker1.Location = new System.Drawing.Point(762, 12);
            this.startDateTimePicker1.Name = "startDateTimePicker1";
            this.startDateTimePicker1.Size = new System.Drawing.Size(163, 26);
            this.startDateTimePicker1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(945, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 92);
            this.button1.TabIndex = 59;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPR2DataGridViewTextBoxColumn
            // 
            this.tEMPR2DataGridViewTextBoxColumn.DataPropertyName = "TEMP_R2";
            this.tEMPR2DataGridViewTextBoxColumn.HeaderText = "TEMPERATURE";
            this.tEMPR2DataGridViewTextBoxColumn.Name = "tEMPR2DataGridViewTextBoxColumn";
            // 
            // tANK1PRESSURER2DataGridViewTextBoxColumn
            // 
            this.tANK1PRESSURER2DataGridViewTextBoxColumn.DataPropertyName = "TANK1_PRESSURE_R2";
            this.tANK1PRESSURER2DataGridViewTextBoxColumn.HeaderText = "1ST TANK PRESSURE";
            this.tANK1PRESSURER2DataGridViewTextBoxColumn.Name = "tANK1PRESSURER2DataGridViewTextBoxColumn";
            // 
            // tANK2PRESSURER2DataGridViewTextBoxColumn
            // 
            this.tANK2PRESSURER2DataGridViewTextBoxColumn.DataPropertyName = "TANK2_PRESSURE_R2";
            this.tANK2PRESSURER2DataGridViewTextBoxColumn.HeaderText = "2ND TANK PRESSURE";
            this.tANK2PRESSURER2DataGridViewTextBoxColumn.Name = "tANK2PRESSURER2DataGridViewTextBoxColumn";
            // 
            // curtimestampDataGridViewTextBoxColumn
            // 
            this.curtimestampDataGridViewTextBoxColumn.DataPropertyName = "Cur_timestamp";
            this.curtimestampDataGridViewTextBoxColumn.HeaderText = "DATE & TIME";
            this.curtimestampDataGridViewTextBoxColumn.Name = "curtimestampDataGridViewTextBoxColumn";
            // 
            // Data_Log_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.endDateTimePicker1);
            this.Controls.Add(this.startDateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimeDisplay1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Log_2";
            this.Text = "Data_Log_2";
            this.Load += new System.EventHandler(this.Data_Log_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rector2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvancedHMIControls.DateTimeDisplay dateTimeDisplay1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource wOWDataSet4BindingSource;
        private WOWDataSet4 wOWDataSet4;
        private System.Windows.Forms.BindingSource rector2BindingSource;
        private WOWDataSet4TableAdapters.Rector2TableAdapter rector2TableAdapter;
        private System.Windows.Forms.DateTimePicker endDateTimePicker1;
        private System.Windows.Forms.DateTimePicker startDateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPR2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tANK1PRESSURER2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tANK2PRESSURER2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curtimestampDataGridViewTextBoxColumn;
    }
}