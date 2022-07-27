using System;

namespace RssFeedNotifierUI
{
    partial class RssFeederForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RssFeederForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMainUrl = new System.Windows.Forms.TextBox();
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.btAddFeed = new System.Windows.Forms.Button();
            this.lbMainUrl = new System.Windows.Forms.Label();
            this.lbRssUrl = new System.Windows.Forms.Label();
            this.lbUiNotification = new System.Windows.Forms.Label();
            this.TrayIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "All the RSS!";
            this.notifyIcon.BalloonTipTitle = "RSS Feeder";
            this.notifyIcon.ContextMenuStrip = this.TrayIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "RSS Feeder";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnTrayIconDoubleClicked);
            // 
            // TrayIconMenu
            // 
            this.TrayIconMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshItem,
            this.shutdownItem});
            this.TrayIconMenu.Name = "TrayIconMenu";
            this.TrayIconMenu.Size = new System.Drawing.Size(187, 68);
            this.TrayIconMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.onContextMenuClicked);
            // 
            // refreshItem
            // 
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(186, 32);
            this.refreshItem.Text = "Refresh now!";
            // 
            // shutdownItem
            // 
            this.shutdownItem.Name = "shutdownItem";
            this.shutdownItem.Size = new System.Drawing.Size(186, 32);
            this.shutdownItem.Text = "Shutdown";
            // 
            // tbMainUrl
            // 
            this.tbMainUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMainUrl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMainUrl.Location = new System.Drawing.Point(49, 66);
            this.tbMainUrl.Name = "tbMainUrl";
            this.tbMainUrl.Size = new System.Drawing.Size(580, 37);
            this.tbMainUrl.TabIndex = 1;
            this.tbMainUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTypingStarted);
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRssUrl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRssUrl.Location = new System.Drawing.Point(49, 150);
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(580, 37);
            this.tbRssUrl.TabIndex = 2;
            this.tbRssUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTypingStarted);
            // 
            // btAddFeed
            // 
            this.btAddFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btAddFeed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddFeed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAddFeed.Location = new System.Drawing.Point(49, 233);
            this.btAddFeed.Name = "btAddFeed";
            this.btAddFeed.Size = new System.Drawing.Size(289, 50);
            this.btAddFeed.TabIndex = 3;
            this.btAddFeed.Text = "Add now!";
            this.btAddFeed.UseVisualStyleBackColor = false;
            this.btAddFeed.Click += new System.EventHandler(this.OnAddNewRssFeed);
            // 
            // lbMainUrl
            // 
            this.lbMainUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMainUrl.AutoSize = true;
            this.lbMainUrl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMainUrl.Location = new System.Drawing.Point(49, 31);
            this.lbMainUrl.Name = "lbMainUrl";
            this.lbMainUrl.Size = new System.Drawing.Size(184, 30);
            this.lbMainUrl.TabIndex = 4;
            this.lbMainUrl.Text = "Main URL to Page";
            // 
            // lbRssUrl
            // 
            this.lbRssUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRssUrl.AutoSize = true;
            this.lbRssUrl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRssUrl.Location = new System.Drawing.Point(49, 115);
            this.lbRssUrl.Name = "lbRssUrl";
            this.lbRssUrl.Size = new System.Drawing.Size(174, 30);
            this.lbRssUrl.TabIndex = 5;
            this.lbRssUrl.Text = "URL to RSS Feed";
            // 
            // lbUiNotification
            // 
            this.lbUiNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUiNotification.AutoSize = true;
            this.lbUiNotification.Location = new System.Drawing.Point(361, 247);
            this.lbUiNotification.Name = "lbUiNotification";
            this.lbUiNotification.Size = new System.Drawing.Size(0, 25);
            this.lbUiNotification.TabIndex = 6;
            // 
            // RssFeederForm
            // 
            this.AcceptButton = this.btAddFeed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(693, 313);
            this.Controls.Add(this.lbUiNotification);
            this.Controls.Add(this.lbRssUrl);
            this.Controls.Add(this.lbMainUrl);
            this.Controls.Add(this.btAddFeed);
            this.Controls.Add(this.tbRssUrl);
            this.Controls.Add(this.tbMainUrl);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RssFeederForm";
            this.Opacity = 0.95D;
            this.Text = "RSS Feeder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Shown += new System.EventHandler(this.OnShown);
            this.TrayIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownItem;
        private System.Windows.Forms.TextBox tbMainUrl;
        private System.Windows.Forms.TextBox tbRssUrl;
        private System.Windows.Forms.Button btAddFeed;
        private System.Windows.Forms.Label lbMainUrl;
        private System.Windows.Forms.Label lbRssUrl;
        private System.Windows.Forms.Label lbUiNotification;
    }
}
