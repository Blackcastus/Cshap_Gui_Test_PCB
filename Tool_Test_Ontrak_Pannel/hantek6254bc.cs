using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Tool_Test_Ontrak_Pannel.hantek6254bc;
using System.Runtime.InteropServices;
using WORD = System.UInt16; // WORD = unsigned short (16-bit)

namespace Tool_Test_Ontrak_Pannel
{
    public class hantek6254bc
    {
        // define struct
        public struct stRELAYCONTROL
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public bool[] bCHEnable;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public ushort[] nCHVoltDIV;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public ushort[] nCHCoupling;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public bool[] bCHBWLimit;
            public ushort nTrigSource;
            public bool bTrigFilt;
            public ushort nALT;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct stDATACONTROL
        {
            public ushort nCHSet;
            public ushort nTimeDIV;
            public ushort nTriggerSource;
            public ushort nHTriggerPos;
            public ushort nVTriggerPos;
            public ushort nTriggerSlope;
            public uint nBufferLen;
            public uint nReadDataLen;
            public uint nAlreadyReadLen;
            public ushort nALT;
            public ushort nETSOpen;
            public ushort nDriverCode;
            public uint nLastAddress;
            public ushort nFPGAVersion;
        }

        // implement object
        private stDATACONTROL stDataControl;
        private stRELAYCONTROL rcRelayControl;

        // extern function
        // Load the DLL path
        const string HTHardDllPath = @"D:\4_HienPham\Import_Dll_Lib\Dll\x64\HTHardDll.dll";
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSearchDevice(WORD[] deviceArray);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]

