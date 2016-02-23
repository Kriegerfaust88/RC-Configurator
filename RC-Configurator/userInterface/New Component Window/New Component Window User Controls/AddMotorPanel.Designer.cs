namespace RC_Configurator.userInterface.New_Component_Window_User_Controls
{
    partial class AddMotorPanel
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
            this.motorGroupBox = new System.Windows.Forms.GroupBox();
            this.motorClearButton = new System.Windows.Forms.Button();
            this.motorAddButton = new System.Windows.Forms.Button();
            this.maxCellComboBox = new System.Windows.Forms.ComboBox();
            this.kvTextBox = new System.Windows.Forms.TextBox();
            this.escTextBox = new System.Windows.Forms.TextBox();
            this.maxPowerLabel = new System.Windows.Forms.Label();
            this.escLabel = new System.Windows.Forms.Label();
            this.maxCellLabel = new System.Windows.Forms.Label();
            this.minCellLabel = new System.Windows.Forms.Label();
            this.maxVoltageTextBox = new System.Windows.Forms.TextBox();
            this.maxCurrentTextBox = new System.Windows.Forms.TextBox();
            this.minCellComboBox = new System.Windows.Forms.ComboBox();
            this.maxPowerTextBox = new System.Windows.Forms.TextBox();
            this.maxVoltageLabel = new System.Windows.Forms.Label();
            this.maxCurrentLabel = new System.Windows.Forms.Label();
            this.kvLabel = new System.Windows.Forms.Label();
            this.motorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorGroupBox
            // 
            this.motorGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.motorGroupBox.Controls.Add(this.motorClearButton);
            this.motorGroupBox.Controls.Add(this.motorAddButton);
            this.motorGroupBox.Controls.Add(this.maxCellComboBox);
            this.motorGroupBox.Controls.Add(this.kvTextBox);
            this.motorGroupBox.Controls.Add(this.escTextBox);
            this.motorGroupBox.Controls.Add(this.maxPowerLabel);
            this.motorGroupBox.Controls.Add(this.escLabel);
            this.motorGroupBox.Controls.Add(this.maxCellLabel);
            this.motorGroupBox.Controls.Add(this.minCellLabel);
            this.motorGroupBox.Controls.Add(this.maxVoltageTextBox);
            this.motorGroupBox.Controls.Add(this.maxCurrentTextBox);
            this.motorGroupBox.Controls.Add(this.minCellComboBox);
            this.motorGroupBox.Controls.Add(this.maxPowerTextBox);
            this.motorGroupBox.Controls.Add(this.maxVoltageLabel);
            this.motorGroupBox.Controls.Add(this.maxCurrentLabel);
            this.motorGroupBox.Controls.Add(this.kvLabel);
            this.motorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.motorGroupBox.Name = "motorGroupBox";
            this.motorGroupBox.Size = new System.Drawing.Size(324, 338);
            this.motorGroupBox.TabIndex = 10;
            this.motorGroupBox.TabStop = false;
            this.motorGroupBox.Text = "Motor Attributes";
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
            // motorAddButton
            // 
            this.motorAddButton.Location = new System.Drawing.Point(167, 296);
            this.motorAddButton.Name = "motorAddButton";
            this.motorAddButton.Size = new System.Drawing.Size(47, 23);
            this.motorAddButton.TabIndex = 15;
            this.motorAddButton.Text = "Add...";
            this.motorAddButton.UseVisualStyleBackColor = true;
            this.motorAddButton.Click += new System.EventHandler(this.motorAddButton_Click);
            // 
            // maxCellComboBox
            // 
            this.maxCellComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxCellComboBox.FormattingEnabled = true;
            this.maxCellComboBox.Location = new System.Drawing.Point(254, 228);
            this.maxCellComboBox.Name = "maxCellComboBox";
            this.maxCellComboBox.Size = new System.Drawing.Size(55, 21);
            this.maxCellComboBox.TabIndex = 14;
            // 
            // kvTextBox
            // 
            this.kvTextBox.Location = new System.Drawing.Point(254, 37);
            this.kvTextBox.Name = "kvTextBox";
            this.kvTextBox.Size = new System.Drawing.Size(55, 20);
            this.kvTextBox.TabIndex = 13;
            // 
            // escTextBox
            // 
            this.escTextBox.Location = new System.Drawing.Point(254, 160);
            this.escTextBox.Name = "escTextBox";
            this.escTextBox.Size = new System.Drawing.Size(55, 20);
            this.escTextBox.TabIndex = 12;
            // 
            // maxPowerLabel
            // 
            this.maxPowerLabel.AutoSize = true;
            this.maxPowerLabel.Location = new System.Drawing.Point(5, 71);
            this.maxPowerLabel.Name = "maxPowerLabel";
            this.maxPowerLabel.Size = new System.Drawing.Size(107, 13);
            this.maxPowerLabel.TabIndex = 4;
            this.maxPowerLabel.Text = "Maximum Power (W):";
            // 
            // escLabel
            // 
            this.escLabel.AutoSize = true;
            this.escLabel.Location = new System.Drawing.Point(5, 163);
            this.escLabel.Name = "escLabel";
            this.escLabel.Size = new System.Drawing.Size(93, 13);
            this.escLabel.TabIndex = 11;
            this.escLabel.Text = "Required ESC (A):";
            // 
            // maxCellLabel
            // 
            this.maxCellLabel.AutoSize = true;
            this.maxCellLabel.Location = new System.Drawing.Point(4, 231);
            this.maxCellLabel.Name = "maxCellLabel";
            this.maxCellLabel.Size = new System.Drawing.Size(55, 13);
            this.maxCellLabel.TabIndex = 10;
            this.maxCellLabel.Text = "Max Cells:";
            // 
            // minCellLabel
            // 
            this.minCellLabel.AutoSize = true;
            this.minCellLabel.Location = new System.Drawing.Point(5, 198);
            this.minCellLabel.Name = "minCellLabel";
            this.minCellLabel.Size = new System.Drawing.Size(96, 13);
            this.minCellLabel.TabIndex = 9;
            this.minCellLabel.Text = "Min. Cell Required:";
            // 
            // maxVoltageTextBox
            // 
            this.maxVoltageTextBox.Location = new System.Drawing.Point(254, 127);
            this.maxVoltageTextBox.Name = "maxVoltageTextBox";
            this.maxVoltageTextBox.Size = new System.Drawing.Size(55, 20);
            this.maxVoltageTextBox.TabIndex = 8;
            // 
            // maxCurrentTextBox
            // 
            this.maxCurrentTextBox.Location = new System.Drawing.Point(254, 97);
            this.maxCurrentTextBox.Name = "maxCurrentTextBox";
            this.maxCurrentTextBox.Size = new System.Drawing.Size(55, 20);
            this.maxCurrentTextBox.TabIndex = 7;
            // 
            // minCellComboBox
            // 
            this.minCellComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minCellComboBox.FormattingEnabled = true;
            this.minCellComboBox.Location = new System.Drawing.Point(254, 195);
            this.minCellComboBox.Name = "minCellComboBox";
            this.minCellComboBox.Size = new System.Drawing.Size(55, 21);
            this.minCellComboBox.TabIndex = 6;
            // 
            // maxPowerTextBox
            // 
            this.maxPowerTextBox.Location = new System.Drawing.Point(254, 69);
            this.maxPowerTextBox.Name = "maxPowerTextBox";
            this.maxPowerTextBox.Size = new System.Drawing.Size(55, 20);
            this.maxPowerTextBox.TabIndex = 5;
            // 
            // maxVoltageLabel
            // 
            this.maxVoltageLabel.AutoSize = true;
            this.maxVoltageLabel.Location = new System.Drawing.Point(5, 134);
            this.maxVoltageLabel.Name = "maxVoltageLabel";
            this.maxVoltageLabel.Size = new System.Drawing.Size(115, 13);
            this.maxVoltageLabel.TabIndex = 3;
            this.maxVoltageLabel.Text = "Maximum Volatage (V):";
            // 
            // maxCurrentLabel
            // 
            this.maxCurrentLabel.AutoSize = true;
            this.maxCurrentLabel.Location = new System.Drawing.Point(5, 104);
            this.maxCurrentLabel.Name = "maxCurrentLabel";
            this.maxCurrentLabel.Size = new System.Drawing.Size(107, 13);
            this.maxCurrentLabel.TabIndex = 2;
            this.maxCurrentLabel.Text = "Maximum Current (A):";
            // 
            // kvLabel
            // 
            this.kvLabel.AutoSize = true;
            this.kvLabel.Location = new System.Drawing.Point(4, 43);
            this.kvLabel.Name = "kvLabel";
            this.kvLabel.Size = new System.Drawing.Size(90, 13);
            this.kvLabel.TabIndex = 0;
            this.kvLabel.Text = "Motor kV (rpm/v):";
            // 
            // AddMotorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.motorGroupBox);
            this.Name = "AddMotorPanel";
            this.Size = new System.Drawing.Size(332, 344);
            this.motorGroupBox.ResumeLayout(false);
            this.motorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox motorGroupBox;
        private System.Windows.Forms.Button motorClearButton;
        private System.Windows.Forms.Button motorAddButton;
        private System.Windows.Forms.ComboBox maxCellComboBox;
        private System.Windows.Forms.TextBox kvTextBox;
        private System.Windows.Forms.TextBox escTextBox;
        private System.Windows.Forms.Label maxPowerLabel;
        private System.Windows.Forms.Label escLabel;
        private System.Windows.Forms.Label maxCellLabel;
        private System.Windows.Forms.Label minCellLabel;
        private System.Windows.Forms.TextBox maxVoltageTextBox;
        private System.Windows.Forms.TextBox maxCurrentTextBox;
        private System.Windows.Forms.ComboBox minCellComboBox;
        private System.Windows.Forms.TextBox maxPowerTextBox;
        private System.Windows.Forms.Label maxVoltageLabel;
        private System.Windows.Forms.Label maxCurrentLabel;
        private System.Windows.Forms.Label kvLabel;
    }
}
