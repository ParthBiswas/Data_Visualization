using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WOW_DATA_LOG
{
    public partial class Rector_1 : Form
    {
        public Rector_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Rector_1 = new Rector_2();
            Rector_1.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            
            //string[] button23 = opcDaCom1.Write("plc.S7_200.V0_R1", 1);
            //opcDaCom1.Write("plc.S7_200.V0_R1", 1, button23);
        }

        private void simpleLED15_Click(object sender, EventArgs e)
        {
            //string[] simpleLED15 = opcDaCom1.Write("plc.S7_200.V0_ON_R1", 1);
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string[] hh = { "true" };
            opcDaCom1.Write("Simulation Examples.Functions.User3", 1, hh);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] hh = { "true" };
            opcDaCom1.Write("Simulation Examples.Functions.User3", 1, hh);
        }
    }
}
