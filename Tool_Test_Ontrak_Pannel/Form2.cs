using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Tool_Test_Ontrak_Pannel
{
    public partial class fOscilloscope : Form
    {
        private Hantek6254BC mhantek;
        ChartArea chartArea;
        Series series;
        private bool mIsConnected = false;
        private readonly string[] mTimePerDev = {"2 nS", "5 nS", "10 nS", "20 nS", "50 nS","100 nS","200 nS","500 nS","1 uS","2 uS", "5 uS", "10 uS", "20 uS", "50 uS", "100 uS", "200 uS", "500 uS",
                                                "1 mS", "2 mS", "5 mS", "10 mS", "20 mS", "50 mS", "100 mS", "200 mS", "500 mS", "1 S", "2 S", "5 S", "10 S", "20 S",
                                                "50 S", "100 S", "200 S", "500 S", "1000 S"};
        private readonly string[] mVolt = { "2mV", "5mV", "10mV", "20mV", "50mV", "100mV", "200mV", "500mV", "1V", "2V", "5V", "10V" };
        private readonly string[] mFormat = { "Y - T", "X - Y"};
        private readonly string[] mChannelSelect = { "CH1", "CH2", "CH3", "CH4" };
        private readonly string[] mVoltType = { "DC", "AC" };
        private readonly string[] mScale = { "x1", "x10", "x100", "x1000", "x10000" };
        private readonly string[] mTriggerMode = { "Edge", "Pule", "Video", "Can", "Lin", "Uart", "SPI", "I2C" };
        private readonly string[] mTriggerSweep  = { "AUTO", "NORMAL", "SINGLE"};
        private readonly string[] mTriggerSource = { "CH1", "CH2", "CH3", "CH4" };
        private readonly string[] mTrigerSlope = { "+", "-" };
        public fOscilloscope()
        {
            InitializeComponent();
            InitChart();
            InitializeTimer();

            mhantek = new Hantek6254BC();

            // Setting Oscilloscope
            cbTime_Div.Items.AddRange(mTimePerDev);
            //cbTime_Div.SelectedIndex = 0;
            cbTime_Div.Text = "20 nS";
            cbFormat.Items.AddRange(mFormat);
            cbFormat.SelectedIndex = 0;
            cbChannel.Items.AddRange(mChannelSelect);
            cbChannel.SelectedIndex = 0;
            cbVolt.Items.AddRange(mVolt);
            //cbVolt.SelectedIndex = 0;
            cbVolt.Text = "2V";
            cbVoltType.Items.AddRange(mVoltType);
            cbVoltType.SelectedIndex = 0;
            cbScale.Items.AddRange(mScale);
            //cbScale.SelectedIndex = 0;
            cbScale.Text = "x10";
            cbTriggerMode.Items.AddRange(mTriggerMode);
            cbTriggerMode.SelectedIndex = 0;
            cbTriggerSweep.Items.AddRange(mTriggerSweep);
            cbTriggerSweep.SelectedIndex = 0;
            cbTriggerSource.Items.AddRange(mTriggerSource);
            cbTriggerSource.SelectedIndex = 0;
            cbTriggerSlope.Items.AddRange(mTrigerSlope);
            cbTriggerSlope.SelectedIndex = 0;
            checkboxOnOff.Checked = true;

            //GetSetingOsci();

            // Display Oscilloscope
            //tboVolt.Text = "0";
            tboFreq.Text = "0";
            tboDuty.Text = "0";
            tboPPulseWidth.Text = "0";
            tboNPulseWidth.Text = "0";
            tbVmax.Text = "0";
            tbVmin.Text = "0";
            tbVpp.Text = "0";
            tbPeriod.Text = "0";

        }

        private void InitChart()
        {
            chartArea = new ChartArea("MainChart");
            series = new Series("Voltage vs Time")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = System.Drawing.Color.Blue
            };
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chartArea.AxisX.Title = "Time (s)";
            chartArea.AxisY.Title = "Voltage (V)";

            //chartArea.AxisX.Minimum = 0;     
            //chartArea.AxisX.Maximum = 2;
            //chartArea.AxisY.Minimum = -4;    
            //chartArea.AxisY.Maximum = 4;     

            
            chart1.ChartAreas.Add(chartArea);

            

            series.Points.AddXY(0, 0);
            series.Points.AddXY(0.1, 0);

            chart1.Series.Add(series);
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 100; // Cập nhật mỗi 50ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(mIsConnected == true)
            {
                int result = mhantek.CollectData();
                if (result == 1)
                {
                    double freq = 0;
                    string freq_unit = "Hz";
                    if(mhantek.GetFreqCH1() < 1E3)
                    {
                        freq = mhantek.GetFreqCH1();// Hz
                    }
                    else if(mhantek.GetFreqCH1() < 1E6)
                    {
                        freq = mhantek.GetFreqCH1() / 1E3; // KHz
                        freq_unit = "KHz";
                    }
                    else if (mhantek.GetFreqCH1() < 1E9)
                    {
                        freq = mhantek.GetFreqCH1() / 1E6; // MHz
                        freq_unit = "MHz";

                    }
                    else if (mhantek.GetFreqCH1() < 1E9)
                    {
                        freq = mhantek.GetFreqCH1() / 1E6; // GHz
                        freq_unit = "GHz";
                    }
                    else
                    {
                        freq = mhantek.GetFreqCH1();
                        freq_unit = "...";
                    }
                    tboFreq.Text = freq.ToString("F2");
                    lbFreqUnit.Text = freq_unit.ToString(); 

                    tboDuty.Text = mhantek.GetPDutyCicleCH1().ToString("F2");
                    tboPPulseWidth.Text = mhantek.GetPPulseWidthCh1().ToString("F2");
                    tboNPulseWidth.Text = mhantek.GetNPulseWidthCh1().ToString("F2");
                    //tboVolt.Text = mhantek.GetVoltCH1().ToString();
                    tbVmax.Text = mhantek.GetVmaxCH1().ToString("F2");
                    tbVmin.Text = mhantek.GetVminCH1().ToString("F2");
                    tbVpp.Text = mhantek.GetVppCH1().ToString("F2");
                    tbPeriod.Text = mhantek.GetPeriodCH1().ToString();
                    Display_Chart();
                }
            }
            else
            {

            }    

        }

        private void Display_Chart()
        {
            // clean data old
            chart1.Series.Clear();
            //chart1.ChartAreas.Clear();
            chartArea = new ChartArea("MainChart");
            series = new Series("Voltage vs Time")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = System.Drawing.Color.Blue
            };
            // create new Series 
            //Series series = new Series("Voltage vs Time");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2; 
            series.Color = System.Drawing.Color.Blue; 

            // Add data to chart
            double[] realtime = new double[4096];
            double[] realvoltch1 = new double[4096];

            realtime = mhantek.GetTimeRate();
            realvoltch1 = mhantek.GetSrcVoltCH1();
            if (realtime == null || realvoltch1 == null || realtime.Length == 0)
            {
                return;
            }

            for (int i = 0; i < 1000; i++)
            {
                series.Points.AddXY(realtime[i], realvoltch1[i]);
            }

            // add Series to Chart
            double vertical = mhantek.GetVerticalChart();

            chart1.Series.Add(series);

            //chart1.ChartAreas[0].AxisX.Title = "Time (s)";
            //chart1.ChartAreas[0].AxisY.Title = "Voltage (V)";
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisX.Maximum = realtime[Math.Min(realtime.Length - 1, 4095)];
            chart1.ChartAreas[0].AxisX.Maximum = realtime[Math.Min(realtime.Length - 1, 25)];
            chart1.ChartAreas[0].AxisY.Minimum = -vertical;
            chart1.ChartAreas[0].AxisY.Maximum = vertical;

            // Zoom and AutoScroll
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            //mhantek.ResetValue();
        }
        private void btSwitchPannel_click(object sender, EventArgs e)
        {
            fMain_Pannel form1 = new fMain_Pannel();
            this.Hide();
            form1.ShowDialog();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            mIsConnected = mhantek.InitHantek();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            mIsConnected = mhantek.TurnOffHantel();
        }

        private void GetSetingOsci()
        {
            int value = 0;

            Dictionary<string, int> TimeDevMap = new Dictionary<string, int>();
            Dictionary<string, int> VoltMap = new Dictionary<string, int>();
            Dictionary<string, int> FormatMap = new Dictionary<string, int>();
            Dictionary<string, int> ChannelSelectMap = new Dictionary<string, int>();
            Dictionary<string, int> VoltTypeMap = new Dictionary<string, int>();
            Dictionary<string, int> ScaleMap = new Dictionary<string, int>();
            Dictionary<string, int> TriggerModeMap = new Dictionary<string, int>();
            Dictionary<string, int> TriggerSweepMap = new Dictionary<string, int>();
            Dictionary<string, int> TriggerSourceMap = new Dictionary<string, int>();
            Dictionary<string, int> TrigerSlopeMap = new Dictionary<string, int>();

            for (int i = 0; i < mTimePerDev.Length; i++)
            {
                TimeDevMap[mTimePerDev[i]] = i;
            }
            value = TimeDevMap[cbTime_Div.Text];
            mhantek.SetTIME_PER_DIVISION((ushort)value);

            for (int i = 0; i < mFormat.Length; i++)
            {
                FormatMap[mFormat[i]] = i;
            }
            value = FormatMap[cbFormat.Text];
            //mhantek.SetYT_FOMAT((ushort)value);

            for (int i = 0; i < mChannelSelect.Length; i++)
            {
                ChannelSelectMap[mChannelSelect[i]] = i;
            }
            value = ChannelSelectMap[cbChannel.Text];
            //mhantek.SetTRIGGER_CHANNEL((ushort)value);

            for (int i = 0; i < mVoltType.Length; i++)
            {
                VoltTypeMap[mVoltType[i]] = i;
            }

            value = VoltTypeMap[cbVoltType.Text];
            //mhantek.SetCHANNEL_COUPLING((ushort)value);

            for (int i = 0; i < mVolt.Length; i++)
            {
                VoltMap[mVolt[i]] = i;
            }
            value = VoltMap[cbVolt.Text];
            mhantek.SetVOLTS_PER_DIVISION((ushort)value);

            //for (int i = 0; i < mScale.Length; i++)
            //{
            //    ScaleMap[mScale[i]] = i;
            //}
            switch(cbScale.Text)
            {
                case "x1":
                    value = 1;
                    break;
                case "x10":
                    value = 10;
                    break;
                case "x100":
                    value = 100;
                    break;
                default:
                    value = 1;
                    break;
            }    
            //value = ScaleMap[cbScale.Text];
            //mhantek.SetPROBE_MULTIPLIER((ushort)value);


            for (int i = 0; i < mTriggerMode.Length; i++)
            {
                TriggerModeMap[mTriggerMode[i]] = i;
            }
            value = TriggerModeMap[cbTriggerMode.Text];
            //mhantek.SetTRIGGER_MODE((ushort)value);

            for (int i = 0; i < mTriggerSweep.Length; i++)
            {
                TriggerSweepMap[mTriggerSweep[i]] = i;
            }
            value = TriggerSweepMap[cbTriggerSweep.Text];
            //mhantek.SetTRIGGER_SWEEP((ushort)value);

            for (int i = 0; i < mTrigerSlope.Length; i++)
            {
                TrigerSlopeMap[mTrigerSlope[i]] = i;
            }
            value = TrigerSlopeMap[cbTriggerSlope.Text];
            //mhantek.SetTRIGGER_SLOPE((ushort)value);

            for (int i = 0; i < mTriggerSource.Length; i++)
            {
                TriggerSourceMap[mTriggerSource[i]] = i;
            }
            value = TriggerSourceMap[cbTriggerSource.Text];
            //mhantek.SetTRIGGER_COUPLE((ushort)value);


        }

        private void btSettingOsci_Click(object sender, EventArgs e)
        {
            //GetSetingOsci();
            //mhantek.InitHantek();
        }
    }
}
