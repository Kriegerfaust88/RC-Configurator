using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database.Table_Managers
{
    public abstract class TableManager
    {

        public abstract void update();
        public abstract void save();
        public abstract void remove();

    }
}
