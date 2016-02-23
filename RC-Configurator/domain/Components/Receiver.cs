using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Components
{
    public class Receiver : Component
    {
        public string name;
        public int channelCount;
        public int minVoltage;
        public int maxVoltage;   

        public Receiver(string name, double weight, int channelCount, int minVoltage, int maxVoltage)
        {
            this.name = name;
            this.weight = weight;
            this.channelCount = channelCount;
            this.minVoltage = minVoltage;
            this.maxVoltage = maxVoltage;
        }



    }
}
