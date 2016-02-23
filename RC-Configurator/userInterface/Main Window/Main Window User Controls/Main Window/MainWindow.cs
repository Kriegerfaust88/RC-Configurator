using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_Configurator.userInterface;
using RC_Configurator.domain.File_IO;
using System.Data.SQLite;
using RC_Configurator.domain.Components;
using RC_Configurator.domain;
using RC_Configurator.userInterface.User_Controls;
using RC_Configurator.domain.Database;
using RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls;
using RC_Configurator.userInterface.Main_Window.Aircraft_Layout_Controls.Aircraft_Layouts;

namespace RC_Configurator
{
    public partial class MainWindow : Form
    {

        private DBManager dbManager;
        private componentTreeUserControl treeControl;
        private componentInfoUserControl componentInfoControl;
        private AircraftLayoutControl aircraftControl;

        public MainWindow()
        {
            dbManager = new DBManager();

            //Create the component info control
            componentInfoControl = new componentInfoUserControl(this, dbManager);
            componentInfoControl.Location = new System.Drawing.Point(9, 428);

            //Create the component tree control
            treeControl = new componentTreeUserControl(this, componentInfoControl, dbManager);
            treeControl.Location = new System.Drawing.Point(9, 6);

            //Set the info panel to use the TreeUserControl being used by the Main Window
            componentInfoControl.setTreeControl(treeControl);

            //Create a default aircraft layout and add it to the middle panel
            aircraftControl = new SinglePropellerLayout(this, treeControl);
            aircraftControl.Location = new Point(10, 10);

            InitializeComponent();

            //Add controls to their appropriate containers
            splitContainer1.Panel1.Controls.Add(treeControl);
            splitContainer1.Panel1.Controls.Add(componentInfoControl);
            splitContainer1.Panel2.Controls.Add(aircraftControl);


        }

        private void removeComponent_Click(object sender, EventArgs e)
        {

        }

        public componentTreeUserControl getTreeControl()
        {
            return treeControl;
        }

        public void refreshComponentTree()
        {
            treeControl.initializeComponentTree();
        }


    }
}
