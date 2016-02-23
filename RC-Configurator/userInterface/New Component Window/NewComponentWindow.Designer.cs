using System.Windows.Forms;
using System.Collections.Generic;

namespace RC_Configurator.userInterface
{
    partial class NewComponentWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        



        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                
                
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.nameTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // componentComboBox
            // 
            this.componentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Location = new System.Drawing.Point(13, 13);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(137, 28);
            this.componentComboBox.TabIndex = 0;
            this.componentComboBox.SelectedIndexChanged += new System.EventHandler(this.componentComboBox_SelectedIndexChanged);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(22, 85);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(86, 20);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Weight (g):";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(138, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Component Name";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(249, 85);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 26);
            this.weightTextBox.TabIndex = 2;
            // 
            // nameTextField
            // 
            this.nameTextField.Location = new System.Drawing.Point(249, 58);
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.Size = new System.Drawing.Size(100, 26);
            this.nameTextField.TabIndex = 1;
            // 
            // NewComponentWindow
            // 
            this.ClientSize = new System.Drawing.Size(398, 503);
            this.Controls.Add(this.nameTextField);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.componentComboBox);
            this.Controls.Add(this.weightLabel);
            this.Name = "NewComponentWindow";
            this.Text = "New Component";
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private Label weightLabel;
        private ComboBox componentComboBox;
        private TextBox weightTextBox;
        private TextBox nameTextField;
        private Label nameLabel;
    }
}
