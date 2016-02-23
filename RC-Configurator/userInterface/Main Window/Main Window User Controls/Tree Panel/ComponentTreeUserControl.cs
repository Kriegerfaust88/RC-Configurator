using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_Configurator.domain.File_IO;
using RC_Configurator.domain.Components;
using RC_Configurator.domain;
using RC_Configurator.domain.Database;

namespace RC_Configurator.userInterface.User_Controls
{
    public partial class componentTreeUserControl : UserControl

    {
        private MainWindow mainWindow;
        private componentInfoUserControl infoControl;
        private DBManager dbManager;

        public componentTreeUserControl(MainWindow mainWindow, componentInfoUserControl infoControl, DBManager dbManager)
        {
            this.mainWindow = mainWindow;
            this.infoControl = infoControl;

            this.dbManager = dbManager;

            InitializeComponent();
            initializeComponentTree(); 
        }

        private void componentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            infoControl.displayComponentInfo(componentTreeView);
        }

        private void newComponent_Click(object sender, EventArgs e)
        {
            //Launch and enable the 'New Component' window and disable the main window for the duration
            NewComponentWindow newComponentWindow = new NewComponentWindow(mainWindow, dbManager);
            newComponentWindow.Show();
            newComponentWindow.Enabled = true;
            mainWindow.Enabled = false;
        }

        public void initializeComponentTree()
        {
            //initializes the nodes for the component tree view
            componentTreeView.BeginUpdate();
            componentTreeView.Nodes.Clear();
            componentTreeView.Nodes.Add("Batteries");
            componentTreeView.Nodes[0].Nodes.Add("1S");
            componentTreeView.Nodes[0].Nodes.Add("2S");
            componentTreeView.Nodes[0].Nodes.Add("3S");
            componentTreeView.Nodes[0].Nodes.Add("4S");
            componentTreeView.Nodes[0].Nodes.Add("5S");
            componentTreeView.Nodes[0].Nodes.Add("6S");
            componentTreeView.Nodes[0].Nodes.Add("7S");
            componentTreeView.Nodes[0].Nodes.Add("8S");
            componentTreeView.Nodes.Add("Motors");
            componentTreeView.Nodes.Add("Propellers");
            componentTreeView.Nodes[2].Nodes.Add("2 Blade");
            componentTreeView.Nodes[2].Nodes.Add("3 Blade");
            componentTreeView.Nodes[2].Nodes.Add("4 Blade");
            componentTreeView.Nodes[2].Nodes.Add("5 Blade");
            componentTreeView.Nodes.Add("Receivers");
            componentTreeView.Nodes[3].Nodes.Add("3 Channel");
            componentTreeView.Nodes[3].Nodes.Add("4 Channel");
            componentTreeView.Nodes[3].Nodes.Add("5 Channel");
            componentTreeView.Nodes[3].Nodes.Add("6 Channel");
            componentTreeView.Nodes[3].Nodes.Add("7 Channel");
            componentTreeView.Nodes[3].Nodes.Add("8 Channel");
            componentTreeView.Nodes[3].Nodes.Add("9 Channel");
            componentTreeView.Nodes.Add("Servos");
            componentTreeView.Nodes.Add("ESC");


            //Call methods to populate the tree view with data from the DBManager
            loadBatteries();
            loadMotors();
            loadPropellers();
            componentTreeView.EndUpdate();
        }

        public TreeView getTreeView()
        {
            return componentTreeView;
        }

        private void loadMotors()
        { 
            //Add a node for each motor object
            foreach (KeyValuePair<string, Motor> kvp in dbManager.getMotors())
            {
                componentTreeView.Nodes[1].Nodes.Add(kvp.Key.ToString());
            }
        }

        private void loadBatteries()
        {
            //Assigns each battery object to a node based on their configuration
            //Iterate throught the list of KeyValuePairs stored by the dbManager
            foreach (KeyValuePair<string, Battery> kvp in dbManager.getBatteries())
            {
                if (kvp.Value.configuration.Equals("1S"))
                {
                    componentTreeView.Nodes[0].Nodes[0].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("2S"))
                {
                    componentTreeView.Nodes[0].Nodes[1].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("3S"))
                {
                    componentTreeView.Nodes[0].Nodes[2].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("4S"))
                {
                    componentTreeView.Nodes[0].Nodes[3].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("5S"))
                {
                    componentTreeView.Nodes[0].Nodes[4].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("6S"))
                {
                    componentTreeView.Nodes[0].Nodes[5].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("7S"))
                {
                    componentTreeView.Nodes[0].Nodes[6].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.configuration.Equals("8S"))
                {
                    componentTreeView.Nodes[0].Nodes[7].Nodes.Add(kvp.Key.ToString());
                }
            }
        }

        private void loadPropellers()
        {
            foreach (KeyValuePair<string, Propeller> kvp in dbManager.getPropellers())
            {
                if (kvp.Value.bladeCount.Equals(2))
                {
                    componentTreeView.Nodes[2].Nodes[0].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.bladeCount.Equals(3))
                {
                    componentTreeView.Nodes[2].Nodes[1].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.bladeCount.Equals(4))
                {
                    componentTreeView.Nodes[2].Nodes[2].Nodes.Add(kvp.Key.ToString());
                }
                if (kvp.Value.bladeCount.Equals(5))
                {
                    componentTreeView.Nodes[2].Nodes[3].Nodes.Add(kvp.Key.ToString());
                }
            }
        }


        private void removeComponent_Click(object sender, EventArgs e)
        {

        }
    }
}
