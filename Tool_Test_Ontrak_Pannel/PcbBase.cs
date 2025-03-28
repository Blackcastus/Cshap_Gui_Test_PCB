using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Test_Ontrak_Pannel
{
    public partial class PcbBase
    {
        private double mVolt3v3;
        private double mVolt5v;
        private double mCurrent;
        private double mSync384;
        private double mSync2;
        private bool mIsVolt3v3;
        private bool mIsVolt5v;
        private bool mIsCurrent;
        private bool mIsSync384;
        private bool mIsSync2;
        public PcbBase()
        {
            ResetVariable();
        }

        public void ResetVariable()
        {
            mVolt3v3 = 0;
            mVolt5v = 0;
            mCurrent = 0;
            mSync384 = 0;
            mSync2 = 0;
            mIsVolt3v3 = false;
            mIsVolt5v = false;
            mIsCurrent = false;
            mIsSync384 = false;
            mIsSync2 = false;
        }

        // Setter - Cập nhật giá trị
        public void SetVolt3V3(double value) => mVolt3v3 = value;
        public void SetVolt5V(double value) => mVolt5v = value;
        public void SetCurrent(double value) => mCurrent = value;
        public void SetSync384(double value) => mSync384 = value;
        public void SetSync2(double value) => mSync2 = value;
        public void SetIsVolt3v3(bool value) => mIsVolt3v3 = value;
        public void SetIsVolt5v(bool value) => mIsVolt5v = value;
        public void SetIsCurrent(bool value) => mIsCurrent = value;
        public void SetIsSync384(bool value) => mIsSync384 = value;
        public void SetIsSync2(bool value) => mIsSync2 = value;
        // Getter value each value
        public double GetVolt3V3() => mVolt3v3;
        public double GetVolt5V() => mVolt5v;
        public double GetCurrent() => mCurrent;
        public double GetSync384() => mSync384;
        public double GetSync2() => mSync2;
        public bool GetIsVolt3v3() => mIsVolt3v3;
        public bool GetIsVolt5v() => mIsVolt5v;
        public bool GetIsCurrent() => mIsCurrent;
        public bool GetIsSync384() => mIsSync384;
        public bool GetIsSync2() => mIsSync2;


    }
}
