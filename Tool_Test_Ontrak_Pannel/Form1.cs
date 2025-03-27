using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.SqlTypes;


namespace Tool_Test_Ontrak_Pannel
{
    public partial class Form1 : Form
    {
        readonly double MIN_VOLT3V3 = 3.168;
        readonly double MAX_VOLT3V3 = 3.432;
        readonly double MIN_VOLT5V = 4.800;
        readonly double MAX_VOLT5V = 5.200;
        readonly double MIN_CURRENT = 2;
        readonly double MAX_CURRENT = 3.2;

        private SerialPort mSerialPort;
        //private SensorData mSensorData;
        private float volt3v3;
        private float volt5V;
        private float ampe;
        public Form1()
        {
            InitializeComponent();
            string[] sBaudrate = { "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000" };
            cboBaud.Items.AddRange(sBaudrate);

            //cboCom.Text = "COM4";

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            Timer timer_100ms = new Timer();
            timer_100ms.Interval = 100;
            timer_100ms.Tick += Timer_100ms;
            timer_100ms.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mSerialPort = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            cboCom.Items.Clear();
            cboCom.Items.AddRange(ports);
            cboBaud.Text = "9600";
        }
        private void Timer_100ms(object sender, EventArgs e)
        {
            if(mSerialPort.IsOpen == false)
            {
                tboxBase3v3.Text = "0";
                tboxBase5v.Text = "0";
                tboxBaseCurrent.Text = "0";
                lbBase3v3.Text = "FAIL";
                lbBase3v3.BackColor = Color.Red;
                lbBase5V.Text = "FAIL";
                lbBase5V.BackColor = Color.Red;
                lbBaseCurrent.Text = "FAIL";
                lbBaseCurrent.BackColor = Color.Red;
                volt3v3 = 0;
                volt5V = 0;
                ampe = 0;
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if ((cboCom.Text != null) && (cboBaud.Text != null))
            {
                mSerialPort.PortName = cboCom.Text;
                mSerialPort.BaudRate = int.Parse(cboBaud.Text);
                mSerialPort.Parity = Parity.None;
                mSerialPort.DataBits = 8;
                mSerialPort.StopBits = StopBits.One;
                mSerialPort.DataReceived += serialPort1_DataReceived;
                mSerialPort.Open();

                Console.WriteLine("Connected with " + cboCom.Text);
                // update status connected
                if (mSerialPort.IsOpen)
                {
                    lbComStatus.Text = "Connected";
                    lbComStatus.ForeColor = Color.Green;
                    //tbRevContent.Text = "Connected with " + cboCom.Text + ", " + cboBaud.Text + Environment.NewLine;
                }
                else
                {
                    lbComStatus.Text = "Disconnected";
                    lbComStatus.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Select a COM port and Baudrate first!");
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            if (mSerialPort.IsOpen)
            {
                mSerialPort.Close();
                // update status Disconnected
                lbComStatus.Text = "Disconnected";
                lbComStatus.ForeColor = Color.Red;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboCom.Items.Clear();
            cboCom.Items.AddRange(ports);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Kiểm tra sự kiện có chạy không
            //Console.WriteLine("Serial data received!");
            string DataRev = "";
            DataRev = mSerialPort.ReadLine();
            Console.WriteLine(DataRev);

            var dataJson = JsonSerializer.Deserialize<Dictionary<string, object>>(DataRev);
            if(dataJson != null)
            {
                volt3v3 = float.Parse(dataJson["volt3v3"].ToString());
                volt5V = float.Parse(dataJson["volt5V"].ToString());
                ampe = float.Parse(dataJson["ampe"].ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tboxBase3v3.Text = volt3v3.ToString();
            tboxBase5v.Text = volt5V.ToString();
            tboxBaseCurrent.Text = ampe.ToString();

            if (volt3v3 >= MIN_VOLT3V3 && volt3v3 <= MAX_VOLT3V3)
            {
                lbBase3v3.Text = "PASS";
                lbBase3v3.BackColor = Color.Green;
            }
            else
            {
                lbBase3v3.Text = "FAIL";
                lbBase3v3.BackColor = Color.Red;
            }

            if (volt5V >= MIN_VOLT5V && volt5V <= MAX_VOLT5V)
            {
                lbBase5V.Text = "PASS";
                lbBase5V.BackColor = Color.Green;
            }
            else
            {
                lbBase5V.Text = "FAIL";
                lbBase5V.BackColor = Color.Red;
            }

            if (ampe >= MIN_CURRENT && ampe <= MAX_CURRENT)
            {
                lbBaseCurrent.Text = "PASS";
                lbBaseCurrent.BackColor = Color.Green;
            }
            else
            {
                lbBaseCurrent.Text = "FAIL";
                lbBaseCurrent.BackColor = Color.Red;
            }
        }
    }
}
