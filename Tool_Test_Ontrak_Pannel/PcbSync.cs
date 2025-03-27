using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Test_Ontrak_Pannel
{
    public class PcbSync
    {
        private double mVolt3v3;
        private double mVolt5v;
        private double mVolt48v;
        private double mSync384;
        private double mSync2;

        public PcbSync()
        {
            ResetVariable();
        }

        public void ResetVariable()
        {
            mVolt3v3 = 0;
            mVolt5v = 0;
            mVolt48v = 0;
            mSync384 = 0;
            mSync2 = 0;
        }
        public void setVolt3v3(double value) => mVolt3v3 = value;
        public void setVolt5v(double value) => mVolt5v = value;
        public void setVolt48v(double value) => mVolt48v = value;
        public void setSync384(double value) => mSync384 = value;
        public void setSync2(double value) => mSync2 = value;

        public double GetVolt3v3() => mVolt3v3;
        public double GetVolt5v() => mVolt5v;
        public double GetVolt48v() => mVolt48v;
        public double GetSync384() => mSync384;
        public double GetSync2() => mSync2;
    }
}
