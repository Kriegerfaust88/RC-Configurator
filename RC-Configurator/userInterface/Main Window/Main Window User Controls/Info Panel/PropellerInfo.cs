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
using RC_Configurator.domain.Database;
using RC_Configurator.domain.Components;

namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Info_Panel
{
    public partial class PropellerInfo : InfoPanel
    {
        public PropellerInfo(componentInfoUserControl infoControl, DBManager dbManager) : base(infoControl, dbManager)
        {
            InitializeComponent();
        }

        public override void update(TreeView treeView)
        {
            //Update the labels on the propeller panel to correspond to the currently selected propeller

            //Retrieve the KeyValuePair<string, Propeller> objects stored by the DBManager and iterate through them
            foreach (KeyValuePair<string, Propeller> propeller in getDBManager().getPropellers())
            {
                //If the selected node's value matches the key, update the info panel labels with the corresponding information stored in the value
                if (treeView.SelectedNode.Text.Equals(propeller.Value.name))
                {
                    getInfoControl().setTypeAndWeightLabels("Propeller", propeller.Value.weight.ToString());
                    nameInfoLabel.Text = propeller.Value.name.ToString();
                    bladeLengthInfoLabel.Text = propeller.Value.bladeLength.ToString();
                    bladePitchInfoLabel.Text = propeller.Value.bladePitch.ToString();
                    bladeCountInfoLabel.Text = propeller.Value.bladeCount.ToString();
                }
            }
        }
    }
}
