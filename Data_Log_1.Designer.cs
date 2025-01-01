namespace WOW_DATA_LOG
{
    partial class Data_Log_1
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPR1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANK1PRESSURER1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANK2PRESSURER1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curtimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rector1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wOWDataSet4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wOWDataSet4 = new WOW_DATA_LOG.WOWDataSet4();
            this.rector1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wOWDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDisplay1 = new AdvancedHMIControls.DateTimeDisplay();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rector1TableAdapter = new WOW_DATA_LOG.WOWDataSet4TableAdapters.Rector1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rector1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rector1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tEMPR1DataGridViewTextBoxColumn,
            this.tANK1PRESSURER1DataGridViewTextBoxColumn,
            this.tANK2PRESSURER1DataGridViewTextBoxColumn,
            this.curtimestampDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rector1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1350, 633);
            this.dataGridView1.TabIndex = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "S. No.";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPR1DataGridViewTextBoxColumn
            // 
            this.tEMPR1DataGridViewTextBoxColumn.DataPropertyName = "TEMP_R1";
            this.tEMPR1DataGridViewTextBoxColumn.HeaderText = "TEMPERATURE";
            this.tEMPR1DataGridViewTextBoxColumn.Name = "tEMPR1DataGridViewTextBoxColumn";
            // 
            // tANK1PRESSURER1DataGridViewTextBoxColumn
            // 
            this.tANK1PRESSURER1DataGridViewTextBoxColumn.DataPropertyName = "TANK1_PRESSURE_R1";
            this.tANK1PRESSURER1DataGridViewTextBoxColumn.HeaderText = "1ST TANK PRESSURE";
            this.tANK1PRESSURER1DataGridViewTextBoxColumn.Name = "tANK1PRESSURER1DataGridViewTextBoxColumn";
            // 
            // tANK2PRESSURER1DataGridViewTextBoxColumn
            // 
            this.tANK2PRESSURER1DataGridViewTextBoxColumn.DataPropertyName = "TANK2_PRESSURE_R1";
            this.tANK2PRESSURER1DataGridViewTextBoxColumn.HeaderText = "2ND TANK PRESSURE";
            this.tANK2PRESSURER1DataGridViewTextBoxColumn.Name = "tANK2PRESSURER1DataGridViewTextBoxColumn";
            // 
            // curtimestampDataGridViewTextBoxColumn
            // 
            this.curtimestampDataGridViewTextBoxColumn.DataPropertyName = "Cur_timestamp";
            this.curtimestampDataGridViewTextBoxColumn.HeaderText = "DATE & TIME";
            this.curtimestampDataGridViewTextBoxColumn.Name = "curtimestampDataGridViewTextBoxColumn";
            // 
            // rector1BindingSource1
            // 
            this.rector1BindingSource1.DataMember = "Rector1";
            this.rector1BindingSource1.DataSource = this.wOWDataSet4BindingSource1;
            // 
            // wOWDataSet4BindingSource1
            // 
            this.wOWDataSet4BindingSource1.DataSource = this.wOWDataSet4;
            this.wOWDataSet4BindingSource1.Position = 0;
            // 
            // wOWDataSet4
            // 
            this.wOWDataSet4.DataSetName = "WOWDataSet4";
            this.wOWDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rector1BindingSource
            // 
            this.rector1BindingSource.DataMember = "Rector1";
            this.rector1BindingSource.DataSource = this.wOWDataSet4BindingSource;
            // 
            // wOWDataSet4BindingSource
            // 
            this.wOWDataSet4BindingSource.DataSource = this.wOWDataSet4;
            this.wOWDataSet4BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-485, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1895, 88);
            this.label1.TabIndex = 49;
            this.label1.Text = "Data Log Rector 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeDisplay1
            // 
            this.dateTimeDisplay1.BackColor = System.Drawing.Color.Black;
            this.dateTimeDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeDisplay1.DisplayFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimeDisplay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateTimeDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimeDisplay1.Location = new System.Drawing.Point(-4, 2);
            this.dateTimeDisplay1.Name = "dateTimeDisplay1";
            this.dateTimeDisplay1.Size = new System.Drawing.Size(160, 90);
            this.dateTimeDisplay1.TabIndex = 53;
            this.dateTimeDisplay1.Text = "27-12-2024 01:06:05";
            this.dateTimeDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1087, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 87);
            this.button3.TabIndex = 52;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1223, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 87);
            this.button2.TabIndex = 51;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // rector1TableAdapter
            // 
            this.rector1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(959, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 88);
            this.button1.TabIndex = 54;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Location = new System.Drawing.Point(786, 12);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(168, 26);
            this.startDateTimePicker.TabIndex = 55;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Location = new System.Drawing.Point(786, 44);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(168, 26);
            this.endDateTimePicker.TabIndex = 56;
            // 
            // Data_Log_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimeDisplay1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Log_1";
            this.Text = "Data_Log_1";
            this.Load += new System.EventHandler(this.Data_Log_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rector1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rector1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wOWDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wOWDataSet4BindingSource;
        private WOWDataSet4 wOWDataSet4;
        private System.Windows.Forms.Label label1;
        private AdvancedHMIControls.DateTimeDisplay dateTimeDisplay1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource rector1BindingSource;
        private WOWDataSet4TableAdapters.Rector1TableAdapter rector1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tANK1PRESSURER1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tANK2PRESSURER1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curtimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rector1BindingSource1;
        private System.Windows.Forms.BindingSource wOWDataSet4BindingSource1;
    }
}