        public static extern WORD dsoInitHard(WORD deviceIndex);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]

        public static extern ulong ddsSetCmd(WORD deviceIndex, WORD nControl);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]

        public static extern WORD ddsSDKSetWaveType(WORD deviceIndex, WORD nType);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern float ddsSDKSetFre(WORD deviceIndex, float nType);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD ddsSDKSetAmp(WORD deviceIndex, WORD nAmp);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern short ddsSDKSetOffset(WORD deviceIndex, short nOffset);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern short ddsSetOnOff(WORD deviceIndex, short nOnOff);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTADCCHModGain(WORD deviceIndex, WORD nCHMod);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSetSampleRate(WORD deviceIndex, WORD nYTFormat, stRELAYCONTROL pRelayControl, stDATACONTROL pControl);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSetCHAndTrigger(WORD deviceIndex, stRELAYCONTROL pRelayControl, WORD nTimeDIV);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSetRamAndTrigerControl(WORD deviceIndex, WORD nTimeDiv, WORD nCHset, WORD nTrigerSource, WORD nPeak);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSetCHPos(WORD deviceIndex, WORD nVoltDIV, WORD nPos, WORD nCH, WORD nCHMode);
        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSetVTriggerLevel(WORD deviceIndex, WORD nPos, WORD nSensitive);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTSetTrigerMode(WORD deviceIndex, WORD nTriggerMode, WORD nTriggerSlop, WORD ntriggerCouple);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTStartCollectData(WORD deviceIndex, WORD nStartControl);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTGetState(WORD deviceIndex);

        [DllImport(HTHardDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD dsoHTGetData(WORD deviceIndex, WORD[] pCH1Data, WORD[] pCH2Data, WORD[] pCH3Data, WORD[] pCH4Data, stDATACONTROL pControl);

        const string HTMeanDllPath = @"D:\4_HienPham\Import_Dll_Lib\Dll\x64\MeasDll.dll";

        [DllImport(HTMeanDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD PreMeas(short[] pMaxData, short[] pMinData, short[] pSrcData, ulong nSrcDataLen);
        [DllImport(HTMeanDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern WORD FindPeriod(ulong[] PeriodInfo, short[] pMaxData, short[] pMinData, short[] pSrcData, ulong nSrcDataLen);

        [DllImport(HTMeanDllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double CalFrequency(ulong[] PeriodInfo, double dbTimeInterval);


        // define variable readonly
        // OSCILLOSCOPE
        static readonly ushort PROBE_MULTIPLIER = 1; // # 1 or 10 x probe
        static readonly ushort ADC_CHANNEL_MODE = 4; // #1, 2 or 4
        static readonly int[] ENABLED_CHANNELS = { 1, 0, 0, 0 };
        static readonly ushort CHANNEL_COUPLING = 0; // # DC=0, AC=1
        static readonly ushort CHANS_MASK = 0x0F;

        // SIGNAL GENERATOR
        static readonly ushort FREQUENCY = 17000; //# Hz
        static readonly ushort AMPLITUDE = 1000; //# mV-peak
        static readonly short OFFSET = 0; //# mV
        static readonly ushort WAVE_TYPE = 0; //#0=sine, 1=ramp, 2=square, 4=DC, 8=noise
        static readonly ushort WAVE_MODE = 0; //#0=continuous wave, 1=single wave

        static readonly ushort TRIGGER_CHANNEL = 0; // #CH1=0, CH2=1, CH3=2, CH4=3
        static readonly ushort TRIGGER_SLOPE = 1; // # rising=0
        static readonly WORD TRIGGER_MODE = 0; // # edge=0
        static readonly WORD TRIGGER_SWEEP = 0; // # Auto trigger
        static readonly int TRIGGER_COUPLE = 0; // # DC=0, AC=1
        static readonly ushort TRIGGER_V = 0; // # Trigger Voltage (vertical)

        // #0=2nS, 1=5nS, 2=10nS, 3=20nS, 4=50nS, 5=100nS, 6=200nS, 7=500nS, 8=1uS, 9=2uS, 10=5uS, 11=10uS, 12=20uS, 13=50uS, 14=100uS, 15=200uS, 16=500uS 
        // #17=1mS, 18=2mS, 19=5mS, 20=10mS, 21=20mS, 22=50mS, 23=100mS, 24=200mS, 25=500mS, 26=1S, 27=2S, 28=5S, 29=10S, 30=20S
        // #31=50S, 32=100S, 33=200S, 34=500S, 35=1000S
        static readonly ushort TIME_PER_DIVISION = 10;
        static readonly double[] TIME_MULT = { 2E-9, 5E-9, 1E-8, 2E-8, 5E-8, 1E-7, 2E-7, 5E-7, 1E-6, 2E-6, 5E-6, 1E-5, 2E-5, 5E-5, 1E-4, 2E-4, 5E-4, 1E-3, 2E-3, 5E-3, 1E-2, 2E-2, 5E-2, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
        static readonly double[] SAMPLING_RATE_SINGLE = { 1E9, 1E9, 1E9, 1E9, 1E9, 1E9, 1E9, 500E6, 250E6, 125E6, 50E6, 25E6, 12.5E6, 5E6, 2.5E6, 1.25E6, 500E3, 250E3, 125E3, 50E3, 25E3, 12.5E3, 5E3, 2.5E3, 1.25E3, 500, 250, 125, 50, 25, 12.5, 5, 2.5, 1.25, 0.5, 0.25 };
        static readonly double[] SAMPLING_RATE_DUAL = { 500E6, 500E6, 500E6, 500E6, 500E6, 500E6, 500E6, 500E6, 250E6, 125E6, 50E6, 25E6, 12.5E6, 5E6, 2.5E6, 1.25E6, 500E3, 250E3, 125E3, 50E3, 25E3, 12.5E3, 5E3, 2.5E3, 1.25E3, 500, 250, 125, 50, 25, 12.5, 5, 2.5, 1.25, 0.5, 0.25 };
        static readonly double[] SAMPLING_RATE_QUAD = { 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 250E6, 125E6, 50E6, 25E6, 12.5E6, 5E6, 2.5E6, 1.25E6, 500E3, 250E3, 125E3, 50E3, 25E3, 12.5E3, 5E3, 2.5E3, 1.25E3, 500, 250, 125, 50, 25, 12.5, 5, 2.5, 1.25, 0.5, 0.25 };
        // #0=2mV, 1=5mV, 2=10mV, 3=20mV, 4=50mV, 5=100mV, 6=200mV, 7=500mV, 8=1V, 9=2V, 10=5V, 11=10V (w/ x1 probe)
        static readonly WORD VOLTS_PER_DIVISION = 8;
        static readonly double[] VOLT_MULT = { 0.002, 0.005, 0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10 };
        static readonly int VOLT_DIVISIONS = 8;
        static readonly int VOLT_RESOLUTION = 256; // #8 bit ADC

        static readonly WORD[] CH_ZERO_POS = { 128, 128, 128, 128 }; // # vertical zero position 0-255 [CH1, CH2, CH3, CH4]

        static readonly WORD YTFormat = 0; // # YT Mode
        static readonly WORD collect = 1;

        // define global variable
        private double mFrequency;
        static int mStartControl;
        private WORD mDeviceIndex;
        public void ResetValue()
        {
            mFrequency = 0;
        }
        public void InitHantek()
        {

        }

        public void ReadData()
        {

        }

        public void CollectData()
        {

        }

        public void CalcFrequency()
        {

        }

        public double GetFreq() => mFrequency;
    }
}
