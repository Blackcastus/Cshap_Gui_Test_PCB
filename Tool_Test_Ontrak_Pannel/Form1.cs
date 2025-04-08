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
using Tesseract;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;


namespace Tool_Test_Ontrak_Pannel
{
    public partial class fMain_Pannel : Form
    {
        private readonly string[] sBaudrate = { "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000" };
        private readonly string[] sPcbBaseKey = { "btp3v", "btp5v", "btpcur", "btpmhz", "btpkhz" };
        private readonly string[] sPcbSyncKey = { "stp3v", "stp5v", "stp48v", "stpmhz", "stpkhz" };
        private readonly string[] sPcbEtagKey = { "etp3v", "etpcursleepmode", "etpcurtransmode" };

        private SerialPort mSerialPort;
        private PcbBase pPcbBase03;
        private PcbSync pPcbSync08;
        private PcbEtag pPcbEtag06;
        private DataProcessing pDataProcessing; 
        private string serialBuffer = "";
        
        bool mStatusConnectOsci = false;
        //[DllImport("user32.dll", SetLastError = true)]
        //static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private Dictionary<string, DataStructure> mSerialDicData = new Dictionary<string, DataStructure>();
        public fMain_Pannel()
        {
            // new instance
            pPcbBase03 = new PcbBase();
            pPcbSync08 = new PcbSync();
            pPcbEtag06 = new PcbEtag();
            pDataProcessing = new DataProcessing();

            InitializeComponent();
            InitDictionary();
            //ParseSerialData();
            // Setup Form position
            Rectangle WorkingArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(WorkingArea.Left, WorkingArea.Top);
            this.Size = new Size(WorkingArea.Width / 2, WorkingArea.Height);
            btCloseOsci.ForeColor = Color.Red;
            btOpenOsci.ForeColor = Color.Black;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mSerialPort = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            cboCom.Items.Clear();
            cboCom.Items.AddRange(ports);
            cboBaud.Text = "9600";
            cboCom.Text = "COM4";

            // init baudrate
            cboBaud.Items.AddRange(sBaudrate);

            // init timer
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Display;
            timer.Start();

            Timer timer_100ms = new Timer();
            timer_100ms.Interval = 100;
            timer_100ms.Tick += Timer_CheckConnection;
            timer_100ms.Start();

            Timer timer_10ms = new Timer();
            timer_100ms.Interval = 10;
            timer_100ms.Tick += Timer_CaptureScreen;
            timer_100ms.Start();
        }

        private void Timer_CaptureScreen(object sender, EventArgs e)
        {
            // Detect frequency
            if (mStatusConnectOsci)
            {
                pDataProcessing.CaptureScreen();
            }
            else
            {
                pPcbBase03.pFreqMHz.SetParam(0, "", false);
                pPcbBase03.pFreqKHz.SetParam(0, "", false);

                pPcbSync08.pFreqMHz.SetParam(0, "", false);
                pPcbSync08.pFreqKHz.SetParam(0, "", false);
            }
        }

