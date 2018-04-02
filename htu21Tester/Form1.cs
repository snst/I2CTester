using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i2cAdapter;
using System.Threading;

namespace htu21Tester
{
    public partial class FormHTU21 : Form
    {
        DeviceI2C i2c = new DeviceI2C();

        public FormHTU21()
        {
            InitializeComponent();
            i2c.init("COM4");
            i2c.SlaveAddress = 0x40;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string txt = "";
            byte[] w = { 0xf3 };
            byte[] r = new byte[3];
            if (i2c.write(w))
            {
                Thread.Sleep(500);
                if (i2c.read(r))
                {
                    int rawValue = (((int)r[0] << 8) | (int)r[1]) & 0xFFFC;
                    double temp = (rawValue * 175.72 / 65536 - 46.85);
                    txt = temp.ToString();
                } else
                {
                    txt = "read timeout";
                }
            } else
            {
                txt = "write failed";
            }
            labelTemp.Text = txt;
        }
    }
}
