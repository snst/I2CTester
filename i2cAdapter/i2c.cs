using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace i2cAdapter
{
    public enum I2cCmd
    {
        Write = 1, Read = 2
    }
    
    public class DeviceI2C
    {
        private SerialPort serial = null;
        private byte slaveAddress;
        private byte[] rxBuffer = null;
        private bool readReady = false;
        private int readTimeout = 500;

        public int ReadTimeout
        {
            get { return readTimeout; }
            set { readTimeout = value; }
        }

        public byte SlaveAddress
        {
            get { return slaveAddress; }
            set { slaveAddress = value; }
        }

        public void init(String port, int baud=19200)
        {
            serial = new SerialPort(port, baud, Parity.None, 8, StopBits.One);
            serial.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
            serial.Open();
        }
        
        public bool read(Byte[] buffer)
        {
            rxBuffer = buffer;
            readReady = false;
            sendCmd(I2cCmd.Read, buffer);
            int n = readTimeout;
            while (!readReady && (--n > 0))
                Thread.Sleep(1);
            rxBuffer = null;
            return n != 0;
        }

        public bool write(Byte[] buffer)
        {
            return sendCmd(I2cCmd.Write, buffer);
        }

        private bool sendCmd(I2cCmd cmd, byte[] buf)
        {
            // 0xFE, cmd, addr, len
            try {
                int len = 4;
                if (cmd == I2cCmd.Write)
                    len += buf.Length;

                byte[] p = new byte[len];
                int i = 0;
                p[i++] = (byte)0xFE;
                p[i++] = (byte)cmd;
                p[i++] = SlaveAddress;
                p[i++] = (byte)buf.Length;
                if (cmd == I2cCmd.Write)
                    buf.CopyTo(p, i);

                serial.Write(p, 0, p.Length);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //    Console.WriteLine(serial.ReadExisting());
            int i = 0;
            while (serial.BytesToRead > 0) {
                int b = serial.ReadByte();
                if (rxBuffer != null) {
                    rxBuffer[i++] = (byte)b;
                    if(i==rxBuffer.Length) {
                        readReady = true;
                        rxBuffer = null;
                    }
                } else {
                    i = 0;
                }
//                Console.WriteLine(b.ToString());
            }
        }

        static public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length / 2).Select(x => Convert.ToByte(hex.Substring(x * 2, 2), 16)).ToArray();
        }

        static public string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
