﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSparkle
{
    /// <summary>
    /// The checking for updates window
    /// </summary>
    public partial class CheckingForUpdatesWindow : Form
    {
        /// <summary>
        /// Default constructor for CheckingForUpdatesWindow
        /// </summary>
        public CheckingForUpdatesWindow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /// <summary>
        /// Initializes window and sets the icon to <paramref name="applicationIcon"/>
        /// </summary>
        /// <param name="applicationIcon">The icon to use</param>
        public CheckingForUpdatesWindow(Icon applicationIcon = null)
        {
            InitializeComponent();
            if (applicationIcon != null)
            {
                Icon = applicationIcon;
                iconImage.Image = new Icon(applicationIcon, new Size(48, 48)).ToBitmap();
            }
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate () { Close(); });
            }
            else
            {
                Close();
            }
        }
    }
}
