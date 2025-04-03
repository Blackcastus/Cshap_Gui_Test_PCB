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

        //public struct RELAYCONTROL
        //{
        //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //    public bool[] bCHEnable;
        //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //    public ushort[] nCHVoltDIV;
        //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //    public ushort[] nCHCoupling;
        //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //    public bool[] bCHBWLimit;
        //    public ushort nTrigSource;
        //    public bool bTrigFilt;
        //    public ushort nALT;
        //}

        //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        //public struct DATACONTROL
        //{
        //    public ushort nCHSet;
        //    public ushort nTimeDIV;
        //    public ushort nTriggerSource;
        //    public ushort nHTriggerPos;
        //    public ushort nVTriggerPos;
        //    public ushort nTriggerSlope;
        //    public uint nBufferLen;
        //    public uint nReadDataLen;
        //    public uint nAlreadyReadLen;
        //    public ushort nALT;
        //    public ushort nETSOpen;
        //    public ushort nDriverCode;
        //    public uint nLastAddress;
        //    public ushort nFPGAVersion;
        //}

        //private DATACONTROL stDataControl;
        //private RELAYCONTROL rcRelayControl;
        // Load the DLL
        //const string HTHardDllPath = @"D:\4_HienPham\Import_Dll_Lib\Dll\x64\HTHardDll.dll";
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSearchDevice(WORD[] deviceArray);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]

        //public static extern WORD dsoInitHard(WORD deviceIndex);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]

        //public static extern ulong ddsSetCmd(WORD deviceIndex, WORD nControl);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]

        //public static extern WORD ddsSDKSetWaveType(WORD deviceIndex, WORD nType);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern float ddsSDKSetFre(WORD deviceIndex, float nType);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD ddsSDKSetAmp(WORD deviceIndex, WORD nAmp);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern short ddsSDKSetOffset(WORD deviceIndex, short nOffset);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern short ddsSetOnOff(WORD deviceIndex, short nOnOff);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTADCCHModGain(WORD deviceIndex, WORD nCHMod);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSetSampleRate(WORD deviceIndex, WORD nYTFormat, RELAYCONTROL pRelayControl, DATACONTROL pControl);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSetCHAndTrigger(WORD deviceIndex,RELAYCONTROL pRelayControl, WORD nTimeDIV);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSetRamAndTrigerControl(WORD deviceIndex, WORD nTimeDiv, WORD nCHset, WORD nTrigerSource, WORD nPeak);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSetCHPos(WORD deviceIndex, WORD nVoltDIV, WORD nPos, WORD nCH, WORD nCHMode);
        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSetVTriggerLevel(WORD deviceIndex, WORD nPos, WORD nSensitive);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTSetTrigerMode(WORD deviceIndex, WORD nTriggerMode, WORD nTriggerSlop, WORD ntriggerCouple);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTStartCollectData(WORD deviceIndex, WORD nStartControl);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTGetState(WORD deviceIndex);

        //[DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD dsoHTGetData(WORD deviceIndex, WORD[] pCH1Data, WORD[] pCH2Data, WORD[] pCH3Data, WORD[] pCH4Data, DATACONTROL pControl);

        //const string HTMeanDllPath = @"D:\4_HienPham\Import_Dll_Lib\Dll\x64\MeasDll.dll";

        //[DllImport(HTMeanDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD PreMeas(short[] pMaxData, short[] pMinData, short[] pSrcData, ulong nSrcDataLen);
        //[DllImport(HTMeanDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern WORD FindPeriod(ulong[] PeriodInfo, short[] pMaxData, short[] pMinData, short[] pSrcData, ulong nSrcDataLen);

        //[DllImport(HTMeanDllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern double CalFrequency(ulong[] PeriodInfo,double dbTimeInterval);


        //// OSCILLOSCOPE
        //static readonly ushort PROBE_MULTIPLIER = 1; // # 1 or 10 x probe
        //static readonly ushort ADC_CHANNEL_MODE = 4; // #1, 2 or 4
        //static readonly int[] ENABLED_CHANNELS = { 1, 0, 0, 0 };
        //static readonly ushort CHANNEL_COUPLING = 0; // # DC=0, AC=1
        //static readonly ushort CHANS_MASK = 0x0F;

        //// SIGNAL GENERATOR
        //static readonly ushort FREQUENCY = 17000; //# Hz
        //static readonly ushort AMPLITUDE = 1000; //# mV-peak
        //static readonly short OFFSET = 0; //# mV
        //static readonly ushort WAVE_TYPE = 0; //#0=sine, 1=ramp, 2=square, 4=DC, 8=noise
        //static readonly ushort WAVE_MODE = 0; //#0=continuous wave, 1=single wave

        //static readonly ushort TRIGGER_CHANNEL = 0; // #CH1=0, CH2=1, CH3=2, CH4=3
        //static readonly ushort TRIGGER_SLOPE = 1; // # rising=0
        //static readonly WORD TRIGGER_MODE = 0; // # edge=0
        //static readonly WORD TRIGGER_SWEEP = 0; // # Auto trigger
        //static readonly int TRIGGER_COUPLE = 0; // # DC=0, AC=1
        //static readonly ushort TRIGGER_V = 0; // # Trigger Voltage (vertical)

        //// #0=2nS, 1=5nS, 2=10nS, 3=20nS, 4=50nS, 5=100nS, 6=200nS, 7=500nS, 8=1uS, 9=2uS, 10=5uS, 11=10uS, 12=20uS, 13=50uS, 14=100uS, 15=200uS, 16=500uS 
        //// #17=1mS, 18=2mS, 19=5mS, 20=10mS, 21=20mS, 22=50mS, 23=100mS, 24=200mS, 25=500mS, 26=1S, 27=2S, 28=5S, 29=10S, 30=20S
        //// #31=50S, 32=100S, 33=200S, 34=500S, 35=1000S
        //static readonly ushort TIME_PER_DIVISION = 10;
        //static readonly double[] TIME_MULT = { 2E-9, 5E-9, 1E-8, 2E-8, 5E-8, 1E-7, 2E-7, 5E-7, 1E-6, 2E-6, 5E-6, 1E-5, 2E-5, 5E-5, 1E-4, 2E-4, 5E-4, 1E-3, 2E-3, 5E-3, 1E-2, 2E-2, 5E-2, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
        //static readonly double[] SAMPLING_RATE_SINGLE = { 1E9, 1E9, 1E9, 1E9, 1E9, 1E9, 1E9, 500E6, 250E6, 125E6, 50E6, 25E6, 12.5E6, 5E6, 2.5E6, 1.25E6, 500E3, 250E3, 125E3, 50E3, 25E3, 12.5E3, 5E3, 2.5E3, 1.25E3, 500, 250, 125, 50, 25, 12.5, 5, 2.5, 1.25, 0.5, 0.25 };
        //static readonly double[] SAMPLING_RATE_DUAL = { 500E6, 500E6, 500E6, 500E6, 500E6, 500E6, 500E6, 500E6, 250E6, 125E6, 50E6, 25E6, 12.5E6, 5E6, 2.5E6, 1.25E6, 500E3, 250E3, 125E3, 50E3, 25E3, 12.5E3, 5E3, 2.5E3, 1.25E3, 500, 250, 125, 50, 25, 12.5, 5, 2.5, 1.25, 0.5, 0.25 };
        //static readonly double[] SAMPLING_RATE_QUAD = {250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 125E6, 50E6, 25E6, 12.5E6, 5E6, 2.5E6, 1.25E6, 500E3, 250E3, 125E3, 50E3, 25E3, 12.5E3, 5E3, 2.5E3, 1.25E3, 500, 250, 125, 50, 25, 12.5, 5, 2.5, 1.25, 0.5, 0.25} ;
        //// #0=2mV, 1=5mV, 2=10mV, 3=20mV, 4=50mV, 5=100mV, 6=200mV, 7=500mV, 8=1V, 9=2V, 10=5V, 11=10V (w/ x1 probe)
        //static readonly WORD VOLTS_PER_DIVISION = 8;
        //static readonly double[] VOLT_MULT = { 0.002, 0.005, 0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10 };
        //static readonly int VOLT_DIVISIONS = 8;
        //static readonly int VOLT_RESOLUTION = 256; // #8 bit ADC

        //static readonly WORD[] CH_ZERO_POS = { 128, 128, 128, 128 }; // # vertical zero position 0-255 [CH1, CH2, CH3, CH4]

        //static readonly WORD YTFormat = 0; // # YT Mode
        //static readonly WORD collect = 1;
        //static int nStartControl = 0;

        //private WORD nDeviceIndex;
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

            
            nStartControl = nStartControl + (TRIGGER_SWEEP == 0? 1: 0);
            nStartControl = nStartControl + (YTFormat == 0? 0 : 2);
            nStartControl = nStartControl + (collect == 1? 0 : 4);

            //################################################
            //# Initialize variables HANTEK 6254BC
            //################################################
            rcRelayControl = new RELAYCONTROL
            {
                bCHEnable = new bool[4] { true, false, false, false },
                nCHVoltDIV = new ushort[4] { (ushort)VOLTS_PER_DIVISION, (ushort)VOLTS_PER_DIVISION, (ushort)VOLTS_PER_DIVISION, (ushort)VOLTS_PER_DIVISION },
                nCHCoupling = new ushort[4] { CHANNEL_COUPLING, CHANNEL_COUPLING, CHANNEL_COUPLING, CHANNEL_COUPLING }, // DC coupling
                bCHBWLimit = new bool[4] { false, false, false, false },
                nTrigSource = TRIGGER_CHANNEL,
                bTrigFilt = false, // #Whether to enable 20M filtering
                nALT = 0 // #Whether to trigger alternately. Note that alternate triggering is a software function
            };

            stDataControl = new DATACONTROL
            {
                nCHSet = CHANS_MASK,
                nTimeDIV = TIME_PER_DIVISION, // Example value for TIME_PER_DIVISION
                nTriggerSource = TRIGGER_CHANNEL,
                nHTriggerPos = 50,
                nVTriggerPos = TRIGGER_V, // Trigger voltage (TRIGGER_V)
                nTriggerSlope = TRIGGER_SLOPE,
                nBufferLen = 4096, // # the length of the collected data
                nReadDataLen = 4096, // # the length of the read data
                nAlreadyReadLen = 0,
                nALT = 0
            };
            ushort[] deviceArray = new ushort[32];
            ushort deviceIndex = 0;

            //################################################
            //# Search Device via USB
            //################################################
            double dresult = dsoHTSearchDevice(deviceArray);
            if(dresult == 0)
            {
                Console.WriteLine("Device not found!");
            }
            else
            {
                for (ushort i = 0; i < 32; i++)
                {
                    if (deviceArray[i] != 0)
                    {
                        deviceIndex = i;
                        nDeviceIndex = i;
                        break;
                    }
                }
                Console.WriteLine("Device ID is: " + deviceIndex);
            }

            dresult = dsoInitHard(deviceIndex);
            Console.WriteLine("deviceIndex: " + dresult);
            //################################################
            //# INITIALIZE FUNCTION GENERATOR (DDS)
            //################################################

            ulong ulSetCmd = ddsSetCmd(deviceIndex, WAVE_MODE);
            Console.WriteLine("ddsSetCmd: " + ulSetCmd);

            WORD wresult = ddsSDKSetWaveType(deviceIndex, WAVE_TYPE);
            Console.WriteLine("ddsSDKSetWaveType: " + wresult);

            float fresult = ddsSDKSetFre(deviceIndex, FREQUENCY);
            Console.WriteLine("ddsSDKSetFre: " + fresult);

            wresult = ddsSDKSetAmp(deviceIndex, AMPLITUDE);
            Console.WriteLine("ddsSDKSetAmp: " + wresult);

            short shresult = ddsSDKSetOffset(deviceIndex, OFFSET);
            Console.WriteLine("ddsSDKSetOffset: " + shresult);

            shresult = ddsSetOnOff(deviceIndex, 1);
            Console.WriteLine("ddsSDKSetOffset: " + shresult);

            Console.WriteLine("Completed DDS Configuration");

            //################################################
            //# INITIALIZE FUNCTION GENERATOR (DSO)
            //################################################

            wresult = dsoHTADCCHModGain(deviceIndex, 4);
            Console.WriteLine("dsoHTADCCHModGain: " + wresult);

            wresult = dsoHTSetSampleRate(deviceIndex, YTFormat, rcRelayControl, stDataControl);
            Console.WriteLine("dsoHTSetSampleRate: " + wresult);

            wresult = dsoHTSetCHAndTrigger(deviceIndex, rcRelayControl, stDataControl.nTimeDIV);
            Console.WriteLine("dsoHTSetCHAndTrigger: " + wresult);

            wresult = dsoHTSetRamAndTrigerControl(deviceIndex, stDataControl.nTimeDIV, stDataControl.nCHSet, stDataControl.nTriggerSource, 0);// #Set the trigger source
            Console.WriteLine("dsoHTSetRamAndTrigerControl: " + wresult);

            for (int i = 0; i < 4; i++)
            {
                dsoHTSetCHPos(deviceIndex, rcRelayControl.nCHVoltDIV[i], CH_ZERO_POS[i], (WORD)i, ADC_CHANNEL_MODE);
                Console.WriteLine("rcRelayControl.nCHVoltDIV[i]= " + rcRelayControl.nCHVoltDIV[i]);
                Console.WriteLine("dsoHTSetCHPos: " + rcRelayControl.nCHVoltDIV[i] + " CH " + i + 1);
            }
            wresult = dsoHTSetVTriggerLevel(deviceIndex, stDataControl.nVTriggerPos, 4);
            Console.WriteLine("dsoHTSetVTriggerLevel = " + wresult);

            dsoHTSetTrigerMode(deviceIndex, TRIGGER_MODE, stDataControl.nTriggerSlope, 0);
            Console.WriteLine("dsoHTSetTrigerMode = " + wresult);

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
                        //tbDebug.Text = "Connected with " + cboCom.Text;

                        lbComStatus.Text = "Connected";
                        lbComStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        //tbDebug.Text = "Disconnected with " + cboCom.Text;

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

        private void btStartOsc_Click(object sender, EventArgs e)
        {
            //################################################
            //# COLLECT DATA
            //################################################
            WORD wresult = dsoHTStartCollectData(nDeviceIndex, (WORD)nStartControl);
            Console.WriteLine("dsoHTStartCollectData = " + wresult);
            Console.WriteLine("Waiting for measurement to complete");

            while(((dsoHTGetState(nDeviceIndex) & 2) == 0))
            {
                Task.Delay(100);
            }
            Console.WriteLine("Data is ready to read, READING DATA");
            //################################################
            //# READ DATA
            //################################################

            WORD[] CH1ReadData = new WORD[4096];
            WORD[] CH2ReadData = new WORD[4096];
            WORD[] CH3ReadData = new WORD[4096];
            WORD[] CH4ReadData = new WORD[4096];
            double[] timeData = new double[4096];
            double[] CH1SrcVoltData = new double[4096];
            short[] pMaxData = new short[5];
            short[] pMinData = new short[5];
            short[] pSrcData = new short[4096];
            ulong[] PeriodInfo = new ulong[4096];
            double dbInterVal = 0.8E-6;

            wresult = dsoHTGetData(nDeviceIndex, CH1ReadData, CH2ReadData, CH3ReadData, CH4ReadData, stDataControl);
            Console.WriteLine("dsoHTGetData = " + wresult);

            if (wresult == 1)
            {
                for (int i = 0; i < stDataControl.nReadDataLen; i++)
                {
                    //# Calculate Time Points
                    double curSampleRate = 0;
                    if (ADC_CHANNEL_MODE == 1)
                    {
                        curSampleRate = SAMPLING_RATE_SINGLE[TIME_PER_DIVISION];
                    }
                    else if (ADC_CHANNEL_MODE == 2)
                    {
                        curSampleRate = SAMPLING_RATE_DUAL[TIME_PER_DIVISION];
                    }
                    else if (ADC_CHANNEL_MODE == 4)
                    {
                        curSampleRate = SAMPLING_RATE_QUAD[TIME_PER_DIVISION];
                    }
                    else
                    {
                        Console.WriteLine("ADC_CHANNEL_MODE can only be 1, 2 or 4, aborting");
                    }

                    timeData[i] = (ushort)(i / curSampleRate);
                    CH1SrcVoltData[i] = (CH1ReadData[i] - (255 - CH_ZERO_POS[0])) * PROBE_MULTIPLIER * VOLT_MULT[VOLTS_PER_DIVISION] * VOLT_DIVISIONS / 256;
                    pSrcData[i] = (short)(CH1ReadData[i] - 64);
                }

                PreMeas(pMaxData, pMinData, pSrcData, 4096);
                FindPeriod(PeriodInfo, pMaxData, pMinData, pSrcData, 4096);
                double freq = CalFrequency(PeriodInfo, dbInterVal);

                tboFreq.Text = freq.ToString();
            }

        }
    }
}
