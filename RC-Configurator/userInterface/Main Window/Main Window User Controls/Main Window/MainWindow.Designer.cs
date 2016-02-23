

using System;
using RC_Configurator.userInterface;

namespace RC_Configurator
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aircraftPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.aircraftInfoPanel = new System.Windows.Forms.Panel();
            this.componentPage = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.aircraftPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.aircraftPage);
            this.tabControl1.Controls.Add(this.componentPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1295, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // aircraftPage
            // 
            this.aircraftPage.Controls.Add(this.splitContainer1);
            this.aircraftPage.Controls.Add(this.aircraftInfoPanel);
            this.aircraftPage.Location = new System.Drawing.Point(4, 22);
            this.aircraftPage.Name = "aircraftPage";
            this.aircraftPage.Padding = new System.Windows.Forms.Padding(3);
            this.aircraftPage.Size = new System.Drawing.Size(1287, 739);
            this.aircraftPage.TabIndex = 0;
            this.aircraftPage.Text = "tabPage1";
            this.aircraftPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Size = new System.Drawing.Size(882, 736);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 1;
            // 
            // aircraftInfoPanel
            // 
            this.aircraftInfoPanel.Location = new System.Drawing.Point(888, 6);
            this.aircraftInfoPanel.Name = "aircraftInfoPanel";
            this.aircraftInfoPanel.Size = new System.Drawing.Size(399, 730);
            this.aircraftInfoPanel.TabIndex = 0;
            // 
            // componentPage
            // 
            this.componentPage.Location = new System.Drawing.Point(4, 22);
            this.componentPage.Name = "componentPage";
            this.componentPage.Padding = new System.Windows.Forms.Padding(3);
            this.componentPage.Size = new System.Drawing.Size(1287, 739);
            this.componentPage.TabIndex = 1;
            this.componentPage.Text = "tabPage2";
            this.componentPage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1291, 765);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "RC Configurator V1.0";
            this.tabControl1.ResumeLayout(false);
            this.aircraftPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aircraftPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel aircraftInfoPanel;
        private System.Windows.Forms.TabPage componentPage;

        

        

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

