//using Opc.Da;
//using System;

//namespace WOW_DATA_LOG
//{
//    public class OPCCommunication
//    {
//        private Opc.Da.Server opcServer;
//        private Opc.Da.Subscription opcSubscription;
//        private Opc.Da.Item[] items;

//        public OPCCommunication()
//        {
//            // Initialize OPC server connection details
//            opcServer = new Opc.Da.Server();
//            opcServer.Url = "opcda://localhost";  // Replace with your OPC server's IP and name
//        }

//        // Method to establish the connection to the OPC server and subscribe to data
//        public void SubscribeToData()
//        {
//            try
//            {
//                // Connect to the OPC server
//                opcServer.Connect();

//                // Define the item (tag) you want to read (replace with your actual tag)
//                items = new Opc.Da.Item[1];
//                items[0] = new Opc.Da.Item() { ItemName = "plc.S7_200.RUN_IND_R2" };  // Replace with your PLC's data item name

//                // Create a subscription to listen for data changes
//                opcSubscription = new Opc.Da.Subscription();
//                opcSubscription.Items.AddRange(items);
//                opcSubscription.DataChanged += OpcSubscription_DataChanged;
//                opcSubscription.Create();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error subscribing to OPC server: {ex.Message}");
//            }
//        }

//        // Event handler when data changes from OPC
//        private void OpcSubscription_DataChanged(object sender, Opc.Da.DataChangedEventArgs e)
//        {
//            foreach (Opc.Da.ItemValueChangedEventArgs valueChanged in e.ItemValues)
//            {
//                // Retrieve the updated value (e.g., temperature, pressure)
//                double newValue = Convert.ToDouble(valueChanged.Value);

//                // Pass the new value to the main form to update the trend chart
//                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
//                mainForm?.Invoke(new Action(() => mainForm.UpdateTrendChart(newValue)));
//            }
//        }

//        // Disconnect from the OPC server
//        public void Disconnect()
//        {
//            if (opcSubscription != null)
//            {
//                opcSubscription.Dispose();
//            }
//            if (opcServer != null)
//            {
//                opcServer.Disconnect();
//            }
//        }
//    }
//}
