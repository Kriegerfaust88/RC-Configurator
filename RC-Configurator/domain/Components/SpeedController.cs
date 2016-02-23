using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Components
{
    public class SpeedController : Component
    {
        public string name;
        public int constCurrent;
        public int burstCurrent;
        public string minCell;
        public string maxCell;
        public string circuitType;


        public SpeedController(string name, double weight, int constCurrent, int burstCurrent, string minCell, string maxCell, string circuitType)
        {
            this.name = name;
            this.weight = weight;
            this.constCurrent = constCurrent;
            this.burstCurrent = burstCurrent;
            this.minCell = minCell;
            this.maxCell = maxCell;
            this.circuitType = circuitType;
        }


    }
}
