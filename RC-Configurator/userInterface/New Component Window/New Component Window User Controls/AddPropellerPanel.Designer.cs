namespace RC_Configurator.userInterface.New_Component_Window.New_Component_Window_User_Controls
{
    partial class AddPropellerPanel
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
            this.propellerGroupBox = new System.Windows.Forms.GroupBox();
            this.motorClearButton = new System.Windows.Forms.Button();
            this.propllerAddButton = new System.Windows.Forms.Button();
            this.bladeLengthTextBox = new System.Windows.Forms.TextBox();
            this.bladePitchLabel = new System.Windows.Forms.Label();
            this.bladeCountComboBox = new System.Windows.Forms.ComboBox();
            this.bladePitchTextBox = new System.Windows.Forms.TextBox();
            this.bladeCountLabel = new System.Windows.Forms.Label();
            this.bladeLengthLabel = new System.Windows.Forms.Label();
            this.propellerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // propellerGroupBox
            // 
            this.propellerGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.propellerGroupBox.Controls.Add(this.motorClearButton);
            this.propellerGroupBox.Controls.Add(this.propllerAddButton);
            this.propellerGroupBox.Controls.Add(this.bladeLengthTextBox);
            this.propellerGroupBox.Controls.Add(this.bladePitchLabel);
            this.propellerGroupBox.Controls.Add(this.bladeCountComboBox);
            this.propellerGroupBox.Controls.Add(this.bladePitchTextBox);
            this.propellerGroupBox.Controls.Add(this.bladeCountLabel);
            this.propellerGroupBox.Controls.Add(this.bladeLengthLabel);
            this.propellerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.propellerGroupBox.Name = "propellerGroupBox";
            this.propellerGroupBox.Size = new System.Drawing.Size(326, 339);
            this.propellerGroupBox.TabIndex = 11;
            this.propellerGroupBox.TabStop = false;
            this.propellerGroupBox.Text = "Propller Attributes";
            // 
            // motorClearButton
            // 
            this.motorClearButton.Location = new System.Drawing.Point(234, 296);
            this.motorClearButton.Name = "motorClearButton";
            this.motorClearButton.Size = new System.Drawing.Size(75, 23);
            this.motorClearButton.TabIndex = 16;
            this.motorClearButton.Text = "Clear all...";
            this.motorClearButton.UseVisualStyleBackColor = true;
            this.motorClearButton.Click += new System.EventHandler(this.motorClearButton_Click);
            // 
            // propllerAddButton
            // 
            this.propllerAddButton.Location = new System.Drawing.Point(167, 296);
            this.propllerAddButton.Name = "propllerAddButton";
            this.propllerAddButton.Size = new System.Drawing.Size(47, 23);
            this.propllerAddButton.TabIndex = 15;
            this.propllerAddButton.Text = "Add...";
            this.propllerAddButton.UseVisualStyleBackColor = true;
            this.propllerAddButton.Click += new System.EventHandler(this.propllerAddButton_Click);
            // 
            // bladeLengthTextBox
            // 
            this.bladeLengthTextBox.Location = new System.Drawing.Point(254, 37);
            this.bladeLengthTextBox.Name = "bladeLengthTextBox";
            this.bladeLengthTextBox.Size = new System.Drawing.Size(55, 20);
            this.bladeLengthTextBox.TabIndex = 13;
            // 
            // bladePitchLabel
            // 
            this.bladePitchLabel.AutoSize = true;
            this.bladePitchLabel.Location = new System.Drawing.Point(6, 69);
            this.bladePitchLabel.Name = "bladePitchLabel";
            this.bladePitchLabel.Size = new System.Drawing.Size(64, 13);
            this.bladePitchLabel.TabIndex = 4;
            this.bladePitchLabel.Text = "Blade Pitch:";
            // 
            // bladeCountComboBox
            // 
            this.bladeCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bladeCountComboBox.FormattingEnabled = true;
            this.bladeCountComboBox.Location = new System.Drawing.Point(254, 97);
            this.bladeCountComboBox.Name = "bladeCountComboBox";
            this.bladeCountComboBox.Size = new System.Drawing.Size(55, 21);
            this.bladeCountComboBox.TabIndex = 6;
            // 
            // bladePitchTextBox
            // 
            this.bladePitchTextBox.Location = new System.Drawing.Point(254, 66);
            this.bladePitchTextBox.Name = "bladePitchTextBox";
            this.bladePitchTextBox.Size = new System.Drawing.Size(55, 20);
            this.bladePitchTextBox.TabIndex = 5;
            // 
            // bladeCountLabel
            // 
            this.bladeCountLabel.AutoSize = true;
            this.bladeCountLabel.Location = new System.Drawing.Point(6, 100);
            this.bladeCountLabel.Name = "bladeCountLabel";
            this.bladeCountLabel.Size = new System.Drawing.Size(94, 13);
            this.bladeCountLabel.TabIndex = 2;
            this.bladeCountLabel.Text = "Number of Blades:";
            // 
            // bladeLengthLabel
            // 
            this.bladeLengthLabel.AutoSize = true;
            this.bladeLengthLabel.Location = new System.Drawing.Point(4, 43);
            this.bladeLengthLabel.Name = "bladeLengthLabel";
            this.bladeLengthLabel.Size = new System.Drawing.Size(73, 13);
            this.bladeLengthLabel.TabIndex = 0;
            this.bladeLengthLabel.Text = "Blade Length:";
            // 
            // AddPropellerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propellerGroupBox);
            this.Name = "AddPropellerPanel";
            this.Size = new System.Drawing.Size(336, 348);
            this.propellerGroupBox.ResumeLayout(false);
            this.propellerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox propellerGroupBox;
        private System.Windows.Forms.Button motorClearButton;
        private System.Windows.Forms.Button propllerAddButton;
        private System.Windows.Forms.TextBox bladeLengthTextBox;
        private System.Windows.Forms.Label bladePitchLabel;
        private System.Windows.Forms.ComboBox bladeCountComboBox;
        private System.Windows.Forms.TextBox bladePitchTextBox;
        private System.Windows.Forms.Label bladeCountLabel;
        private System.Windows.Forms.Label bladeLengthLabel;
    }
}
