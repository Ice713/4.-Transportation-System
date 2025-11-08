using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Transportation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            Vehicle myBus = new Bus(Convert.ToDecimal(numericUpDownMaxSpeed.Text), Convert.ToInt32(numericUpDownSeatingCapacity.Text));

            MessageBox.Show(myBus.ShowDetails(), "Bus Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
