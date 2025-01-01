using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WOW_DATA_LOG
{
    public partial class Data_Log_2 : Form
    {

        OdbcConnection con = new OdbcConnection("Dsn=WOW");
        OdbcCommand mcd;
        OdbcDataAdapter dataadap;
        DataTable data;
        OdbcCommandBuilder databuild;
        public Data_Log_2()
        {
            InitializeComponent();
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
        private void load_part(DateTime? startDate = null, DateTime? endDate = null)
        {
            opencon();

            // SQL query with optional date filtering
            string query = "SELECT * FROM Rector2";
            if (startDate.HasValue && endDate.HasValue)
            {
                query += " WHERE Rector2 BETWEEN ? AND ?";
            }

            var cmd = new OdbcCommand(query, con);
            if (startDate.HasValue && endDate.HasValue)
            {
                cmd.Parameters.AddWithValue("@startDate", startDate.Value);
                cmd.Parameters.AddWithValue("@endDate", endDate.Value);
            }

            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);

            dataGridView1.DataSource = ds;
            dataGridView1.ClearSelection();

            closecon();
        }
        private void Data_Log_2_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'wOWDataSet.report' table. You can move, or remove it, as needed.
            //this.rector2TableAdapter.Fill(this.wOWDataSet4.Rector2);
            //// TODO: This line of code loads data into the 'worthofwasteDataSet.DATA_LOG' table. You can move, or remove it, as needed.
            //this.rector2TableAdapter.Fill(this.wOWDataSet4.Rector2);

        }
        private void ExportToExcel()
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                            // worksheet.
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_part();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = startDateTimePicker1.Value;
                DateTime endDate = endDateTimePicker1.Value;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be after end date.");
                    return;
                }

                load_part(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while filtering: " + ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
