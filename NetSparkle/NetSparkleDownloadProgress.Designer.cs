﻿namespace NetSparkle
{
    /// <summary>
    /// A progress bar
    /// </summary>
    partial class NetSparkleDownloadProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetSparkleDownloadProgress));
            this.lblHeader = new System.Windows.Forms.Label();
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.btnInstallAndReLaunch = new System.Windows.Forms.Button();
            this.imgAppIcon = new System.Windows.Forms.PictureBox();
            this.downloadProgressLbl = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // progressDownload
            // 
            resources.ApplyResources(this.progressDownload, "progressDownload");
            this.progressDownload.Name = "progressDownload";
            // 
            // btnInstallAndReLaunch
            // 
            resources.ApplyResources(this.btnInstallAndReLaunch, "btnInstallAndReLaunch");
            this.btnInstallAndReLaunch.Name = "btnInstallAndReLaunch";
            this.btnInstallAndReLaunch.UseVisualStyleBackColor = true;
            this.btnInstallAndReLaunch.Click += new System.EventHandler(this.OnInstallAndReLaunchClick);
            // 
            // imgAppIcon
            // 
            this.imgAppIcon.Image = global::NetSparkle.Properties.Resources.software_update_available1;
            resources.ApplyResources(this.imgAppIcon, "imgAppIcon");
            this.imgAppIcon.Name = "imgAppIcon";
            this.imgAppIcon.TabStop = false;
            // 
            // downloadProgressLbl
            // 
            resources.ApplyResources(this.downloadProgressLbl, "downloadProgressLbl");
            this.downloadProgressLbl.Name = "downloadProgressLbl";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NetSparkleDownloadProgress
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnInstallAndReLaunch);
            this.Controls.Add(this.downloadProgressLbl);
            this.Controls.Add(this.progressDownload);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.imgAppIcon);
            this.MaximizeBox = false;
            this.Name = "NetSparkleDownloadProgress";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.imgAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ProgressBar progressDownload;
        private System.Windows.Forms.Button btnInstallAndReLaunch;
        private System.Windows.Forms.PictureBox imgAppIcon;
        private System.Windows.Forms.Label downloadProgressLbl;
        private System.Windows.Forms.Button buttonCancel;
    }
}