namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls.Info_Panel
{
    partial class PropellerInfo
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
            this.bladeCountInfoLabel = new System.Windows.Forms.Label();
            this.bladePitchInfoLabel = new System.Windows.Forms.Label();
            this.bladeLengthInfoLabel = new System.Windows.Forms.Label();
            this.nameInfoLabel = new System.Windows.Forms.Label();
            this.bladeCountLabel = new System.Windows.Forms.Label();
            this.bladePitchLabel = new System.Windows.Forms.Label();
            this.bladeLengthLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.batteryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // batteryPanel
            // 
            this.batteryPanel.Controls.Add(this.bladeCountInfoLabel);
            this.batteryPanel.Controls.Add(this.bladePitchInfoLabel);
            this.batteryPanel.Controls.Add(this.bladeLengthInfoLabel);
            this.batteryPanel.Controls.Add(this.nameInfoLabel);
            this.batteryPanel.Controls.Add(this.bladeCountLabel);
            this.batteryPanel.Controls.Add(this.bladePitchLabel);
            this.batteryPanel.Controls.Add(this.bladeLengthLabel);
            this.batteryPanel.Controls.Add(this.nameLabel);
            this.batteryPanel.Location = new System.Drawing.Point(3, 3);
            this.batteryPanel.Name = "batteryPanel";
            this.batteryPanel.Size = new System.Drawing.Size(252, 163);
            this.batteryPanel.TabIndex = 2;
            // 
            // bladeCountInfoLabel
            // 
            this.bladeCountInfoLabel.AutoSize = true;
            this.bladeCountInfoLabel.Location = new System.Drawing.Point(195, 99);
            this.bladeCountInfoLabel.Name = "bladeCountInfoLabel";
            this.bladeCountInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.bladeCountInfoLabel.TabIndex = 9;
            this.bladeCountInfoLabel.Text = "-";
            // 
            // bladePitchInfoLabel
            // 
            this.bladePitchInfoLabel.AutoSize = true;
            this.bladePitchInfoLabel.Location = new System.Drawing.Point(195, 69);
            this.bladePitchInfoLabel.Name = "bladePitchInfoLabel";
            this.bladePitchInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.bladePitchInfoLabel.TabIndex = 8;
            this.bladePitchInfoLabel.Text = "-";
            // 
            // bladeLengthInfoLabel
            // 
            this.bladeLengthInfoLabel.AutoSize = true;
            this.bladeLengthInfoLabel.Location = new System.Drawing.Point(195, 40);
            this.bladeLengthInfoLabel.Name = "bladeLengthInfoLabel";
            this.bladeLengthInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.bladeLengthInfoLabel.TabIndex = 7;
            this.bladeLengthInfoLabel.Text = "-";
            // 
            // nameInfoLabel
            // 
            this.nameInfoLabel.AutoSize = true;
            this.nameInfoLabel.Location = new System.Drawing.Point(195, 10);
            this.nameInfoLabel.Name = "nameInfoLabel";
            this.nameInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.nameInfoLabel.TabIndex = 6;
            this.nameInfoLabel.Text = "-";
            // 
            // bladeCountLabel
            // 
            this.bladeCountLabel.AutoSize = true;
            this.bladeCountLabel.Location = new System.Drawing.Point(6, 99);
            this.bladeCountLabel.Name = "bladeCountLabel";
            this.bladeCountLabel.Size = new System.Drawing.Size(94, 13);
            this.bladeCountLabel.TabIndex = 4;
            this.bladeCountLabel.Text = "Number of Blades:";
            // 
            // bladePitchLabel
            // 
            this.bladePitchLabel.AutoSize = true;
            this.bladePitchLabel.Location = new System.Drawing.Point(6, 69);
            this.bladePitchLabel.Name = "bladePitchLabel";
            this.bladePitchLabel.Size = new System.Drawing.Size(64, 13);
            this.bladePitchLabel.TabIndex = 3;
            this.bladePitchLabel.Text = "Blade Pitch:";
            // 
            // bladeLengthLabel
            // 
            this.bladeLengthLabel.AutoSize = true;
            this.bladeLengthLabel.Location = new System.Drawing.Point(6, 40);
            this.bladeLengthLabel.Name = "bladeLengthLabel";
            this.bladeLengthLabel.Size = new System.Drawing.Size(90, 13);
            this.bladeLengthLabel.TabIndex = 2;
            this.bladeLengthLabel.Text = "Blade Length (in):";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // PropellerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.batteryPanel);
            this.Name = "PropellerInfo";
            this.Size = new System.Drawing.Size(260, 171);
            this.batteryPanel.ResumeLayout(false);
            this.batteryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel batteryPanel;
        private System.Windows.Forms.Label bladeCountInfoLabel;
        private System.Windows.Forms.Label bladePitchInfoLabel;
        private System.Windows.Forms.Label bladeLengthInfoLabel;
        private System.Windows.Forms.Label nameInfoLabel;
        private System.Windows.Forms.Label bladeCountLabel;
        private System.Windows.Forms.Label bladePitchLabel;
        private System.Windows.Forms.Label bladeLengthLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