        private void Timer_CheckConnection(object sender, EventArgs e)
        {
            // refresh Screen volt current
            if (!mSerialPort.IsOpen)
            {
                pPcbBase03.ResetValue();
                pPcbSync08.ResetValue();
                pPcbEtag06.ResetValue();
                pDataProcessing.UpdateButtonTextColor(btDisconnect, Color.Red);
                pDataProcessing.UpdateButtonTextColor(btConnect, Color.Black);
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
                        //btConnect.Text = Connected
                        //lbComStatus.Text = "Connected";
                        //lbComStatus.ForeColor = Color.Green;
                        pDataProcessing.UpdateButtonTextColor(btDisconnect, Color.Black);
                        pDataProcessing.UpdateButtonTextColor(btConnect, Color.Green);
                    }
                    else
                    {
                        //lbComStatus.Text = "Disconnected";
                        //lbComStatus.ForeColor = Color.Red;
                        pDataProcessing.UpdateButtonTextColor(btDisconnect, Color.Red);
                        pDataProcessing.UpdateButtonTextColor(btConnect, Color.Black);
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
                mSerialPort.DataReceived -= serialPort1_DataReceived;
                // update status Disconnected
                mSerialPort.Close();
                pDataProcessing.UpdateButtonTextColor(btDisconnect, Color.Red);
                pDataProcessing.UpdateButtonTextColor(btConnect, Color.Black);
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
            try
            {
                string DataRev = mSerialPort.ReadLine();
                if (DataRev.EndsWith("\r"))
                {
                    serialBuffer = DataRev;
                    this.Invoke(new Action(() => ParseSerialData()));
                }
            }
            catch (IOException ex)
            {
                // TODO
            }
        }

        private void ParseSerialData()
        {
            //serialBuffer = "{\"btp3v\": \"2.4, mV, false\", \"btp5v\": \"2.7, mV, false\", \"btpcur\": \"3.5, mV, true\"}";
            if (serialBuffer.EndsWith("\r"))
            {
                try
                {
                    var dataJson = JsonSerializer.Deserialize<Dictionary<string, object>>(serialBuffer);
                    if (dataJson != null)
                    {
                        //bool isEnable = false;
                        foreach (var item in dataJson)
                        {
                            if(mSerialDicData.ContainsKey(item.Key))
                            {
                                string varTemp = item.Value.ToString();
                                string[] parts = varTemp.Split(',');

                                if(parts.Length == 3)
                                {
                                    string tmpValue = parts[0];
                                    string tmpUnit = parts[1];
                                    string tmpStt = parts[2];
                                    if(double.TryParse(tmpValue, out double val) && int.TryParse(tmpStt, out int stt))
                                    {
                                        DataStructure tmpData = new DataStructure();
                                        tmpData.mValue = val;
                                        tmpData.mUnit = tmpUnit;
                                        tmpData.mStatus = stt == 1? true:false;

                                        mSerialDicData[item.Key] = tmpData;
                                    }    
                                }    
                            }    
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("JSON Parse Error: " + ex.Message);
                }
                //serialBuffer = ""; // clean buffer
            }
        }

        private void InitDictionary()
        {
            DataStructure temp = new DataStructure();
            temp.SetParam(0, "", false);

            mSerialDicData.Add(sPcbBaseKey[0], temp);
            mSerialDicData.Add(sPcbBaseKey[1], temp);
            mSerialDicData.Add(sPcbBaseKey[2], temp);
            mSerialDicData.Add(sPcbBaseKey[3], temp);
            mSerialDicData.Add(sPcbBaseKey[4], temp);

            mSerialDicData.Add(sPcbSyncKey[0], temp);
            mSerialDicData.Add(sPcbSyncKey[1], temp);
            mSerialDicData.Add(sPcbSyncKey[2], temp);
            mSerialDicData.Add(sPcbSyncKey[3], temp);
            mSerialDicData.Add(sPcbSyncKey[4], temp);

            mSerialDicData.Add(sPcbEtagKey[0], temp);
            mSerialDicData.Add(sPcbEtagKey[1], temp);
            mSerialDicData.Add(sPcbEtagKey[2], temp);
        }
        private void Timer_Display(object sender, EventArgs e)
        {
            pPcbBase03.pVolt3   = mSerialDicData[sPcbBaseKey[0]];
            pPcbBase03.pVolt5   = mSerialDicData[sPcbBaseKey[1]];
            pPcbBase03.pCurrent = mSerialDicData[sPcbBaseKey[2]];
            pPcbBase03.pFreqMHz = pDataProcessing.mFreqCh1;
            pPcbBase03.pFreqKHz = pDataProcessing.mFreqCh2;

            pPcbSync08.pVolt3   = mSerialDicData[sPcbSyncKey[0]];
            pPcbSync08.pVolt5   = mSerialDicData[sPcbSyncKey[1]];
            pPcbSync08.pVolt48  = mSerialDicData[sPcbSyncKey[2]];
            pPcbSync08.pFreqMHz = pDataProcessing.mFreqCh3;
            pPcbSync08.pFreqKHz = pDataProcessing.mFreqCh4;

            pPcbEtag06.pVolt3   = mSerialDicData[sPcbEtagKey[0]];
            pPcbEtag06.pCurSleepMode   = mSerialDicData[sPcbEtagKey[1]];
            pPcbEtag06.pCurTrasMode   = mSerialDicData[sPcbEtagKey[2]];

            // show value + Unit
            tboBaseVolt3.Text   = pPcbBase03.pVolt3.mValue.ToString("F4") + " " +  pPcbBase03.pVolt3.mUnit;
            tboBaseVolt5.Text   = pPcbBase03.pVolt5.mValue.ToString("F4") + " " + pPcbBase03.pVolt5.mUnit;
            tboBaseCurrent.Text = pPcbBase03.pCurrent.mValue.ToString("F4") + " " + pPcbBase03.pCurrent.mUnit;
            tboBaseSyncMHz.Text = pPcbBase03.pFreqMHz.mValue.ToString("F4") + " " + pPcbBase03.pFreqMHz.mUnit;
            tboBaseSyncKHz.Text = pPcbBase03.pFreqKHz.mValue.ToString("F4") + " " + pPcbBase03.pFreqKHz.mUnit;

            tboSyncVolt3.Text   = pPcbSync08.pVolt3.mValue.ToString("F4") + " " + pPcbSync08.pVolt3.mUnit;
            tboSyncVolt5.Text   = pPcbSync08.pVolt5.mValue.ToString("F4") + " " + pPcbSync08.pVolt5.mUnit;
            tboSyncVolt48.Text  = pPcbSync08.pVolt48.mValue.ToString("F4") + " " + pPcbSync08.pVolt48.mUnit;
            tboSyncMHz.Text     = pPcbSync08.pFreqMHz.mValue.ToString("F4") + " " + pPcbSync08.pFreqMHz.mUnit;
            tboSyncKHz.Text     = pPcbSync08.pFreqKHz.mValue.ToString("F4") + " " + pPcbSync08.pFreqKHz.mUnit;

            tboEtagVolt3.Text       = pPcbEtag06.pVolt3.mValue.ToString("F4") + " " + pPcbEtag06.pVolt3.mUnit;
            tboEtagCurSleep.Text    = pPcbEtag06.pCurSleepMode.mValue.ToString("F4") + " " + pPcbEtag06.pCurSleepMode.mUnit;
            tboEtagCurTrans.Text    = pPcbEtag06.pCurTrasMode.mValue.ToString("F4") + " " + pPcbEtag06.pCurTrasMode.mUnit;

            pDataProcessing.UpdateLable(lbBaseVolt3, pPcbBase03.pVolt3.mStatus);
            pDataProcessing.UpdateLable(lbBaseVolt5, pPcbBase03.pVolt5.mStatus);
            pDataProcessing.UpdateLable(lbBaseCur, pPcbBase03.pCurrent.mStatus);
            pDataProcessing.UpdateLable(lbBaseMHz, pPcbBase03.pFreqMHz.mStatus);
            pDataProcessing.UpdateLable(lbBaseKHz, pPcbBase03.pFreqKHz.mStatus);

            pDataProcessing.UpdateLable(lbSyncVolt3, pPcbSync08.pVolt3.mStatus);
            pDataProcessing.UpdateLable(lbSyncVolt5, pPcbSync08.pVolt5.mStatus);
            pDataProcessing.UpdateLable(lbSyncVolt48, pPcbSync08.pVolt48.mStatus);
            pDataProcessing.UpdateLable(lbSyncMHz, pPcbSync08.pFreqMHz.mStatus);
            pDataProcessing.UpdateLable(lbSyncKHz, pPcbSync08.pFreqKHz.mStatus);

            pDataProcessing.UpdateLable(lbEtagVolt3, pPcbEtag06.pVolt3.mStatus);
            pDataProcessing.UpdateLable(lbEtagCurSleep, pPcbEtag06.pCurSleepMode.mStatus);
            pDataProcessing.UpdateLable(lbEtagCurrTrans, pPcbEtag06.pCurTrasMode.mStatus);
        }

        private void btOpenHantek_Click(object sender, EventArgs e)
        {
            //pDataProcessing.OpenOscilloscope();
            mStatusConnectOsci = true;
            btCloseOsci.ForeColor = Color.Black;
            btOpenOsci.ForeColor = Color.Green;
        }

        private void btCloseOsci_Click(object sender, EventArgs e)
        {
            //pDataProcessing.CloseOscilloscope();
            mStatusConnectOsci = false;
            btCloseOsci.ForeColor = Color.Red;
            btOpenOsci.ForeColor = Color.Black;
        }
    }
}
