using RC_Configurator.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Socket
{
    public class Socket : UserControl, ISocket
    {

        private int xCoord;
        private int yCoord;
        private Component boundComponent;
        private bool isLocked;

        public Socket()
        {
            xCoord = Location.X;
            yCoord = Location.Y;
            isLocked = false;
            InitializeComponent();   
        }

        public Socket(int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            isLocked = false;
            InitializeComponent();
        }

        public void bindComponent(Component component)
        {
            boundComponent = component;
        }

        public Component getComponent()
        {
            return boundComponent;
        }

        public int getXCoord()
        {
            return xCoord;
        }

        public int getYCoord()
        {
            return yCoord;
        }

        public void lockSocket()
        {
            isLocked = true;
        }

        public void unlockSocket()
        {
            isLocked = false;
        }

        public void move(int newXCoord, int newYCoord)
        {
            xCoord = newXCoord;
            yCoord = newYCoord;
        }

        public void refreshBoundComponent()
        {
            //Implement method to display component icon
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Socket
            // 
            this.BackgroundImage = global::RC_Configurator.Properties.Resources.socket_circle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name = "Socket";
            this.Size = new System.Drawing.Size(90, 88);
            this.ResumeLayout(false);

        }

        

    }
}
