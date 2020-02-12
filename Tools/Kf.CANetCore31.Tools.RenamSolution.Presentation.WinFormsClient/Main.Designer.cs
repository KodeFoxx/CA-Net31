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
            this.uxClose = new System.Windows.Forms.Button();
            this.uxBody = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).BeginInit();
            this.uxBottom.SuspendLayout();
            this.uxBody.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.uxHeader.Name = "uxHeader";
            this.uxHeader.Size = new System.Drawing.Size(903, 100);
            this.uxHeader.TabIndex = 0;
            // 
            // uxBrandLink
            // 
            this.uxBrandLink.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.uxBrandLink.AutoSize = true;
            this.uxBrandLink.LinkColor = System.Drawing.Color.Black;
            this.uxBrandLink.Location = new System.Drawing.Point(93, 72);
            this.uxBrandLink.Name = "uxBrandLink";
            this.uxBrandLink.Size = new System.Drawing.Size(171, 15);
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
            this.uxProductBuildVersion.Location = new System.Drawing.Point(93, 47);
            this.uxProductBuildVersion.Name = "uxProductBuildVersion";
            this.uxProductBuildVersion.Size = new System.Drawing.Size(94, 15);
            this.uxProductBuildVersion.TabIndex = 1;
            this.uxProductBuildVersion.Text = "{productversion}";
            // 
            // uxHeaderTitle
            // 
            this.uxHeaderTitle.AutoSize = true;
            this.uxHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxHeaderTitle.ForeColor = System.Drawing.Color.Black;
            this.uxHeaderTitle.Location = new System.Drawing.Point(88, 20);
            this.uxHeaderTitle.Name = "uxHeaderTitle";
            this.uxHeaderTitle.Size = new System.Drawing.Size(208, 32);
            this.uxHeaderTitle.TabIndex = 1;
            this.uxHeaderTitle.Text = "Solution Renamer";
            // 
            // uxLogo
            // 
            this.uxLogo.Location = new System.Drawing.Point(12, 12);
            this.uxLogo.Name = "uxLogo";
            this.uxLogo.Size = new System.Drawing.Size(75, 75);
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
            this.uxBottom.Location = new System.Drawing.Point(0, 609);
            this.uxBottom.Name = "uxBottom";
            this.uxBottom.Size = new System.Drawing.Size(903, 50);
            this.uxBottom.TabIndex = 1;
            // 
            // uxClose
            // 
            this.uxClose.Location = new System.Drawing.Point(816, 15);
            this.uxClose.Name = "uxClose";
            this.uxClose.Size = new System.Drawing.Size(75, 23);
            this.uxClose.TabIndex = 0;
            this.uxClose.Text = "&Close";
            this.uxClose.UseVisualStyleBackColor = true;
            this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
            // 
            // uxBody
            // 
            this.uxBody.Controls.Add(this.tabControl1);
            this.uxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxBody.Location = new System.Drawing.Point(0, 100);
            this.uxBody.Name = "uxBody";
            this.uxBody.Padding = new System.Windows.Forms.Padding(16);
            this.uxBody.Size = new System.Drawing.Size(903, 509);
            this.uxBody.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(70, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 15);
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "KodeFoxx";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Solution";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(903, 659);
            this.Controls.Add(this.uxBody);
            this.Controls.Add(this.uxBottom);
            this.Controls.Add(this.uxHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

