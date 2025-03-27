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
        }

        // Getter value each value
        public double GetVolt3V3() => mVolt3v3;
        public double GetVolt5V() => mVolt5v;
        public double GetCurrent() => mCurrent;
        public double GetSync384() => mSync384;
        public double GetSync2() => mSync2;

        // Setter - Cập nhật giá trị
        public void SetVolt3V3(double value) => mVolt3v3 = value;
        public void SetVolt5V(double value) => mVolt5v = value;
        public void SetCurrent(double value) => mCurrent = value;
        public void SetSync384(double value) => mSync384 = value;
        public void SetSync2(double value) => mSync2 = value;

    }
}
