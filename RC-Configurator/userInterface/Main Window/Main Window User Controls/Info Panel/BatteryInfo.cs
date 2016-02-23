using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_Configurator.domain;
using RC_Configurator.userInterface.User_Controls;
using RC_Configurator.domain.Database;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Info_Panel
{
    public partial class BatteryInfo : InfoPanel
    {
        

        public BatteryInfo(componentInfoUserControl infoControl, DBManager dbManager) : base(infoControl, dbManager)
        {
            InitializeComponent();
        }

        public override void update(TreeView treeView)
        {
            //Update the labels on the battery panel to correspond to the currently selected battery

            //Retrieve the KeyValuePair<string, Battery> objects stored by the DBManager and iterate through them
            foreach (KeyValuePair<string, Battery> battery in getDBManager().getBatteries())
            {
                //If the selected node's value matches the key, update the info panel labels with the corresponding information stored in the value
                if (treeView.SelectedNode.Text.Equals(battery.Value.name))
                {
                    getInfoControl().setTypeAndWeightLabels("Battery", battery.Value.weight.ToString());
                    battNameInfoLabel.Text = battery.Value.name.ToString();
                    battConfigInfoLabel.Text = battery.Value.configuration.ToString();
                    battCapacityInfoLabel.Text = battery.Value.capacity.ToString() + " mAh";
                    battDischargeInfoLabel.Text = battery.Value.discharge.ToString() + " C";
                    battPeakInfoLabel.Text = battery.Value.peakDischarge.ToString() + " C";
                }
            }

        }

    }
}
