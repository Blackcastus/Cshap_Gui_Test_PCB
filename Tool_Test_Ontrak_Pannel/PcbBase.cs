using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Test_Ontrak_Pannel
{
    public partial class PcbBase
    {
        public DataStructure pVolt3;
        public DataStructure pVolt5;
        public DataStructure pCurrent;
        public DataStructure pFreqMHz;
        public DataStructure pFreqKHz;
        public PcbBase()
        {
            pVolt3 = new DataStructure();
            pVolt5 = new DataStructure();
            pCurrent = new DataStructure();
            pFreqMHz = new DataStructure();
            pFreqKHz = new DataStructure();

        }
        public void ResetValue()
        {
            pVolt3.SetParam(0, "", false);
            pVolt5.SetParam(0, "", false);
            pCurrent.SetParam(0, "", false);
            //pFreqMHz.SetParam(0, "", false);
            //pFreqKHz.SetParam(0, "", false);
        }
    }
}
