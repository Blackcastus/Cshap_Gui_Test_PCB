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
using System.Web.UI.WebControls.WebParts;

namespace Tool_Test_Ontrak_Pannel
{
    public partial class Form1 : Form
    {
        readonly double MIN_VOLT3V3 = 3.168;
        readonly double MAX_VOLT3V3 = 3.432;
        readonly double MIN_VOLT5V = 4.800;
        readonly double MAX_VOLT5V = 5.200;
        readonly double MIN_CURRENT = 2.0;
        readonly double MAX_CURRENT = 3.2;
        readonly string[] sBaudrate = { "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000" };

        private SerialPort mSerialPort;
        private PcbBase mPcbBase03;
        private PcbSync mPcbSync08;
        private PcbEtag mPcbEtag06;
        public Form1()
        {
            InitializeComponent();

            // new instance
            mPcbBase03 = new PcbBase();
            mPcbSync08 = new PcbSync();
            mPcbEtag06 = new PcbEtag();

            // init baudrate
            cboBaud.Items.AddRange(sBaudrate);

            
            // init timer
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
            if(!mSerialPort.IsOpen)
            {
                lbComStatus.Text = "Disconnected";
                lbComStatus.ForeColor = Color.Red;

                mPcbBase03.ResetVariable();
                mPcbSync08.ResetVariable();
                mPcbEtag06.ResetVariable();

                TextBox[] gTextBoxes = { tboBase3, tboBase5, tboBaseCur, tboBase384, tboBase2, 
                                        tboSync3, tboSync5, tboSync48,tboSync2, tboSync384,
                                        tboEtag3, tboEtagCurSleep, tboEtagCurTrans};
                foreach (var tb in gTextBoxes)
                {
                    tb.Text = "0";
                }

                Label[] lables = {lbBase3, lbBase5, lbBase384, lbBase2, lbBaseCur,
                                lbSync3, lbSync5, lbSync48, lbSync2, lbSync384,
                                lbEtag3, lbEtagCurSleep, lbEtagCurrRun};
                foreach (var lb in lables)
                {
                    lb.Text = "FAIL";
                    lb.BackColor = Color.Red;
                }

                foreach (var prop in mPcbBase03.GetType().GetProperties())
                {
                    if (prop.CanWrite)
                    {
                        prop.SetValue(mPcbBase03, 0);
                    }
                }
            }
        }

        /// <summary>
        /// Event when button connect click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnect_Click(object sender, EventArgs e)
        {

            if ((cboCom.Text != null) && (cboBaud.Text != null))
            {
                if(cboCom.SelectedItem != null)
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
            else
            {
                MessageBox.Show("Select a COM port and Baudrate first!");
            }
        }

        /// <summary>
        /// Event when button Disconnect click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDisconnect_Click(object sender, EventArgs e)
        {
            if (mSerialPort.IsOpen)
            {
                // update status Disconnected
                mSerialPort.Close();
                lbComStatus.Text = "Disconnected";
                lbComStatus.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Event when button refresh click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboCom.Items.Clear();
            cboCom.Items.AddRange(ports);
        }

        /// <summary>
        /// Event serial interrupt whent recive data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Check triger event
            // Console.WriteLine("Serial data received!");
            string serialBuffer = "";

            string DataRev = mSerialPort.ReadExisting();
            serialBuffer += DataRev;
            //Console.WriteLine(DataRev);

            if(serialBuffer.StartsWith("{") && serialBuffer.EndsWith("}"))
            {
                try
                {
                    var dataJson = JsonSerializer.Deserialize<Dictionary<string, object>>(serialBuffer);
                    if (dataJson != null)
                    {
                        mPcbBase03.SetVolt3V3(double.Parse(dataJson["bvolt3"].ToString()));
                        mPcbBase03.SetVolt5V(double.Parse(dataJson["bvolt5"].ToString()));
                        mPcbBase03.SetCurrent(double.Parse(dataJson["bcur"].ToString()));
                        mPcbBase03.SetSync384(double.Parse(dataJson["bsync38"].ToString()));
                        mPcbBase03.SetSync2(double.Parse(dataJson["bsync2"].ToString()));

                        mPcbSync08.setVolt3v3(double.Parse(dataJson["svolt3"].ToString()));
                        mPcbSync08.setVolt5v(double.Parse(dataJson["svolt5"].ToString()));
                        mPcbSync08.setVolt48v(double.Parse(dataJson["svolt48"].ToString()));
                        mPcbSync08.setSync384(double.Parse(dataJson["ssync38"].ToString()));
                        mPcbSync08.setSync2(double.Parse(dataJson["ssync2"].ToString()));

                        mPcbEtag06.SetVolt3v3(double.Parse(dataJson["evolt3"].ToString()));
                        mPcbEtag06.SetCurrentSleepMode(double.Parse(dataJson["ecursleep"].ToString()));
                        mPcbEtag06.SetCurrentTransMode(double.Parse(dataJson["ecurtrans"].ToString()));
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("JSON Parse Error: " + ex.Message);
                }
                serialBuffer = ""; // clean buffer
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tboBase3.Text = mPcbBase03.GetVolt3V3().ToString();
            tboBase5.Text = mPcbBase03.GetVolt5V().ToString();
            tboBaseCur.Text = mPcbBase03.GetCurrent().ToString();
            tboBase384.Text = mPcbBase03.GetSync384().ToString();
            tboBase2.Text = mPcbBase03.GetSync2().ToString();

            tboSync3.Text = mPcbSync08.GetVolt3v3().ToString();
            tboSync5.Text = mPcbSync08.GetVolt5v().ToString();
            tboSync48.Text = mPcbSync08.GetVolt48v().ToString();
            tboSync384.Text = mPcbSync08.GetSync384().ToString();
            tboSync2.Text = mPcbSync08.GetSync2().ToString();

            tboEtag3.Text = mPcbEtag06.GetVolt3v3().ToString();
            tboEtagCurSleep.Text = mPcbEtag06.GetCurrentSleepMode().ToString();
            tboEtagCurTrans.Text = mPcbEtag06.GetCurrentTransMode().ToString();

            //if (mPcbBase03.mVolt3v3 >= MIN_VOLT3V3 && mPcbBase03.mVolt3v3 <= MAX_VOLT3V3)
            //{
            //    lbBase3.Text = "PASS";
            //    lbBase3.BackColor = Color.Green;
            //}
            //else
            //{
            //    lbBase3.Text = "FAIL";
            //    lbBase3.BackColor = Color.Red;
            //}

            //if (mPcbBase03.mVolt5v >= MIN_VOLT5V && mPcbBase03.mVolt5v <= MAX_VOLT5V)
            //{
            //    lbBase5.Text = "PASS";
            //    lbBase5.BackColor = Color.Green;
            //}
            //else
            //{
            //    lbBase5.Text = "FAIL";
            //    lbBase5.BackColor = Color.Red;
            //}

            //if (mPcbBase03.mCurrent >= MIN_CURRENT && mPcbBase03.mCurrent <= MAX_CURRENT)
            //{
            //    lbBaseCur.Text = "PASS";
            //    lbBaseCur.BackColor = Color.Green;
            //}
            //else
            //{
            //    lbBaseCur.Text = "FAIL";
            //    lbBaseCur.BackColor = Color.Red;
            //}
        }
    }
}
