using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_Configurator.userInterface.User_Controls;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls
{
    public partial class AircraftLayoutControl : UserControl
    {
        private MainWindow mainWindow;
        private componentTreeUserControl treeControl;
        protected List<Socket.Socket> sockets;

        public AircraftLayoutControl(MainWindow mainWindow, componentTreeUserControl treeControl)
        {
            this.mainWindow = mainWindow;
            this.treeControl = treeControl;
            sockets = new List<Socket.Socket>();

            InitializeComponent();
        }

        public AircraftLayoutControl()
        {
            InitializeComponent();
        }

        public void refreshLayout()
        {
            foreach (Socket.Socket socket in sockets)
            {
                
            }
        }
    }
}
