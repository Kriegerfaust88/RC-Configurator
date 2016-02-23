using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_Configurator.domain.Database;

namespace RC_Configurator.userInterface.New_Component_Window_User_Controls
{
    public partial class AddMotorPanel : UserControl
    {
        private NewComponentWindow newComponentWindow;
        private List<string> maxCellComboBoxItems;
        private List<string> minCellComboBoxItems;
        private DBManager dbManager;

        public AddMotorPanel(NewComponentWindow newComponentWindow, DBManager dbManager)
        {
            this.newComponentWindow = newComponentWindow;
            this.dbManager = dbManager;

            InitializeComponent();

            //Populate the combo boxes
            minCellComboBoxItems = new List<string> { "1S", "2S", "3S", "4S", "5S", "6S", "7S", "8S" };
            maxCellComboBoxItems = new List<string> { "1S", "2S", "3S", "4S", "5S", "6S", "7S", "8S" };

            minCellComboBox.DataSource = minCellComboBoxItems;
            maxCellComboBox.DataSource = maxCellComboBoxItems;
        }

        private void motorAddButton_Click(object sender, EventArgs e)
        {
            //pull values from fields of the Motor Attributes group box
            var name = newComponentWindow.getNameText();
            var weight = Convert.ToInt32(newComponentWindow.getWeightText());
            var kV = Convert.ToInt32(kvTextBox.Text);
            var maxCurrent = Convert.ToInt32(maxCurrentTextBox.Text);
            var maxVoltage = Convert.ToInt32(maxVoltageTextBox.Text);
            var maxPower = Convert.ToInt32(maxPowerTextBox.Text);
            string minCell = minCellComboBox.SelectedValue.ToString();
            string maxCell = maxCellComboBox.SelectedValue.ToString();
            var requiredESC = Convert.ToInt32(escTextBox.Text);         

            //Call the dbManager to save a new motor into the database
            dbManager.saveMotor(name, weight, kV, maxCurrent, maxVoltage, maxPower, minCell, maxCell, requiredESC);

            //Closes the New Component window and returns to the Main Window
            newComponentWindow.closeWindow();
        }

        private void motorClearButton_Click(object sender, EventArgs e)
        {
            newComponentWindow.setNameText("");
            newComponentWindow.setWeightText("");
            kvTextBox.Text = "";
            maxCurrentTextBox.Text = "";
            maxVoltageTextBox.Text = "";
            maxPowerTextBox.Text = "";
            minCellComboBox.SelectedIndex = 0;
            maxCellComboBox.SelectedIndex = 0;
            escTextBox.Text = "";
        }
    }
}
