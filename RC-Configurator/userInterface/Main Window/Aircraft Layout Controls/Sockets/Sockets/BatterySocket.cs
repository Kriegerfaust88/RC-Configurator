using RC_Configurator.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Socket.Sockets
{
    public class BatterySocket : Socket, ISocket
    {
        public BatterySocket(int xCoord, int yCoord) : base(xCoord, yCoord)
        {
            Location = new System.Drawing.Point(xCoord, yCoord);
        }

        new public void bindComponent(Component component)
        {
            if (component.GetType().Equals("Battery"))
            {
                bindComponent(component);
            } else
            {
                //display error message
               
            }
        }

        

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BatterySocket
            // 
            this.BackgroundImage = global::RC_Configurator.Properties.Resources.socket_circle;
            this.Name = "BatterySocket";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.BatterySocket_DragDrop);
            this.ResumeLayout(false);

        }

    }
}
