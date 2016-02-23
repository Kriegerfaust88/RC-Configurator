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
    public partial class MotorInfo : InfoPanel
    {
      
        public MotorInfo(componentInfoUserControl infoControl, DBManager dbManager) : base(infoControl, dbManager)
        {          
            InitializeComponent();
        }

        public override void update(TreeView treeView)
        {
            //Update the labels on the motor panel to correspond to the currently selected motor

            //Retrieve the KeyValuePair<string, Motor> objects stored by the DBManager and iterate through them
            foreach (KeyValuePair<string, Motor> motor in getDBManager().getMotors())
            {
                //If the selected node's value matches the key, update the info panel labels with the corresponding information stored in the value
                if (treeView.SelectedNode.Text.Equals(motor.Value.name))
                {
                    getInfoControl().setTypeAndWeightLabels("Motor", motor.Value.weight.ToString());
                    motorNameInfoLabel.Text = motor.Value.name.ToString();
                    kvInfoLabel.Text = motor.Value.kV.ToString() + " kV";
                    maxCurrentInfoLabel.Text = motor.Value.maxCurrent.ToString() + " A";
                    maxPowerInfoLabel.Text = motor.Value.maxPower.ToString() + " W";
                    maxVoltageInfoLabel.Text = motor.Value.maxVoltage.ToString() + " V";
                    minCellInfoLabel.Text = motor.Value.minCell.ToString();
                    maxCellInfoLabel.Text = motor.Value.maxCell.ToString();
                    escInfoLabel.Text = motor.Value.requiredESC.ToString() + " A";
                }
            }

        }

    }
}

