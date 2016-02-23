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
    public partial class AddBatteryPanel : UserControl
    {
        private NewComponentWindow newComponentWindow;
        private List<string> cellConfigurationComboItems;
        private DBManager dbManager;

        public AddBatteryPanel(NewComponentWindow newComponentWindow, DBManager dbManager)
        {
            this.dbManager = dbManager;
            this.newComponentWindow = newComponentWindow;
            InitializeComponent();
            cellConfigurationComboItems = new List<string> { "1S", "2S", "3S", "4S", "5S", "6S", "7S", "8S" };
            cellComboBox.DataSource = cellConfigurationComboItems;
            Enabled = false;
            Visible = false;
        }

        
        public void activate()
        {
            Visible = true;
            Enabled = true;
        }

        public void deactivate()
        {
            Visible = false;
            Enabled = false;
        }

        private void battAddButton_Click(object sender, EventArgs e)
        {
            //pull values from fields of the Battery Attributes group box
            var name = newComponentWindow.getNameText();
            var weight = Convert.ToInt32(newComponentWindow.getWeightText());
            var capacity = Convert.ToInt32(capacityTextBox.Text);
            var cellConfig = cellComboBox.SelectedValue.ToString();
            var dischargeRate = Convert.ToInt32(dischargeTextBox.Text);
            var peakDischargeRate = Convert.ToInt32(peakDischargeTextBox.Text);

            //Tell the battery manager to save a new battery into the 'Battery' table of the database
            dbManager.saveBattery(name, weight, capacity, cellConfig, dischargeRate, peakDischargeRate);

            //Close the New Component window and return to the Main Window
            newComponentWindow.closeWindow();
        }

        private void battClearButton_Click(object sender, EventArgs e)
        {
            //Clear all user input text fields

            newComponentWindow.setNameText("");
            newComponentWindow.setWeightText("");
            capacityTextBox.Text = "";
            cellComboBox.SelectedIndex = 0;
            dischargeTextBox.Text = "";
            peakDischargeTextBox.Text = "";
        }
    }
}
