using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Components
{
   public class Motor : Component
    {
        public string name;
        public int kV;
        public int maxCurrent;
        public int maxVoltage;
        public int maxPower;
        public string minCell;
        public string maxCell;
        public int requiredESC;

        private enum type { Outrunner, Inrunner};


        public Motor (string name, int weight, int kV, int maxCurrent, int maxVoltage, int maxPower, string minCell, string maxCell, int requiredESC)
        {
            this.name = name;
            this.weight = weight;
            this.kV = kV;
            this.maxCurrent = maxCurrent;
            this.maxVoltage = maxVoltage;
            this.maxPower = maxPower;
            this.minCell = minCell;
            this.maxCell = maxCell;
            this.requiredESC = requiredESC;
        }

    }
}
