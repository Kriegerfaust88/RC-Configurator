using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain
{
    public class Battery : Component
    {
        public string name;
        public int capacity { get; set; }
        public String configuration { get; set; }
        public int discharge { get; set; }
        public int peakDischarge { get; set; }



        public Battery(string name, int weight, int capacity, String configuration, int discharge, int peakDischarge)
        {
            this.name = name;
            this.weight = weight;
            this.capacity = capacity;
            this.configuration = configuration;
            this.discharge = discharge;
            this.peakDischarge = peakDischarge;

        }



    }
}
