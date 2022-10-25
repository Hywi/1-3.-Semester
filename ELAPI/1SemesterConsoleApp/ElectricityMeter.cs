using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1SemesterConsoleApp
{
    public class ElectricityMeter
    {
        public long MeterId { get; set; }

        public DateTime FromTimeDate { get; set; }

        public DateTime ToTimeDate { get; set; }

        public double Value { get; set; }

        public double ElspotPrice { get; set; }

        public double TotalPrice { get; set; }

        public void ReadElectricityMeter()
        {

        }
}
}
