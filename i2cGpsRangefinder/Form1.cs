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

namespace i2cGpsRangefinder
{
    public partial class Form1 : Form
    {
        DeviceI2C i2c = new DeviceI2C();
        bool portOpen = false;
        string port;

        const byte HCSR04_I2C_Address = 0x20;
        const byte HCSR04_I2C_REGISTRY_STATUS = 0xF0;
        const byte HCSR04_I2C_REGISTRY_DISTANCE_HIGH = 0xF1;
        const byte HCSR04_I2C_REGISTRY_DISTANCE_LOW = 0xF2;
        const byte I2C_GPS_STATUS_00 = 00;
        const byte I2C_GPS_REG_VERSION = 03;   // Version of the I2C_NAV SW uint8_t
        const byte I2C_GPS_LOCATION = 07;    // current location 8 byte (lat, lon) int32_t
        const byte I2C_GPS_LOCATION_LAT = 07;    // current location 8 byte (lat, lon) int32_t
        const byte I2C_GPS_LOCATION_LON = 11;    // current location 8 byte (lat, lon) int32_t
        const byte I2C_GPS_GROUND_SPEED = 31;    // GPS ground speed in m/s*100 (uint16_t)      (Read Only)
        const byte I2C_GPS_ALTITUDE = 33;    // GPS altitude in meters (uint16_t)           (Read Only)
        const byte I2C_GPS_GROUND_COURSE = 35;    // GPS ground course (uint16_t)
        const byte I2C_GPS_TIME = 39;    // UTC Time from GPS in hhmmss.sss * 100 (uint32_t)(unneccesary precision) (Read Only)
        const byte I2C_GPS_PACKETS = 40;
        const byte I2C_GPS_PING = 41;

        public Form1()
        {
            InitializeComponent();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboComPorts.Items.Add(s);
            }

            i2c.SlaveAddress = HCSR04_I2C_Address;
            
            port = Properties.Settings.Default.port;
            comboComPorts.SelectedIndex = comboComPorts.Items.IndexOf(port);
        }

        private void openPort()
        {
            if (portOpen)
                return;

            try
            {
                i2c.init(port);
                portOpen = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnRangefinder_Click(object sender, EventArgs e)
        {
            openPort();
            byte[] w = { HCSR04_I2C_REGISTRY_STATUS };
            byte[] r = new byte[3];
            i2c.write(w);
            Thread.Sleep(10);
            i2c.read(r);
            txtRangerfinderRegs.Text = DeviceI2C.ByteArrayToString(r);
            int range = (((int)r[1]) << 8) + (int)r[2];
            txtRangefinderDistance.Text = range.ToString();
        }

        private uint requestGps(byte addr, byte len, TextBox textBox)
        {
            openPort();
            uint val = 0;
            byte[] w = { addr };
            byte[] r = new byte[len];
            i2c.write(w);
            Thread.Sleep(10);
            i2c.read(r);
            switch (len)
            {
                case 1: val = r[0]; break;
                case 2: val = (((uint)r[1] << 8) + ((uint)r[0] << 0)); break;
                case 4: val = (((uint)r[3] << 24) + ((uint)r[2] << 16) + ((uint)r[1] << 8) + ((uint)r[0] << 0)); break;
            }
            textBox.Text = val.ToString();
            return val;
        }

        private void btnGpsStatus_Click(object sender, EventArgs e)
        {
            uint val = requestGps(I2C_GPS_STATUS_00, 1, txtGpsStatus);
            cbGps2d.Checked = (val & 2) > 0;
            cbGps3d.Checked = (val & 4) > 0;
            uint numsats = (val >> 4) & 0xF;
            txtGpsSats.Text = numsats.ToString();
        }

        private void btnGpsAltitude_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_ALTITUDE, 2, txtGpsAltitude);
        }

        private void btnGpsLat_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_LOCATION_LAT, 4, txtGpsLat);
        }

        private void btnGpsLon_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_LOCATION_LON, 4, txtGpsLon);
        }

        private void btnGpsSpeed_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_GROUND_SPEED, 2, txtGpsSpeed);
        }

        private void btnGpsCourse_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_GROUND_COURSE, 2, txtGpsCourse);
        }

        private void btnGpsPackets_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_PACKETS, 4, txtPackets);
        }

        private void btnGps_Click(object sender, EventArgs e)
        {
            btnGpsStatus_Click(null, null);
            btnGpsAltitude_Click(null, null);
            btnGpsLat_Click(null, null);
            btnGpsLon_Click(null, null);
            btnGpsSpeed_Click(null, null);
            btnGpsCourse_Click(null, null);
            btnGpsPackets_Click(null, null);
        }

        private void btnGpsPing_Click(object sender, EventArgs e)
        {
            requestGps(I2C_GPS_PING, 1, txtGpsPing);
        }

        private void comboComPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboComPorts.SelectedIndex;
            port = comboComPorts.Items[i].ToString();
            Properties.Settings.Default.port = port;
            Properties.Settings.Default.Save();
        }

    }
}
