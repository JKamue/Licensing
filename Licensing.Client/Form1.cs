using System;
using System.Windows.Forms;
using Licensing.Client.Hardware;

namespace Licensing.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var id = HardwareId.GenerateHardwareId(trvHardware);
            lblHardwareOutput.Text = id;
        }

        private void tbxLicense_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
