namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Info_Panel
{
    partial class BatteryInfo
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
            this.batteryPanel = new System.Windows.Forms.Panel();
            this.battPeakInfoLabel = new System.Windows.Forms.Label();
            this.battDischargeInfoLabel = new System.Windows.Forms.Label();
            this.battConfigInfoLabel = new System.Windows.Forms.Label();
            this.battCapacityInfoLabel = new System.Windows.Forms.Label();
            this.battNameInfoLabel = new System.Windows.Forms.Label();
            this.battPeakDischargeLabel = new System.Windows.Forms.Label();
            this.battDischargeLabel = new System.Windows.Forms.Label();
            this.battConfigLabel = new System.Windows.Forms.Label();
            this.battCapacityLabel = new System.Windows.Forms.Label();
            this.battNameLabel = new System.Windows.Forms.Label();
            this.batteryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // batteryPanel
            // 
            this.batteryPanel.Controls.Add(this.battPeakInfoLabel);
            this.batteryPanel.Controls.Add(this.battDischargeInfoLabel);
            this.batteryPanel.Controls.Add(this.battConfigInfoLabel);
            this.batteryPanel.Controls.Add(this.battCapacityInfoLabel);
            this.batteryPanel.Controls.Add(this.battNameInfoLabel);
            this.batteryPanel.Controls.Add(this.battPeakDischargeLabel);
            this.batteryPanel.Controls.Add(this.battDischargeLabel);
            this.batteryPanel.Controls.Add(this.battConfigLabel);
            this.batteryPanel.Controls.Add(this.battCapacityLabel);
            this.batteryPanel.Controls.Add(this.battNameLabel);
            this.batteryPanel.Location = new System.Drawing.Point(3, 3);
            this.batteryPanel.Name = "batteryPanel";
            this.batteryPanel.Size = new System.Drawing.Size(252, 163);
            this.batteryPanel.TabIndex = 1;
            // 
            // battPeakInfoLabel
            // 
            this.battPeakInfoLabel.AutoSize = true;
            this.battPeakInfoLabel.Location = new System.Drawing.Point(195, 128);
            this.battPeakInfoLabel.Name = "battPeakInfoLabel";
            this.battPeakInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.battPeakInfoLabel.TabIndex = 10;
            this.battPeakInfoLabel.Text = "-";
            // 
            // battDischargeInfoLabel
            // 
            this.battDischargeInfoLabel.AutoSize = true;
            this.battDischargeInfoLabel.Location = new System.Drawing.Point(195, 99);
            this.battDischargeInfoLabel.Name = "battDischargeInfoLabel";
            this.battDischargeInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.battDischargeInfoLabel.TabIndex = 9;
            this.battDischargeInfoLabel.Text = "-";
            // 
            // battConfigInfoLabel
            // 
            this.battConfigInfoLabel.AutoSize = true;
            this.battConfigInfoLabel.Location = new System.Drawing.Point(195, 69);
            this.battConfigInfoLabel.Name = "battConfigInfoLabel";
            this.battConfigInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.battConfigInfoLabel.TabIndex = 8;
            this.battConfigInfoLabel.Text = "-";
            // 
            // battCapacityInfoLabel
            // 
            this.battCapacityInfoLabel.AutoSize = true;
            this.battCapacityInfoLabel.Location = new System.Drawing.Point(195, 40);
            this.battCapacityInfoLabel.Name = "battCapacityInfoLabel";
            this.battCapacityInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.battCapacityInfoLabel.TabIndex = 7;
            this.battCapacityInfoLabel.Text = "-";
            // 
            // battNameInfoLabel
            // 
            this.battNameInfoLabel.AutoSize = true;
            this.battNameInfoLabel.Location = new System.Drawing.Point(195, 10);
            this.battNameInfoLabel.Name = "battNameInfoLabel";
            this.battNameInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.battNameInfoLabel.TabIndex = 6;
            this.battNameInfoLabel.Text = "-";
            // 
            // battPeakDischargeLabel
            // 
            this.battPeakDischargeLabel.AutoSize = true;
            this.battPeakDischargeLabel.Location = new System.Drawing.Point(6, 128);
            this.battPeakDischargeLabel.Name = "battPeakDischargeLabel";
            this.battPeakDischargeLabel.Size = new System.Drawing.Size(128, 13);
            this.battPeakDischargeLabel.TabIndex = 5;
            this.battPeakDischargeLabel.Text = "Peak Discharge Rate (C):";
            // 
            // battDischargeLabel
            // 
            this.battDischargeLabel.AutoSize = true;
            this.battDischargeLabel.Location = new System.Drawing.Point(6, 99);
            this.battDischargeLabel.Name = "battDischargeLabel";
            this.battDischargeLabel.Size = new System.Drawing.Size(149, 13);
            this.battDischargeLabel.TabIndex = 4;
            this.battDischargeLabel.Text = "Continuous discharge rate (C):";
            // 
            // battConfigLabel
            // 
            this.battConfigLabel.AutoSize = true;
            this.battConfigLabel.Location = new System.Drawing.Point(6, 69);
            this.battConfigLabel.Name = "battConfigLabel";
            this.battConfigLabel.Size = new System.Drawing.Size(92, 13);
            this.battConfigLabel.TabIndex = 3;
            this.battConfigLabel.Text = "Cell Configuration:";
            // 
            // battCapacityLabel
            // 
            this.battCapacityLabel.AutoSize = true;
            this.battCapacityLabel.Location = new System.Drawing.Point(6, 40);
            this.battCapacityLabel.Name = "battCapacityLabel";
            this.battCapacityLabel.Size = new System.Drawing.Size(81, 13);
            this.battCapacityLabel.TabIndex = 2;
            this.battCapacityLabel.Text = "Capacity (mAh):";
            // 
            // battNameLabel
            // 
            this.battNameLabel.AutoSize = true;
            this.battNameLabel.Location = new System.Drawing.Point(6, 10);
            this.battNameLabel.Name = "battNameLabel";
            this.battNameLabel.Size = new System.Drawing.Size(38, 13);
            this.battNameLabel.TabIndex = 1;
            this.battNameLabel.Text = "Name:";
            // 
            // BatteryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.batteryPanel);
            this.Name = "BatteryInfo";
            this.Size = new System.Drawing.Size(258, 172);
            this.batteryPanel.ResumeLayout(false);
            this.batteryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel batteryPanel;
        private System.Windows.Forms.Label battPeakInfoLabel;
        private System.Windows.Forms.Label battDischargeInfoLabel;
        private System.Windows.Forms.Label battConfigInfoLabel;
        private System.Windows.Forms.Label battCapacityInfoLabel;
        private System.Windows.Forms.Label battNameInfoLabel;
        private System.Windows.Forms.Label battPeakDischargeLabel;
        private System.Windows.Forms.Label battDischargeLabel;
        private System.Windows.Forms.Label battConfigLabel;
        private System.Windows.Forms.Label battCapacityLabel;
        private System.Windows.Forms.Label battNameLabel;
    }
}
