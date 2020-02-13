using System.Drawing;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxHeader = new System.Windows.Forms.Panel();
            this.uxBrandLink = new System.Windows.Forms.LinkLabel();
            this.uxProductBuildVersion = new System.Windows.Forms.Label();
            this.uxHeaderTitle = new System.Windows.Forms.Label();
            this.uxLogo = new System.Windows.Forms.PictureBox();
            this.uxBottom = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxClose = new System.Windows.Forms.Button();
            this.uxBody = new System.Windows.Forms.Panel();
            this.uxWizardHost = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxStepInfo = new System.Windows.Forms.Label();
            this.uxStepCount = new System.Windows.Forms.Label();
            this.uxPrevious = new System.Windows.Forms.Button();
            this.uxNext = new System.Windows.Forms.Button();
            this.uxPanelContainer = new System.Windows.Forms.Panel();
            this.uxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).BeginInit();
            this.uxBottom.SuspendLayout();
            this.uxBody.SuspendLayout();
            this.uxWizardHost.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxHeader
            // 
            this.uxHeader.BackColor = System.Drawing.SystemColors.Control;
            this.uxHeader.Controls.Add(this.uxBrandLink);
            this.uxHeader.Controls.Add(this.uxProductBuildVersion);
            this.uxHeader.Controls.Add(this.uxHeaderTitle);
            this.uxHeader.Controls.Add(this.uxLogo);
            this.uxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxHeader.Location = new System.Drawing.Point(0, 0);
            this.uxHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxHeader.Name = "uxHeader";
            this.uxHeader.Size = new System.Drawing.Size(1032, 133);
            this.uxHeader.TabIndex = 0;
            // 
            // uxBrandLink
            // 
            this.uxBrandLink.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.uxBrandLink.AutoSize = true;
            this.uxBrandLink.LinkColor = System.Drawing.Color.Black;
            this.uxBrandLink.Location = new System.Drawing.Point(106, 96);
            this.uxBrandLink.Name = "uxBrandLink";
            this.uxBrandLink.Size = new System.Drawing.Size(209, 20);
            this.uxBrandLink.TabIndex = 2;
            this.uxBrandLink.TabStop = true;
            this.uxBrandLink.Text = "https://github.com/KodeFoxx/";
            this.uxBrandLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxBrandLink_LinkClicked);
            // 
            // uxProductBuildVersion
            // 
            this.uxProductBuildVersion.AutoSize = true;
            this.uxProductBuildVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxProductBuildVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uxProductBuildVersion.Location = new System.Drawing.Point(106, 63);
            this.uxProductBuildVersion.Name = "uxProductBuildVersion";
            this.uxProductBuildVersion.Size = new System.Drawing.Size(115, 20);
            this.uxProductBuildVersion.TabIndex = 1;
            this.uxProductBuildVersion.Text = "{productversion}";
            // 
            // uxHeaderTitle
            // 
            this.uxHeaderTitle.AutoSize = true;
            this.uxHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxHeaderTitle.ForeColor = System.Drawing.Color.Black;
            this.uxHeaderTitle.Location = new System.Drawing.Point(101, 27);
            this.uxHeaderTitle.Name = "uxHeaderTitle";
            this.uxHeaderTitle.Size = new System.Drawing.Size(263, 41);
            this.uxHeaderTitle.TabIndex = 1;
            this.uxHeaderTitle.Text = "Solution Renamer";
            // 
            // uxLogo
            // 
            this.uxLogo.Location = new System.Drawing.Point(14, 16);
            this.uxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxLogo.Name = "uxLogo";
            this.uxLogo.Size = new System.Drawing.Size(86, 100);
            this.uxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uxLogo.TabIndex = 0;
            this.uxLogo.TabStop = false;
            // 
            // uxBottom
            // 
            this.uxBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uxBottom.Controls.Add(this.linkLabel1);
            this.uxBottom.Controls.Add(this.label1);
            this.uxBottom.Controls.Add(this.uxClose);
            this.uxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxBottom.Location = new System.Drawing.Point(0, 812);
            this.uxBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBottom.Name = "uxBottom";
            this.uxBottom.Size = new System.Drawing.Size(1032, 67);
            this.uxBottom.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(80, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(209, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/KodeFoxx/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxBrandLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KodeFoxx";
            // 
            // uxClose
            // 
            this.uxClose.Location = new System.Drawing.Point(933, 20);
            this.uxClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxClose.Name = "uxClose";
            this.uxClose.Size = new System.Drawing.Size(86, 31);
            this.uxClose.TabIndex = 0;
            this.uxClose.Text = "&Close";
            this.uxClose.UseVisualStyleBackColor = true;
            this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
            // 
            // uxBody
            // 
            this.uxBody.Controls.Add(this.uxWizardHost);
            this.uxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxBody.Location = new System.Drawing.Point(0, 133);
            this.uxBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBody.Name = "uxBody";
            this.uxBody.Padding = new System.Windows.Forms.Padding(18, 21, 18, 21);
            this.uxBody.Size = new System.Drawing.Size(1032, 679);
            this.uxBody.TabIndex = 2;
            // 
            // uxWizardHost
            // 
            this.uxWizardHost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxWizardHost.Controls.Add(this.uxPanelContainer);
            this.uxWizardHost.Controls.Add(this.panel1);
            this.uxWizardHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxWizardHost.Location = new System.Drawing.Point(18, 21);
            this.uxWizardHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxWizardHost.Name = "uxWizardHost";
            this.uxWizardHost.Size = new System.Drawing.Size(996, 637);
            this.uxWizardHost.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.uxStepInfo);
            this.panel1.Controls.Add(this.uxStepCount);
            this.panel1.Controls.Add(this.uxPrevious);
            this.panel1.Controls.Add(this.uxNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 67);
            this.panel1.TabIndex = 0;
            // 
            // uxStepInfo
            // 
            this.uxStepInfo.AutoSize = true;
            this.uxStepInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStepInfo.ForeColor = System.Drawing.Color.Black;
            this.uxStepInfo.Location = new System.Drawing.Point(15, 32);
            this.uxStepInfo.Name = "uxStepInfo";
            this.uxStepInfo.Size = new System.Drawing.Size(186, 15);
            this.uxStepInfo.TabIndex = 1;
            this.uxStepInfo.Text = "Select a Visual Studio solution file";
            // 
            // uxStepCount
            // 
            this.uxStepCount.AutoSize = true;
            this.uxStepCount.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxStepCount.ForeColor = System.Drawing.Color.Black;
            this.uxStepCount.Location = new System.Drawing.Point(15, 19);
            this.uxStepCount.Name = "uxStepCount";
            this.uxStepCount.Size = new System.Drawing.Size(51, 15);
            this.uxStepCount.TabIndex = 1;
            this.uxStepCount.Text = "Step 1/5";
            // 
            // uxPrevious
            // 
            this.uxPrevious.Location = new System.Drawing.Point(770, 19);
            this.uxPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxPrevious.Name = "uxPrevious";
            this.uxPrevious.Size = new System.Drawing.Size(99, 31);
            this.uxPrevious.TabIndex = 0;
            this.uxPrevious.Text = "<< &Previous";
            this.uxPrevious.UseVisualStyleBackColor = true;
            this.uxPrevious.Click += new System.EventHandler(this.uxPrevious_Click);
            // 
            // uxNext
            // 
            this.uxNext.Location = new System.Drawing.Point(877, 19);
            this.uxNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxNext.Name = "uxNext";
            this.uxNext.Size = new System.Drawing.Size(99, 31);
            this.uxNext.TabIndex = 0;
            this.uxNext.Text = "&Next >>";
            this.uxNext.UseVisualStyleBackColor = true;
            this.uxNext.Click += new System.EventHandler(this.uxNext_Click);
            // 
            // uxPanelContainer
            // 
            this.uxPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.uxPanelContainer.Name = "uxPanelContainer";
            this.uxPanelContainer.Padding = new System.Windows.Forms.Padding(8);
            this.uxPanelContainer.Size = new System.Drawing.Size(996, 570);
            this.uxPanelContainer.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1032, 879);
            this.Controls.Add(this.uxBody);
            this.Controls.Add(this.uxBottom);
            this.Controls.Add(this.uxHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient";
            this.Load += new System.EventHandler(this.Main_Load);
            this.uxHeader.ResumeLayout(false);
            this.uxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).EndInit();
            this.uxBottom.ResumeLayout(false);
            this.uxBottom.PerformLayout();
            this.uxBody.ResumeLayout(false);
            this.uxWizardHost.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxHeader;
        private System.Windows.Forms.PictureBox uxLogo;
        private System.Windows.Forms.Panel uxBottom;
        private System.Windows.Forms.Panel uxBody;
        private System.Windows.Forms.Button uxClose;
        private System.Windows.Forms.LinkLabel uxBrandLink;
        private System.Windows.Forms.Label uxHeaderTitle;
        private System.Windows.Forms.Label uxProductBuildVersion;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel uxWizardHost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uxPrevious;
        private System.Windows.Forms.Button uxNext;
        private System.Windows.Forms.Label uxStepInfo;
        private System.Windows.Forms.Label uxStepCount;
        private System.Windows.Forms.Panel uxPanelContainer;
    }
}

