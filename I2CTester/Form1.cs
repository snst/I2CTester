using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i2cAdapter;

namespace I2CTester
{
    public partial class Form1 : Form
    {
        DeviceI2C i2c = new DeviceI2C();
        public Form1()
        {
            InitializeComponent();
            i2c.init("COM4");
        }

        private byte getAddr()
        {
            byte[] addr = DeviceI2C.StringToByteArray(txtAddress.Text);
            return addr[0];
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            byte[] w = DeviceI2C.StringToByteArray(txtWrite.Text);
            i2c.SlaveAddress = getAddr();
            i2c.write(w);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            byte[] r = new byte[int.Parse(txtReadCount.Text)];
            i2c.SlaveAddress = getAddr();
            i2c.read(r);
            txtRead.Text = DeviceI2C.ByteArrayToString(r);
        }
    }
}
