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
            this.uxPanel03 = new System.Windows.Forms.Panel();
            this.uxStep03Title = new System.Windows.Forms.Label();
            this.uxStep03IntroText = new System.Windows.Forms.Label();
            this.uxSolutionOldName = new System.Windows.Forms.Label();
            this.uxStep02Title = new System.Windows.Forms.Label();
            this.uxBrowseSolutionPath = new System.Windows.Forms.Button();
            this.uxSolutionPath = new System.Windows.Forms.TextBox();
            this.uxBrowseSolutionPathLabel = new System.Windows.Forms.Label();
            this.uxStep01Title = new System.Windows.Forms.Label();
            this.uxPanel01 = new System.Windows.Forms.Panel();
            this.uxPanel02 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxPanel04 = new System.Windows.Forms.Panel();
            this.uxStep04IntroText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxPanel05 = new System.Windows.Forms.Panel();
            this.uxStep05Title = new System.Windows.Forms.Label();
            this.uxStep05IntroText = new System.Windows.Forms.Label();
            this.uxPanel03.SuspendLayout();
            this.uxPanel01.SuspendLayout();
            this.uxPanel02.SuspendLayout();
            this.uxPanel04.SuspendLayout();
            this.uxPanel05.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPanel03
            // 
            this.uxPanel03.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel03.Controls.Add(this.uxStep03Title);
            this.uxPanel03.Controls.Add(this.uxStep03IntroText);
            this.uxPanel03.Location = new System.Drawing.Point(7, 426);
            this.uxPanel03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPanel03.Name = "uxPanel03";
            this.uxPanel03.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uxPanel03.Size = new System.Drawing.Size(858, 416);
            this.uxPanel03.TabIndex = 1;
            this.uxPanel03.Tag = "WizardStep_3";
            // 
            // uxStep03Title
            // 
            this.uxStep03Title.AutoSize = true;
            this.uxStep03Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStep03Title.ForeColor = System.Drawing.Color.Black;
            this.uxStep03Title.Location = new System.Drawing.Point(10, 6);
            this.uxStep03Title.Name = "uxStep03Title";
            this.uxStep03Title.Size = new System.Drawing.Size(216, 32);
            this.uxStep03Title.TabIndex = 1;
            this.uxStep03Title.Text = "{description} step3";
            // 
            // uxStep03IntroText
            // 
            this.uxStep03IntroText.AutoSize = true;
            this.uxStep03IntroText.Location = new System.Drawing.Point(18, 45);
            this.uxStep03IntroText.Name = "uxStep03IntroText";
            this.uxStep03IntroText.Size = new System.Drawing.Size(60, 15);
            this.uxStep03IntroText.TabIndex = 0;
            this.uxStep03IntroText.Text = "{introtext}";
            // 
            // uxSolutionOldName
            // 
            this.uxSolutionOldName.AutoSize = true;
            this.uxSolutionOldName.Location = new System.Drawing.Point(18, 45);
            this.uxSolutionOldName.Name = "uxSolutionOldName";
            this.uxSolutionOldName.Size = new System.Drawing.Size(142, 15);
            this.uxSolutionOldName.TabIndex = 0;
            this.uxSolutionOldName.Text = "Old name of the solution:";
            // 
            // uxStep02Title
            // 
            this.uxStep02Title.AutoSize = true;
            this.uxStep02Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStep02Title.ForeColor = System.Drawing.Color.Black;
            this.uxStep02Title.Location = new System.Drawing.Point(10, 6);
            this.uxStep02Title.Name = "uxStep02Title";
            this.uxStep02Title.Size = new System.Drawing.Size(216, 32);
            this.uxStep02Title.TabIndex = 1;
            this.uxStep02Title.Text = "{description} step2";
            // 
            // uxBrowseSolutionPath
            // 
            this.uxBrowseSolutionPath.Location = new System.Drawing.Point(766, 62);
            this.uxBrowseSolutionPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxBrowseSolutionPath.Name = "uxBrowseSolutionPath";
            this.uxBrowseSolutionPath.Size = new System.Drawing.Size(82, 23);
            this.uxBrowseSolutionPath.TabIndex = 1;
            this.uxBrowseSolutionPath.Text = "Browse...";
            this.uxBrowseSolutionPath.UseVisualStyleBackColor = true;
            this.uxBrowseSolutionPath.Click += new System.EventHandler(this.uxBrowseSolutionPath_Click);
            // 
            // uxSolutionPath
            // 
            this.uxSolutionPath.Location = new System.Drawing.Point(18, 62);
            this.uxSolutionPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSolutionPath.Name = "uxSolutionPath";
            this.uxSolutionPath.ReadOnly = true;
            this.uxSolutionPath.Size = new System.Drawing.Size(743, 23);
            this.uxSolutionPath.TabIndex = 2;
            // 
            // uxBrowseSolutionPathLabel
            // 
            this.uxBrowseSolutionPathLabel.AutoSize = true;
            this.uxBrowseSolutionPathLabel.Location = new System.Drawing.Point(18, 45);
            this.uxBrowseSolutionPathLabel.Name = "uxBrowseSolutionPathLabel";
            this.uxBrowseSolutionPathLabel.Size = new System.Drawing.Size(171, 15);
            this.uxBrowseSolutionPathLabel.TabIndex = 0;
            this.uxBrowseSolutionPathLabel.Text = "Visual Studio Solution file path:";
            // 
            // uxStep01Title
            // 
            this.uxStep01Title.AutoSize = true;
            this.uxStep01Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStep01Title.ForeColor = System.Drawing.Color.Black;
            this.uxStep01Title.Location = new System.Drawing.Point(10, 6);
            this.uxStep01Title.Name = "uxStep01Title";
            this.uxStep01Title.Size = new System.Drawing.Size(213, 32);
            this.uxStep01Title.TabIndex = 1;
            this.uxStep01Title.Text = "{description} step1";
            // 
            // uxPanel01
            // 
            this.uxPanel01.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel01.Controls.Add(this.uxBrowseSolutionPath);
            this.uxPanel01.Controls.Add(this.uxSolutionPath);
            this.uxPanel01.Controls.Add(this.uxBrowseSolutionPathLabel);
            this.uxPanel01.Controls.Add(this.uxStep01Title);
            this.uxPanel01.Location = new System.Drawing.Point(7, 6);
            this.uxPanel01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPanel01.Name = "uxPanel01";
            this.uxPanel01.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uxPanel01.Size = new System.Drawing.Size(858, 416);
            this.uxPanel01.TabIndex = 1;
            this.uxPanel01.Tag = "WizardStep_1";
            // 
            // uxPanel02
            // 
            this.uxPanel02.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel02.Controls.Add(this.uxSolutionOldName);
            this.uxPanel02.Controls.Add(this.uxStep02Title);
            this.uxPanel02.Location = new System.Drawing.Point(875, 6);
            this.uxPanel02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPanel02.Name = "uxPanel02";
            this.uxPanel02.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uxPanel02.Size = new System.Drawing.Size(858, 416);
            this.uxPanel02.TabIndex = 1;
            this.uxPanel02.Tag = "WizardStep_2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1670, -86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1670, -86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            // 
            // uxPanel04
            // 
            this.uxPanel04.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel04.Controls.Add(this.uxStep04IntroText);
            this.uxPanel04.Controls.Add(this.label3);
            this.uxPanel04.Location = new System.Drawing.Point(875, 426);
            this.uxPanel04.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPanel04.Name = "uxPanel04";
            this.uxPanel04.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uxPanel04.Size = new System.Drawing.Size(858, 416);
            this.uxPanel04.TabIndex = 1;
            this.uxPanel04.Tag = "WizardStep_4";
            // 
            // uxStep04IntroText
            // 
            this.uxStep04IntroText.AutoSize = true;
            this.uxStep04IntroText.Location = new System.Drawing.Point(18, 45);
            this.uxStep04IntroText.Name = "uxStep04IntroText";
            this.uxStep04IntroText.Size = new System.Drawing.Size(60, 15);
            this.uxStep04IntroText.TabIndex = 0;
            this.uxStep04IntroText.Text = "{introtext}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "{description} step4";
            // 
            // uxPanel05
            // 
            this.uxPanel05.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxPanel05.Controls.Add(this.uxStep05Title);
            this.uxPanel05.Controls.Add(this.uxStep05IntroText);
            this.uxPanel05.Location = new System.Drawing.Point(1750, 6);
            this.uxPanel05.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPanel05.Name = "uxPanel05";
            this.uxPanel05.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uxPanel05.Size = new System.Drawing.Size(858, 416);
            this.uxPanel05.TabIndex = 1;
            this.uxPanel05.Tag = "WizardStep_5";
            // 
            // uxStep05Title
            // 
            this.uxStep05Title.AutoSize = true;
            this.uxStep05Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStep05Title.ForeColor = System.Drawing.Color.Black;
            this.uxStep05Title.Location = new System.Drawing.Point(10, 6);
            this.uxStep05Title.Name = "uxStep05Title";
            this.uxStep05Title.Size = new System.Drawing.Size(216, 32);
            this.uxStep05Title.TabIndex = 1;
            this.uxStep05Title.Text = "{description} step5";
            // 
            // uxStep05IntroText
            // 
            this.uxStep05IntroText.AutoSize = true;
            this.uxStep05IntroText.Location = new System.Drawing.Point(18, 45);
            this.uxStep05IntroText.Name = "uxStep05IntroText";
            this.uxStep05IntroText.Size = new System.Drawing.Size(60, 15);
            this.uxStep05IntroText.TabIndex = 0;
            this.uxStep05IntroText.Text = "{introtext}";
            // 
            // PanelHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3364, 796);
            this.Controls.Add(this.uxPanel05);
            this.Controls.Add(this.uxPanel04);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPanel02);
            this.Controls.Add(this.uxPanel03);
            this.Controls.Add(this.uxPanel01);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelHolder";
            this.Text = "PanelHolder";
            this.uxPanel03.ResumeLayout(false);
            this.uxPanel03.PerformLayout();
            this.uxPanel01.ResumeLayout(false);
            this.uxPanel01.PerformLayout();
            this.uxPanel02.ResumeLayout(false);
            this.uxPanel02.PerformLayout();
            this.uxPanel04.ResumeLayout(false);
            this.uxPanel04.PerformLayout();
            this.uxPanel05.ResumeLayout(false);
            this.uxPanel05.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox uxSolutionPath;
        private System.Windows.Forms.Button uxBrowseSolutionPath;
        private System.Windows.Forms.Label uxBrowseSolutionPathLabel;
        private System.Windows.Forms.Label uxStep01Title;
        private System.Windows.Forms.Panel uxPanel01;
        private System.Windows.Forms.Panel uxPanel03;
        private System.Windows.Forms.Label uxSolutionOldName;
        private System.Windows.Forms.Label uxStep02Title;
        private System.Windows.Forms.Panel uxPanel02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel uxPanel04;
        private System.Windows.Forms.Panel uxPanel05;
        private System.Windows.Forms.Label uxStep03Title;
        private System.Windows.Forms.Label uxStep03IntroText;
        private System.Windows.Forms.Label uxStep05Title;
        private System.Windows.Forms.Label uxStep05IntroText;
        private System.Windows.Forms.Label uxStep04IntroText;
        private System.Windows.Forms.Label label3;
    }
}