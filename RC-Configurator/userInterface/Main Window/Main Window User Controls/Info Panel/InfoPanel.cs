using RC_Configurator.domain.Database;
using RC_Configurator.userInterface.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Info_Panel
{
    public class InfoPanel : UserControl, IPanel
    {
        private componentInfoUserControl infoControl;
        private DBManager dbManager;

        public InfoPanel(componentInfoUserControl infoControl, DBManager dbManager)
        {
            this.dbManager = dbManager;
            this.infoControl = infoControl;
            InitializeComponent();            
        }

       public InfoPanel()
        {
            InitializeComponent();
        }

        public DBManager getDBManager()
        {
            return dbManager;
        }

        public componentInfoUserControl getInfoControl()
        {
            return infoControl;
        }


        public void activateControl()
        {
            BringToFront();
            Enabled = true;
            Visible = true;
        }

        public void deactivateControl()
        {
            SendToBack();
            Enabled = false;
            Visible = false;
        }

        public virtual void update(TreeView treeView)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.Name = "InfoPanel";
            this.Size = new System.Drawing.Size(241, 292);
            this.ResumeLayout(false);

        }

        
    }
}
