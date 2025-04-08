using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Test_Ontrak_Pannel
{
    class PcbEtag
    {
        public DataStructure pVolt3;
        public DataStructure pCurSleepMode;
        public DataStructure pCurTrasMode;
        public PcbEtag()
        {
            pVolt3 = new DataStructure();
            pCurSleepMode = new DataStructure();
            pCurTrasMode = new DataStructure();
        }

        public void ResetValue()
        {
            pVolt3.SetParam(0, "", false);
            pCurSleepMode.SetParam(0, "", false);
            pCurTrasMode.SetParam(0, "", false);
        }
    }
}
