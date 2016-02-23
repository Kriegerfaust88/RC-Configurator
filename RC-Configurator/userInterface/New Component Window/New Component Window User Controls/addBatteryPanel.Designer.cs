namespace RC_Configurator.userInterface.New_Component_Window_User_Controls
{
    partial class AddBatteryPanel
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
            this.batteryGroupBox = new System.Windows.Forms.GroupBox();
            this.battClearButton = new System.Windows.Forms.Button();
            this.peakDischargeRateLabel = new System.Windows.Forms.Label();
            this.battAddButton = new System.Windows.Forms.Button();
            this.peakDischargeTextBox = new System.Windows.Forms.TextBox();
            this.dischargeTextBox = new System.Windows.Forms.TextBox();
            this.cellComboBox = new System.Windows.Forms.ComboBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.dischargeRateLabel = new System.Windows.Forms.Label();
            this.cellConfigurationLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.batteryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // batteryGroupBox
            // 
            this.batteryGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.batteryGroupBox.Controls.Add(this.battClearButton);
            this.batteryGroupBox.Controls.Add(this.peakDischargeRateLabel);
            this.batteryGroupBox.Controls.Add(this.battAddButton);
            this.batteryGroupBox.Controls.Add(this.peakDischargeTextBox);
            this.batteryGroupBox.Controls.Add(this.dischargeTextBox);
            this.batteryGroupBox.Controls.Add(this.cellComboBox);
            this.batteryGroupBox.Controls.Add(this.capacityTextBox);
            this.batteryGroupBox.Controls.Add(this.dischargeRateLabel);
            this.batteryGroupBox.Controls.Add(this.cellConfigurationLabel);
            this.batteryGroupBox.Controls.Add(this.capacityLabel);
            this.batteryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.batteryGroupBox.Name = "batteryGroupBox";
            this.batteryGroupBox.Size = new System.Drawing.Size(326, 336);
            this.batteryGroupBox.TabIndex = 2;
            this.batteryGroupBox.TabStop = false;
            this.batteryGroupBox.Text = "Battery Attributes";
            // 
            // battClearButton
            // 
            this.battClearButton.Location = new System.Drawing.Point(235, 292);
            this.battClearButton.Name = "battClearButton";
            this.battClearButton.Size = new System.Drawing.Size(75, 23);
            this.battClearButton.TabIndex = 8;
            this.battClearButton.Text = "Clear All..";
            this.battClearButton.UseVisualStyleBackColor = true;
            this.battClearButton.Click += new System.EventHandler(this.battClearButton_Click);
            // 
            // peakDischargeRateLabel
            // 
            this.peakDischargeRateLabel.AutoSize = true;
            this.peakDischargeRateLabel.Location = new System.Drawing.Point(7, 142);
            this.peakDischargeRateLabel.Name = "peakDischargeRateLabel";
            this.peakDischargeRateLabel.Size = new System.Drawing.Size(128, 13);
            this.peakDischargeRateLabel.TabIndex = 4;
            this.peakDischargeRateLabel.Text = "Peak Discharge Rate (C):";
            // 
            // battAddButton
            // 
            this.battAddButton.Location = new System.Drawing.Point(168, 292);
            this.battAddButton.Name = "battAddButton";
            this.battAddButton.Size = new System.Drawing.Size(47, 23);
            this.battAddButton.TabIndex = 7;
            this.battAddButton.Text = "Add..";
            this.battAddButton.UseVisualStyleBackColor = true;
            this.battAddButton.Click += new System.EventHandler(this.battAddButton_Click);
            // 
            // peakDischargeTextBox
            // 
            this.peakDischargeTextBox.Location = new System.Drawing.Point(255, 140);
            this.peakDischargeTextBox.Name = "peakDischargeTextBox";
            this.peakDischargeTextBox.Size = new System.Drawing.Size(55, 20);
            this.peakDischargeTextBox.TabIndex = 6;
            // 
            // dischargeTextBox
            // 
            this.dischargeTextBox.Location = new System.Drawing.Point(255, 107);
            this.dischargeTextBox.Name = "dischargeTextBox";
            this.dischargeTextBox.Size = new System.Drawing.Size(55, 20);
            this.dischargeTextBox.TabIndex = 5;
            // 
            // cellComboBox
            // 
            this.cellComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cellComboBox.FormattingEnabled = true;
            this.cellComboBox.Location = new System.Drawing.Point(255, 70);
            this.cellComboBox.Name = "cellComboBox";
            this.cellComboBox.Size = new System.Drawing.Size(55, 21);
            this.cellComboBox.TabIndex = 4;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(255, 39);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(55, 20);
            this.capacityTextBox.TabIndex = 3;
            // 
            // dischargeRateLabel
            // 
            this.dischargeRateLabel.AutoSize = true;
            this.dischargeRateLabel.Location = new System.Drawing.Point(7, 106);
            this.dischargeRateLabel.Name = "dischargeRateLabel";
            this.dischargeRateLabel.Size = new System.Drawing.Size(100, 13);
            this.dischargeRateLabel.TabIndex = 3;
            this.dischargeRateLabel.Text = "Discharge Rate (C):";
            // 
            // cellConfigurationLabel
            // 
            this.cellConfigurationLabel.AutoSize = true;
            this.cellConfigurationLabel.Location = new System.Drawing.Point(7, 72);
            this.cellConfigurationLabel.Name = "cellConfigurationLabel";
            this.cellConfigurationLabel.Size = new System.Drawing.Size(92, 13);
            this.cellConfigurationLabel.TabIndex = 2;
            this.cellConfigurationLabel.Text = "Cell Configuration:";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(7, 41);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(81, 13);
            this.capacityLabel.TabIndex = 0;
            this.capacityLabel.Text = "Capacity (mAh):";
            // 
            // AddBatteryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.batteryGroupBox);
            this.Name = "AddBatteryPanel";
            this.Size = new System.Drawing.Size(331, 342);
            this.batteryGroupBox.ResumeLayout(false);
            this.batteryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox batteryGroupBox;
        private System.Windows.Forms.Button battClearButton;
        private System.Windows.Forms.Label peakDischargeRateLabel;
        private System.Windows.Forms.Button battAddButton;
        private System.Windows.Forms.TextBox peakDischargeTextBox;
        private System.Windows.Forms.TextBox dischargeTextBox;
        private System.Windows.Forms.ComboBox cellComboBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label dischargeRateLabel;
        private System.Windows.Forms.Label cellConfigurationLabel;
        private System.Windows.Forms.Label capacityLabel;
    }
}
