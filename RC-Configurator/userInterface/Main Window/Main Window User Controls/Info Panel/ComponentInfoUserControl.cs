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
using RC_Configurator.domain;
using RC_Configurator.domain.Components;
using RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Info_Panel;
using RC_Configurator.domain.Database;

namespace RC_Configurator.userInterface.User_Controls
{
    public partial class componentInfoUserControl : UserControl
    {   
        private componentTreeUserControl treeControl;
        private MainWindow mainWindow;
        private InfoPanel batteryPanel;
        private InfoPanel motorPanel;
        private InfoPanel propellerPanel;
        private InfoPanel currentPanel;
        private DBManager dbManager;

        public componentInfoUserControl(MainWindow mainWindow, DBManager dbManager)
        {
            this.dbManager = dbManager;
            this.mainWindow = mainWindow;    

            batteryPanel = new BatteryInfo(this, dbManager);
            motorPanel = new MotorInfo(this, dbManager);
            propellerPanel = new PropellerInfo(this, dbManager);

            batteryPanel.Location = new Point(10, 50);
            motorPanel.Location = new Point(10, 50);
            propellerPanel.Location = new Point(10, 50);

            InitializeComponent();

            Controls.Add(batteryPanel);
            Controls.Add(motorPanel);
            Controls.Add(propellerPanel);

            batteryPanel.deactivateControl();
        }

        public void setTreeControl(componentTreeUserControl treeControl)
        {
            this.treeControl = mainWindow.getTreeControl();
        }

        public void displayComponentInfo(TreeView treeView)
        {
            try
            {
                //Check if the root node is "Batteries"
                if (treeView.SelectedNode.Parent.Parent.Text.Equals("Batteries"))
                {
                    //If there is another panel currently displayed, hide it
                    try
                    {
                        currentPanel.deactivateControl();
                    }
                    catch
                    {
                        Exception e = new NullReferenceException();
                    }
                    //Show the battery panel and set it as the currently displayed panel
                    batteryPanel.activateControl();
                    typeInfoLabel.Text = "Battery";
                    currentPanel = batteryPanel;
                    batteryPanel.update(treeControl.getTreeView());
                }

                if(treeView.SelectedNode.Parent.Parent.Text.Equals("Propellers"))
                {
                    //If there is another panel currently displayed, hide it
                    try
                    {
                        currentPanel.deactivateControl();
                    }
                    catch
                    {
                        Exception e = new NullReferenceException();
                    }
                    //Show the propeller panel and set it as the currently displayed panel
                    propellerPanel.activateControl();
                    typeInfoLabel.Text = "Propeller";
                    currentPanel = propellerPanel;
                    propellerPanel.update(treeControl.getTreeView());

                }
            }
            catch
            {
                try
                {
                    //If this node does not have a parent node which also has a parent node, then do nothing.
                    if (treeView.SelectedNode.Parent.Text.Equals("Motors"))
                    {
                        //If there is another panel currently displayed, hide it
                        try
                        {
                            currentPanel.deactivateControl();
                        }
                        catch
                        {

                        }
                        //Show the motor panel and set it as the currently displayed panel
                        motorPanel.activateControl();
                        typeInfoLabel.Text = "Motor";
                        currentPanel = motorPanel;
                        motorPanel.update(treeControl.getTreeView());
                    }
                }
                catch
                {

                }
            }
        }

        public void setTypeAndWeightLabels(string type, string weight)
        {
            //Set the values for the 'Type' and 'Weight' labels which are independent from the Component specific info panels
            typeInfoLabel.Text = type;
            weightInfoLabel.Text = weight;
        }

    }
}
