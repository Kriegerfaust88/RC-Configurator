using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Components
{
    public class Servo : Component
    {
        public string name;
        public int minVoltage;
        public int maxVoltage;


        public Servo (string name, double weight, int minVoltage, int maxVoltage)
        {
            this.weight = weight;
            this.name = name;
            this.minVoltage = minVoltage;
            this.maxVoltage = maxVoltage;
        }

    }
}
