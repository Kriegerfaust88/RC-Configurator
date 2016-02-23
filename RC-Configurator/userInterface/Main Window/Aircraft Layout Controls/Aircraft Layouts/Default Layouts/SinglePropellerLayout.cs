using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls;
using RC_Configurator.userInterface.User_Controls;
using RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Socket.Sockets;
using RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Socket;

namespace RC_Configurator.userInterface.Main_Window.Aircraft_Layout_Controls.Aircraft_Layouts
{
    public partial class SinglePropellerLayout : AircraftLayoutControl
    {
        public SinglePropellerLayout(MainWindow mainWindow, componentTreeUserControl treeControl) : base(mainWindow, treeControl)
        {
            InitializeComponent();
            setUpSockets();
        }
     
        public void setUpSockets()
        {
            //Create new sockets and add them to the base class's (AircraftLayoutControl) list of sockets
            Socket batterySocket = new BatterySocket(100, 100);
            sockets.Add(batterySocket);

            //Go through the list of sockets and add them to this User Control
            foreach(Socket socket in sockets)
            {
                Controls.Add(socket);
            }
        }

    }
}
