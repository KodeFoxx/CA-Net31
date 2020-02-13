namespace Kf.CANetCore31.Tools.RenameSolution.Presentation.WinFormsClient
{
    partial class PanelHolder
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
            this.uxPanel02 = new System.Windows.Forms.Panel();
            this.uxBrowseSolutionPath = new System.Windows.Forms.Button();
            this.uxSolutionPath = new System.Windows.Forms.TextBox();
            this.uxBrowseSolutionPathLabel = new System.Windows.Forms.Label();
            this.uxStep01Title = new System.Windows.Forms.Label();
            this.uxPanel01 = new System.Windows.Forms.Panel();
            this.uxPanel01.SuspendLayout();
            this.SuspendLayout();
            //
            // uxBrowseSolutionPath
            //
            this.uxBrowseSolutionPath.Location = new System.Drawing.Point(875, 83);
            this.uxBrowseSolutionPath.Name = "uxBrowseSolutionPath";
            this.uxBrowseSolutionPath.Size = new System.Drawing.Size(94, 27);
            this.uxBrowseSolutionPath.TabIndex = 1;
            this.uxBrowseSolutionPath.Text = "Browse...";
            this.uxBrowseSolutionPath.UseVisualStyleBackColor = true;
            this.uxBrowseSolutionPath.Click += new System.EventHandler(this.uxBrowseSolutionPath_Click);
            //
            // uxSolutionPath
            //
            this.uxSolutionPath.Location = new System.Drawing.Point(20, 83);
            this.uxSolutionPath.Name = "uxSolutionPath";
            this.uxSolutionPath.ReadOnly = true;
            this.uxSolutionPath.Size = new System.Drawing.Size(849, 27);
            this.uxSolutionPath.TabIndex = 2;
            //
            // label1
            //
            this.uxBrowseSolutionPathLabel.AutoSize = true;
            this.uxBrowseSolutionPathLabel.Location = new System.Drawing.Point(20, 60);
            this.uxBrowseSolutionPathLabel.Name = "uxBrowseSolutionPathLabel";
            this.uxBrowseSolutionPathLabel.Size = new System.Drawing.Size(216, 20);
            this.uxBrowseSolutionPathLabel.TabIndex = 0;
            this.uxBrowseSolutionPathLabel.Text = "Visual Studio Solution file path:";
            //
            // uxStep01Title
            //
            this.uxStep01Title.AutoSize = true;
            this.uxStep01Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStep01Title.ForeColor = System.Drawing.Color.Black;
            this.uxStep01Title.Location = new System.Drawing.Point(11, 8);
            this.uxStep01Title.Name = "uxStep01Title";
            this.uxStep01Title.Size = new System.Drawing.Size(191, 41);
            this.uxStep01Title.TabIndex = 1;
            this.uxStep01Title.Text = "{description}";
            //
            // uxPanel01
            //
            this.uxPanel01.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel01.Controls.Add(this.uxBrowseSolutionPath);
            this.uxPanel01.Controls.Add(this.uxSolutionPath);
            this.uxPanel01.Controls.Add(this.uxBrowseSolutionPathLabel);
            this.uxPanel01.Controls.Add(this.uxStep01Title);
            this.uxPanel01.Location = new System.Drawing.Point(8, 568);
            this.uxPanel01.Name = "uxPanel01";
            this.uxPanel01.Padding = new System.Windows.Forms.Padding(8);
            this.uxPanel01.Size = new System.Drawing.Size(980, 554);
            this.uxPanel01.TabIndex = 1;
            this.uxPanel01.Tag = "WizardStep_1";
            //
            // uxPanel02
            //
            this.uxPanel02.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel02.Location = new System.Drawing.Point(8, 8);
            this.uxPanel02.Name = "uxPanel02";
            this.uxPanel02.Padding = new System.Windows.Forms.Padding(8);
            this.uxPanel02.Size = new System.Drawing.Size(980, 554);
            this.uxPanel02.TabIndex = 1;
            this.uxPanel02.Tag = "WizardStep_2";
            //
            // PanelHolder
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1292);
            this.Controls.Add(this.uxPanel02);
            this.Controls.Add(this.uxPanel01);
            this.Name = "PanelHolder";
            this.Text = "PanelHolder";
            this.uxPanel01.ResumeLayout(false);
            this.uxPanel01.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxSolutionPath;
        private System.Windows.Forms.Button uxBrowseSolutionPath;
        private System.Windows.Forms.Label uxBrowseSolutionPathLabel;
        private System.Windows.Forms.Label uxStep01Title;
        private System.Windows.Forms.Panel uxPanel01;
        private System.Windows.Forms.Panel uxPanel02;
    }
}