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
using RC_Configurator.userInterface.New_Component_Window_User_Controls;
using RC_Configurator.domain.Database;
using RC_Configurator.userInterface.New_Component_Window.New_Component_Window_User_Controls;

namespace RC_Configurator.userInterface
{
    public partial class NewComponentWindow : Form

    {
        private MainWindow mainWindow;
        private List<string> componentComboItems;
        private UserControl currentUserControl;
        private DBManager dbManager;
        private AddBatteryPanel batteryPanel;
        private AddMotorPanel motorPanel;
        private AddPropellerPanel propellerPanel;

        
        public NewComponentWindow(MainWindow mainWindow, DBManager dbManager)
        {
            this.mainWindow = mainWindow;
            this.dbManager = dbManager;

            //Enables the main window on close
            FormClosed += new FormClosedEventHandler(NewComponentWindow_FormClosed);

            //Component combo box choices
            componentComboItems = new List<string> { "Choose component type...", "Battery", "Motor", "Propeller" };

            InitializeComponent();

            //Populates the Choose Component combo box with choices
            componentComboBox.DataSource = componentComboItems;

            //Set up component user controls
            batteryPanel = new AddBatteryPanel(this, dbManager);
            motorPanel = new AddMotorPanel(this, dbManager);
            propellerPanel = new AddPropellerPanel(this, dbManager);

            batteryPanel.Location = new Point(12, 124);
            motorPanel.Location = new Point(12, 124);
            propellerPanel.Location = new Point(12, 124);


            Controls.Add(batteryPanel);
            Controls.Add(motorPanel);
            Controls.Add(propellerPanel);

            motorPanel.Visible = false;
            motorPanel.Enabled = false;

            propellerPanel.Visible = false;
            propellerPanel.Enabled = false;
            
        }

        //When this window closes, update the tree view on the Main Window and re-enable the Main Window
        private void NewComponentWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainWindow.refreshComponentTree();
            mainWindow.Enabled = true;
        }


        private void componentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            //Gets the currently selected value of the combo box
            string selectedValue = (string)cmb.SelectedValue;

            if (selectedValue.Equals("Choose component type..."))
            {
                try
                {
                    currentUserControl.Enabled = false;
                    currentUserControl.Visible = false;
                }
                catch
                {
                    Exception exception = new NullReferenceException();
                }
            }

            if (selectedValue.Equals("Battery"))
            {
                //If there is already a panel being displayed, disable it
                try
                {
                    currentUserControl.Enabled = false;
                    currentUserControl.Visible = false;
                }
                catch
                {
                    Exception exception = new NullReferenceException();
                }

                //Activate the battery panel and set it as the current panel
                batteryPanel.Enabled = true;
                batteryPanel.Visible = true;
                currentUserControl = batteryPanel;
            }

            if (selectedValue.Equals("Motor"))
            {
                //If there is already a panel being displayed, disable it
                try
                {
                    currentUserControl.Enabled = false;
                    currentUserControl.Visible = false;
                }
                catch
                {
                    Exception exception = new NullReferenceException();

                }
                //Activate the motor panel and set it as the current panel
                motorPanel.Enabled = true;
                motorPanel.Visible = true;
                currentUserControl = motorPanel;
            }
            
            if (selectedValue.Equals("Propeller"))
            {
                //If there is already a panel being displayed, disable it
                try
                {
                    currentUserControl.Enabled = false;
                    currentUserControl.Visible = false;
                }
                catch
                {
                    Exception exception = new NullReferenceException();

                }
                //Activate the motor panel and set it as the current panel
                propellerPanel.Enabled = true;
                propellerPanel.Visible = true;
                currentUserControl = motorPanel;
            }
        }

        //Return the text value of the 'Name' text box
        public string getNameText()
        {
            return nameTextField.Text.ToString();
        }

        //Return the text value of the 'Weight' text box
        public string getWeightText()
        {
            return weightTextBox.Text.ToString();
        }

        public void setNameText(string newText)
        {
            nameTextField.Text = newText;
        }

        public void setWeightText(string newText)
        {
            weightTextBox.Text = newText;
        }

        public void closeWindow()
        {
            Close();
        }


    }
}
