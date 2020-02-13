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
            this.uxPanel01 = new System.Windows.Forms.Panel();
            this.uxPanelTitle = new System.Windows.Forms.Label();
            this.uxPanel01.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPanel01
            // 
            this.uxPanel01.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel01.Controls.Add(this.uxPanelTitle);
            this.uxPanel01.Location = new System.Drawing.Point(8, 8);
            this.uxPanel01.Name = "uxPanel01";
            this.uxPanel01.Padding = new System.Windows.Forms.Padding(8);
            this.uxPanel01.Size = new System.Drawing.Size(980, 554);
            this.uxPanel01.TabIndex = 1;
            this.uxPanel01.Tag = "WizardStep_1";
            // 
            // uxPanelTitle
            // 
            this.uxPanelTitle.AutoSize = true;
            this.uxPanelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxPanelTitle.ForeColor = System.Drawing.Color.Black;
            this.uxPanelTitle.Location = new System.Drawing.Point(11, 8);
            this.uxPanelTitle.Name = "uxPanelTitle";
            this.uxPanelTitle.Size = new System.Drawing.Size(191, 41);
            this.uxPanelTitle.TabIndex = 1;
            this.uxPanelTitle.Text = "{description}";
            // 
            // PanelHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.uxPanel01);
            this.Name = "PanelHolder";
            this.Text = "PanelHolder";
            this.uxPanel01.ResumeLayout(false);
            this.uxPanel01.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxPanel01;
        private System.Windows.Forms.Label uxPanelTitle;
    }
}