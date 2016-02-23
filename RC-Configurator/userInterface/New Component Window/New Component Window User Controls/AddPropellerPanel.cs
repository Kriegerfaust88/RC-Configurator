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

namespace RC_Configurator.userInterface.New_Component_Window.New_Component_Window_User_Controls
{
    public partial class AddPropellerPanel : UserControl

    {    
        private List<int> bladeCountComboBoxItems;
        private DBManager dbManager;
        private NewComponentWindow newComponentWindow;

        public AddPropellerPanel(NewComponentWindow newComponentWindow, DBManager dbManager)
        {
            this.dbManager = dbManager;
            this.newComponentWindow = newComponentWindow;

            bladeCountComboBoxItems = new List<int> { 2,3,4,5 };
            InitializeComponent();

            bladeCountComboBox.DataSource = bladeCountComboBoxItems;
        }

        private void propllerAddButton_Click(object sender, EventArgs e)
        {
            var name = newComponentWindow.getNameText();
            var weight = Convert.ToInt32(newComponentWindow.getWeightText());
            var bladeLength = Convert.ToInt32(bladeLengthTextBox.Text);
            var bladePitch = Convert.ToDecimal(bladePitchTextBox.Text);
            var bladeCount = Convert.ToInt32(bladeCountComboBox.SelectedValue.ToString());

            dbManager.savePropeller(name, weight, bladeLength, bladePitch, bladeCount);

            newComponentWindow.closeWindow();
        }

        private void motorClearButton_Click(object sender, EventArgs e)
        {
            bladeCountLabel.Text = "";
            bladeLengthLabel.Text = "";
            bladeCountComboBox.SelectedIndex = 0;           
        }

        
    }
}
