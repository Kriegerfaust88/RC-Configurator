using RC_Configurator.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Socket
{
    public interface ISocket
    {
        void move(int newXCoord, int newYCoord);
        void bindComponent(Component component);
        Component getComponent();
        int getXCoord();
        int getYCoord();
        void lockSocket();

    }
}
