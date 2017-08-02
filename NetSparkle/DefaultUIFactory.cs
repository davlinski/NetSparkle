﻿using System;
using System.Drawing;
using System.Windows.Forms;
using NetSparkle.Interfaces;
using NetSparkle.Properties;

namespace NetSparkle
{
    /// <summary>
    /// UI factory for default interface
    /// </summary>
    public class DefaultUIFactory : IUIFactory
    {
        /// <summary>
        /// Create sparkle form implementation
        /// </summary>
        /// <param name="sparkle">The <see cref="Sparkle"/> instance to use</param>
        /// <param name="updates">Sorted array of updates from latest to earliest</param>
        /// <param name="applicationIcon">The icon to display</param>
        /// <param name="isUpdateAlreadyDownloaded">If true, make sure UI text shows that the user is about to install the file instead of download it.</param>
        public virtual IUpdateAvailable CreateSparkleForm(Sparkle sparkle, AppCastItem[] updates, Icon applicationIcon, bool isUpdateAlreadyDownloaded = false)
        {
            return new UpdateAvailableWindow(sparkle, updates, applicationIcon, isUpdateAlreadyDownloaded);
        }

        /// <summary>
        /// Create download progress window
        /// </summary>
        /// <param name="item">Appcast item to download</param>
        /// <param name="applicationIcon">Application icon to use</param>
        public virtual IDownloadProgress CreateProgressWindow(AppCastItem item, Icon applicationIcon)
        {
            return new DownloadProgressWindow(item, applicationIcon);
        }

        /// <summary>
        /// Initialize UI. Called when Sparkle is constructed.
        /// </summary>
        public virtual void Init()
        {
            // enable visual style to ensure that we have XP style or higher
            // also in WPF applications
            Application.EnableVisualStyles();
        }

        /// <summary>
        /// Show user a message saying downloaded update format is unknown
        /// </summary>
        /// <param name="downloadFileName">The filename to be inserted into the message text</param>
        /// <param name="applicationIcon">The icon to display</param>
        public virtual void ShowUnknownInstallerFormatMessage(string downloadFileName, Icon applicationIcon = null)
        {
            ShowMessage(Resources.DefaultUIFactory_MessageTitle, 
                string.Format(Resources.DefaultUIFactory_ShowUnknownInstallerFormatMessageText, downloadFileName), applicationIcon);
        }

        /// <summary>
        /// Show user that current installed version is up-to-date
        /// </summary>
        public virtual void ShowVersionIsUpToDate(Icon applicationIcon = null)
        {
            ShowMessage(Resources.DefaultUIFactory_MessageTitle, Resources.DefaultUIFactory_ShowVersionIsUpToDateMessage, applicationIcon);
        }

        /// <summary>
        /// Show message that latest update was skipped by user
        /// </summary>
        public virtual void ShowVersionIsSkippedByUserRequest(Icon applicationIcon = null)
        {
            ShowMessage(Resources.DefaultUIFactory_MessageTitle, Resources.DefaultUIFactory_ShowVersionIsSkippedByUserRequestMessage, applicationIcon);
        }

        /// <summary>
        /// Show message that appcast is not available
        /// </summary>
        /// <param name="appcastUrl">the URL for the appcast file</param>
        /// <param name="applicationIcon">The icon to display</param>
        public virtual void ShowCannotDownloadAppcast(string appcastUrl, Icon applicationIcon = null)
        {
            ShowMessage(Resources.DefaultUIFactory_ErrorTitle, Resources.DefaultUIFactory_ShowCannotDownloadAppcastMessage, applicationIcon);
        }

        /// <summary>
        /// Show 'toast' window to notify new version is available
        /// </summary>
        /// <param name="updates">Appcast updates</param>
        /// <param name="applicationIcon">Icon to use in window</param>
        /// <param name="clickHandler">handler for click</param>
        public virtual void ShowToast(AppCastItem[] updates, Icon applicationIcon, Action<AppCastItem[]> clickHandler)
        {
            var toast = new ToastNotifier
                {
                    Image =
                        {
                            Image = applicationIcon != null ? applicationIcon.ToBitmap() : Resources.software_update_available1
                        }
                };
            toast.ToastClicked += (sender, args) => clickHandler(updates); // TODO: this is leak
            toast.Show(Resources.DefaultUIFactory_ToastMessage, Resources.DefaultUIFactory_ToastCallToAction, 5);
        }

        /// <summary>
        /// Show message on download error
        /// </summary>
        /// <param name="message">Error message from exception</param>
        /// <param name="appcastUrl">the URL for the appcast file</param>
        /// <param name="applicationIcon">The icon to display</param>
        public virtual void ShowDownloadErrorMessage(string message, string appcastUrl, Icon applicationIcon = null)
        {
            ShowMessage(Resources.DefaultUIFactory_ErrorTitle, string.Format(Resources.DefaultUIFactory_ShowDownloadErrorMessage, message), applicationIcon);
        }

        private void ShowMessage(string title, string message, Icon applicationIcon = null)
        {
            var messageWindow = new MessageNotificationWindow(title, message, applicationIcon);
            messageWindow.StartPosition = FormStartPosition.CenterScreen;
            messageWindow.ShowDialog();
        }
    }
}
