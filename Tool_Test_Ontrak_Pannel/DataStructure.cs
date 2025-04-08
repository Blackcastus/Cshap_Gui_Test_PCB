using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Web.UI.WebControls;

namespace Tool_Test_Ontrak_Pannel
{
    public class DataStructure
    {
        public double mValue { get; set; }
        public string mUnit { get; set; }
        public bool mStatus { get; set; }

        public DataStructure()
        {
            mValue = 0;
            mUnit = "";
            mStatus = false;
        }
        public void SetParam(double value, string unit, bool status)
        {
            mValue = value;
            mUnit = unit;
            mStatus = status;
        }
    }
}
