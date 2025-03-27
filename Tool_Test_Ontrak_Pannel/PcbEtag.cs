using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Test_Ontrak_Pannel
{
    class PcbEtag
    {
        private double mVolt3v3;
        private double mCurrentSleepMode;
        private double mCurrentTransMode;

        public PcbEtag()
        {
            ResetVariable();
        }

        public void ResetVariable()
        {
            mVolt3v3 = 0;
            mCurrentSleepMode = 0;
            mCurrentTransMode = 0;
        }
        public void SetVolt3v3(double value) => mVolt3v3 = value;
        public void SetCurrentSleepMode(double value) => mCurrentSleepMode = value;
        public void SetCurrentTransMode(double value) => mCurrentTransMode = value;

        public double GetVolt3v3() => mVolt3v3;
        public double GetCurrentSleepMode() => mCurrentSleepMode;
        public double GetCurrentTransMode() => mCurrentTransMode;
    }
}
