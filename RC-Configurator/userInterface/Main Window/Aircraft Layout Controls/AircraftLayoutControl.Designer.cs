namespace RC_Configurator.userInterface.Main_Window.Main_Window_User_Controls
{
    partial class AircraftLayoutControl
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
            this.newAircraftButton = new System.Windows.Forms.Button();
            this.removeComponents = new System.Windows.Forms.Button();
            this.saveAircraft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAircraftButton
            // 
            this.newAircraftButton.Location = new System.Drawing.Point(381, 589);
            this.newAircraftButton.Name = "newAircraftButton";
            this.newAircraftButton.Size = new System.Drawing.Size(106, 23);
            this.newAircraftButton.TabIndex = 5;
            this.newAircraftButton.Text = "New Aircraft...";
            this.newAircraftButton.UseVisualStyleBackColor = true;
            // 
            // removeComponents
            // 
            this.removeComponents.Location = new System.Drawing.Point(250, 589);
            this.removeComponents.Name = "removeComponents";
            this.removeComponents.Size = new System.Drawing.Size(103, 23);
            this.removeComponents.TabIndex = 4;
            this.removeComponents.Text = "Remove All..";
            this.removeComponents.UseVisualStyleBackColor = true;
            // 
            // saveAircraft
            // 
            this.saveAircraft.Location = new System.Drawing.Point(144, 589);
            this.saveAircraft.Name = "saveAircraft";
            this.saveAircraft.Size = new System.Drawing.Size(75, 23);
            this.saveAircraft.TabIndex = 3;
            this.saveAircraft.Text = "Save...";
            this.saveAircraft.UseVisualStyleBackColor = true;
            // 
            // AircraftLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.newAircraftButton);
            this.Controls.Add(this.removeComponents);
            this.Controls.Add(this.saveAircraft);
            this.Name = "AircraftLayoutControl";
            this.Size = new System.Drawing.Size(603, 656);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newAircraftButton;
        private System.Windows.Forms.Button removeComponents;
        private System.Windows.Forms.Button saveAircraft;
    }
}
