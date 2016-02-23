namespace RC_Configurator.userInterface.User_Controls
{
    partial class componentInfoUserControl
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
            this.componentInfoBox = new System.Windows.Forms.GroupBox();
            this.weightInfoLabel = new System.Windows.Forms.Label();
            this.typeInfoLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.componentInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentInfoBox
            // 
            this.componentInfoBox.Controls.Add(this.weightInfoLabel);
            this.componentInfoBox.Controls.Add(this.typeInfoLabel);
            this.componentInfoBox.Controls.Add(this.weightLabel);
            this.componentInfoBox.Controls.Add(this.typeLabel);
            this.componentInfoBox.Location = new System.Drawing.Point(3, 3);
            this.componentInfoBox.Name = "componentInfoBox";
            this.componentInfoBox.Size = new System.Drawing.Size(270, 307);
            this.componentInfoBox.TabIndex = 6;
            this.componentInfoBox.TabStop = false;
            this.componentInfoBox.Text = "Component Information";
            // 
            // weightInfoLabel
            // 
            this.weightInfoLabel.AutoSize = true;
            this.weightInfoLabel.Location = new System.Drawing.Point(218, 25);
            this.weightInfoLabel.Name = "weightInfoLabel";
            this.weightInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.weightInfoLabel.TabIndex = 5;
            this.weightInfoLabel.Text = "-";
            // 
            // typeInfoLabel
            // 
            this.typeInfoLabel.AutoSize = true;
            this.typeInfoLabel.Location = new System.Drawing.Point(82, 25);
            this.typeInfoLabel.Name = "typeInfoLabel";
            this.typeInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.typeInfoLabel.TabIndex = 4;
            this.typeInfoLabel.Text = "-";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(151, 25);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(59, 13);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight (g):";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(15, 25);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type:";
            // 
            // componentInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.componentInfoBox);
            this.Location = new System.Drawing.Point(9, 426);
            this.Name = "componentInfoUserControl";
            this.Size = new System.Drawing.Size(281, 317);
            this.componentInfoBox.ResumeLayout(false);
            this.componentInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox componentInfoBox;
        private System.Windows.Forms.Label weightInfoLabel;
        private System.Windows.Forms.Label typeInfoLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label typeLabel;
    }
}
