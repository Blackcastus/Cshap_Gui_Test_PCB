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
using Newtonsoft.Json.Linq;
//using System.Web.UI.WebControls;

namespace Tool_Test_Ontrak_Pannel
{
    public partial class Form1 : Form
    {
        readonly string[] sBaudrate = { "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000" };
        private string[] sJsonPaser = {"btp3v", "btp5v", "btpcur", "btp384", "btp2k", "btpis3v","btpis5v","btpiscur", "btpis384", "btpis2k",
                                        "stp3v", "stp5v", "stp48v", "stp384", "stp2k", "stpis3v", "stpis5v", "stpis48v", "stpis384", "stpis2k",
                                        "etp3v", "etpcursm", "etpcurtm", "etpis3v", "etpiscursm", "etpiscurtm"};
        private SerialPort mSerialPort;
        private PcbBase mPcbBase03;
        private PcbSync mPcbSync08;
        private PcbEtag mPcbEtag06;
        private string serialBuffer = "";
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
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            Timer timer_100ms = new Timer();
            timer_100ms.Interval = 50;
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
            cboCom.Text = "COM4";
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
                    // Set port name, baud, parity, databit, stopbit
                    mSerialPort.PortName = cboCom.Text;
                    mSerialPort.BaudRate = int.Parse(cboBaud.Text);
                    mSerialPort.Parity = Parity.None;
                    mSerialPort.DataBits = 8;
                    mSerialPort.StopBits = StopBits.One;
                    mSerialPort.Open();

                    // call event data receive
                    mSerialPort.DataReceived += serialPort1_DataReceived;

                    // update status connect or disconnect
                    if (mSerialPort.IsOpen)
                    {
                        tbDebug.Text = "Connected with " + cboCom.Text;

                        lbComStatus.Text = "Connected";
                        lbComStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        tbDebug.Text = "Disconnected with " + cboCom.Text;

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
            //string tmBuffer = "";
            string DataRev = mSerialPort.ReadLine();
            //tmBuffer += DataRev;
            //Console.WriteLine(DataRev);
            if (DataRev.EndsWith("\r"))
            {
                serialBuffer = DataRev;
                //tmBuffer = "";
                this.Invoke(new Action(ParseSerialData)); // Gọi hàm Parse trên UI thread
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // show base value
            tboBase3.Text = mPcbBase03.GetVolt3V3().ToString();
            tboBase5.Text = mPcbBase03.GetVolt5V().ToString();
            tboBaseCur.Text = mPcbBase03.GetCurrent().ToString();
            tboBase384.Text = mPcbBase03.GetSync384().ToString();
            tboBase2.Text = mPcbBase03.GetSync2().ToString();

            // show sync value
            tboSync3.Text = mPcbSync08.GetVolt3v3().ToString();
            tboSync5.Text = mPcbSync08.GetVolt5v().ToString();
            tboSync48.Text = mPcbSync08.GetVolt48v().ToString();
            tboSync384.Text = mPcbSync08.GetSync384().ToString();
            tboSync2.Text = mPcbSync08.GetSync2().ToString();

            // show etag value
            tboEtag3.Text = mPcbEtag06.GetVolt3v3().ToString();
            tboEtagCurSleep.Text = mPcbEtag06.GetCurrentSleepMode().ToString();
            tboEtagCurTrans.Text = mPcbEtag06.GetCurrentTransMode().ToString();

            if (mPcbBase03.GetIsVolt3v3())
            {
                lbBase3.Text = "PASS";
                lbBase3.BackColor = Color.Green;
            }
            else
            {
                lbBase3.Text = "FAIL";
                lbBase3.BackColor = Color.Red;
            }

            if (mPcbBase03.GetIsVolt5v())
            {
                lbBase5.Text = "PASS";
                lbBase5.BackColor = Color.Green;
            }
            else
            {
                lbBase5.Text = "FAIL";
                lbBase5.BackColor = Color.Red;
            }

            if (mPcbBase03.GetIsCurrent())
            {
                lbBaseCur.Text = "PASS";
                lbBaseCur.BackColor = Color.Green;
            }
            else
            {
                lbBaseCur.Text = "FAIL";
                lbBaseCur.BackColor = Color.Red;
            }

            if (mPcbBase03.GetIsSync384())
            {
                lbBase384.Text = "PASS";
                lbBase384.BackColor = Color.Green;
            }
            else
            {
                lbBase384.Text = "FAIL";
                lbBase384.BackColor = Color.Red;
            }

            if (mPcbBase03.GetIsSync2())
            {
                lbBase2.Text = "PASS";
                lbBase2.BackColor = Color.Green;
            }
            else
            {
                lbBase2.Text = "FAIL";
                lbBase2.BackColor = Color.Red;
            }
        }

        private void ParseSerialData()
        {
            if (serialBuffer.EndsWith("\r"))
            {
                try
                {
                    var dataJson = JsonSerializer.Deserialize<Dictionary<string, object>>(serialBuffer);
                    if (dataJson != null)
                    {
                        bool isEnable = false;
                        foreach (var dic in dataJson)
                        {
                            //Console.WriteLine(dic.Key);
                            if (sJsonPaser.Contains(dic.Key))
                            {
                                switch (dic.Key)
                                {
                                    case "btp3v":
                                        mPcbBase03.SetVolt3V3(double.Parse(dic.Value.ToString()));
                                        break;
                                    case "btp5v":
                                        mPcbBase03.SetVolt5V(double.Parse(dic.Value.ToString()));
                                        break;
                                    case "btpcur":
                                        mPcbBase03.SetCurrent(double.Parse(dic.Value.ToString()));
                                        break;
                                    case "btp384":
                                        mPcbBase03.SetSync384(double.Parse(dic.Value.ToString()));
                                        break;
                                    case "btp2k":
                                        mPcbBase03.SetSync2(double.Parse(dic.Value.ToString()));
                                        break;
                                    case "btpis3v":
                                        isEnable = bool.Parse(dic.Value.ToString());
                                        mPcbBase03.SetIsVolt3v3(isEnable);
                                        break;
                                    case "btpis5v":
                                        isEnable = bool.Parse(dic.Value.ToString());
                                        mPcbBase03.SetIsVolt5v(isEnable);
                                        break;
                                    case "btpiscur":
                                        isEnable = bool.Parse(dic.Value.ToString());
                                        mPcbBase03.SetIsCurrent(isEnable);
                                        break;
                                    case "btpis384":
                                        isEnable = bool.Parse(dic.Value.ToString());
                                        mPcbBase03.SetIsSync384(isEnable);
                                        break;
                                    case "btpis2k":
                                        isEnable = bool.Parse(dic.Value.ToString());
                                        mPcbBase03.SetIsSync2(isEnable);
                                        break;
                                    case "stp3v":
                                        break;
                                    case "stp5v":
                                        break;
                                    case "stp48v":
                                        break;
                                    case "stp384":
                                        break;
                                    default:
                                        break;
                                }
                                //}
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("JSON Parse Error: " + ex.Message);
                }
                serialBuffer = ""; // clean buffer
            }
        }
    }
}
