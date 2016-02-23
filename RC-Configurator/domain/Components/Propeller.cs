using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Components
{
    public class Propeller : Component
    {

        public string name;
        public int bladeLength;
        public decimal bladePitch;
        public int bladeCount;

        public Propeller(string name, double weight, int bladeLength, decimal bladePitch, int bladeCount)
        {
            this.name = name;
            this.weight = weight;
            this.bladeLength = bladeLength;
            this.bladePitch = bladePitch;
            this.bladeCount = bladeCount;          
        }
    }
}
