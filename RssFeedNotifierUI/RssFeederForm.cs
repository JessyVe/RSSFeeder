using RssFeedNotifier;
using RssFeedNotifier.models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RssFeedNotifierUI
{
    public partial class RssFeederForm : Form
    {
        private FeedNotificationService service;

        public RssFeederForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            service = new FeedNotificationService();
        }

        private void OnShown(object sender, EventArgs e)
        {
            Hide();
        }

        private void onContextMenuClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == refreshItem)
            {
                service.GetFeedNotifications(true);
            }
            else if (e.ClickedItem == quitItem)
            {
                Application.Exit();
            }
        }

        private void OnTrayIconDoubleClicked(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void OnAddNewRssFeed(object sender, EventArgs e)
        {
            string mainUrl = tbMainUrl.Text;
            string rssUrl = tbRssUrl.Text;

            if (mainUrl == null || mainUrl.Equals(string.Empty)
                || rssUrl == null || rssUrl.Equals(string.Empty))
            {
                lbUiNotification.Text = "Both URLs must be provided!";
                return;
            }
            service.AddNewRssSource(new RssSource
            {
                MainUrl = mainUrl,
                RssUrl = rssUrl
            });
            lbUiNotification.Text = "New RSS source persisted!";

            tbMainUrl.Text = string.Empty;
            tbRssUrl.Text = string.Empty;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            Left = workingArea.Left + workingArea.Width - Size.Width;
            Top = workingArea.Top + workingArea.Height - Size.Height;
        }

        private void OnTypingStarted(object sender, KeyEventArgs e)
        {
            lbUiNotification.Text = string.Empty;
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            if(tbMainUrl.Text.Equals(string.Empty))
            {
                lbUiNotification.Text = "Provide main url first.";
                return; 
            }

            tbRssUrl.Enabled = !cbSameAsAbove.Checked;
            tbRssUrl.Text = tbMainUrl.Text; 
        }

        private void OnTypingEnded(object sender, KeyEventArgs e)
        {
            if(cbSameAsAbove.Checked)
            {
                tbRssUrl.Text = tbMainUrl.Text;
            }
        }
    }
}
