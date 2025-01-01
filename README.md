# Project Report: PLC Data Visualization

## Abstract
The WOW Data Logger and Visualization project is a Windows-based application developed in C#. Its primary purpose is to log real-time data, visualize trends dynamically, and provide data export capabilities. The project integrates technologies like ODBC for database connectivity, Microsoft Excel Interop for data export, and the .NET Framework's charting libraries for data visualization.

---

## Objectives
- To log real-time data from sensors and industrial devices.
- To provide users with dynamic trend visualizations for monitoring processes.
- To ensure seamless data export for reporting and analysis.
- To enable communication with industrial devices using OPC protocols.

---

## Tools and Technologies
- **Programming Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Database**: SQL Server (connected via ODBC)
- **Visualization**: Windows Forms Chart Control
- **Data Export**: Microsoft Excel Interop
- **Additional Tools**: AdvancedHMI, OPC communication (planned).

---

## Features and Functionalities

### 1. **Real-Time Data Logging**
Data is logged dynamically using ODBC connections to SQL Server. The application records timestamps and parameter values into a structured database schema.

**Code Snippet:**
```csharp
OdbcConnection con = new OdbcConnection("Dsn=WOW");
OdbcCommand cmd = new OdbcCommand("INSERT INTO DataLog (Timestamp, Value) VALUES (?, ?)", con);
cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
cmd.Parameters.AddWithValue("@Value", sensorValue);
cmd.ExecuteNonQuery();
```

### 2. **Dynamic Trend Visualization**
The application uses the .NET Chart Control to render live trends. Users can monitor temperature changes over time.

**Code Snippet:**
```csharp
private void InitializeChart()
{
    ChartArea chartArea = new ChartArea();
    chartArea.AxisX.Title = "Time";
    chartArea.AxisY.Title = "Temperature";
    trendChart.ChartAreas.Add(chartArea);
    trendChart.Series.Add("Temperature");
    trendChart.Series["Temperature"].ChartType = SeriesChartType.Line;
}
```

### 3. **Data Export to Excel**
Users can export logged data to Excel for further analysis and reporting.

**Code Snippet:**
```csharp
public void ExportToExcel()
{
    Excel.Application xlApp = new Excel.Application();
    Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

    xlWorkSheet.Cells[1, 1] = "Time";
    xlWorkSheet.Cells[1, 2] = "Value";

    xlWorkBook.SaveAs("DataLog.xlsx");
    xlApp.Quit();
}
```

### 4. **Timer for Live Updates**
A timer is used to periodically refresh data and update visualizations.

**Code Snippet:**
```csharp
private void InitializeTimer()
{
    timer = new Timer();
    timer.Interval = 1000; // 1-second interval
    timer.Tick += Timer_Tick;
    timer.Start();
}

private void Timer_Tick(object sender, EventArgs e)
{
    RefreshData();
}
```

### 5. **OPC Server Communication (Planned)**
Initial implementation for OPC server communication is present but commented out. It involves connecting to industrial devices for real-time data acquisition.

**Code Snippet:**
```csharp
// opcServer = new Opc.Da.Server();
// opcServer.Url = "opcda://localhost"; // Replace with OPC server details
```

---

## Implementation Details

### Architecture
1. **Frontend**: Windows Forms with interactive elements like charts and tooltips.
2. **Backend**: Database connections via ODBC, handling real-time data and user commands.
3. **Data Management**: SQL Server as the backend for data persistence and retrieval.

### Dataset Schema
- **Table Name**: DataLog
  - Columns: Timestamp (DateTime), Value (Float).

### Data Flow
1. Sensor data is acquired and logged into SQL Server.
2. Visualization components read data from the database and display trends.
3. Export functionality saves data locally as Excel files.

---

## Challenges and Solutions

### 1. **Timer Malfunction**
**Issue**: Timer was not triggering the auto-refresh.
**Solution**: Reinitialized the timer in the `Home` form constructor and debugged event bindings.

### 2. **OPC Communication**
**Issue**: Incomplete implementation due to lack of server access.
**Solution**: Placeholder code added; functionality to be completed in the future.

### 3. **Excel Interop Performance**
**Issue**: Exporting large datasets caused delays.
**Solution**: Optimized row-by-row data insertion using batch processing.

---

## Conclusion and Future Scope
The WOW Data Logger and Visualization project successfully logs and visualizes real-time data, enabling users to monitor processes effectively. Future enhancements include:
1. Fully implementing OPC communication.
2. Optimizing performance for larger datasets.
3. Adding user-configurable visualization options.
4. Deploying the application for use in an industrial environment.

---

## References
- Microsoft Documentation on Windows Forms and Chart Control.
- Tutorials on ODBC and Excel Interop.

---

**End of Report**

