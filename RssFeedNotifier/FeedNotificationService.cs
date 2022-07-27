
using CommunityToolkit.WinUI.Notifications;
using RssFeedNotifier.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace RssFeedNotifier
{
    public class FeedNotificationService
    {
        private readonly JsonFeedPersister JsonFeedPersister = new JsonFeedPersister();

        private readonly List<FeedInfo> LastSavedInfos;
        private List<RssSource> FeedConfigurations = new List<RssSource>();

        private readonly Timer UpdateTimer;
        private readonly int UpdateIntervall = 600000; // 10 minutes in milliseconds

        public FeedNotificationService()
        {
            getNewToastBuilder()
               .AddText($"RSS Feeder")
                .AddText($"Is running minimized in the background.")
                .Show();

            LastSavedInfos = JsonFeedPersister.GetAllFeedInfos();
            ReloadConfiguration();

            UpdateTimer = new Timer(UpdateIntervall);
            UpdateTimer.Elapsed += OnUpdateIntervallElasped;
        }

        public void ReloadConfiguration(bool reloaded = false)
        {
            FeedConfigurations = JsonFeedPersister.GetConfiguration();
            getNewToastBuilder()
               .AddText($"RSS Feeder")
                .AddText(reloaded ? $"Configuration reloaded! {FeedConfigurations.Count} Source(s)."
                : $"Configuration loaded! {FeedConfigurations.Count} Source(s) found.")
                .Show();

            GetFeedNotifications();
        }

        public void AddNewRssSource(RssSource rssSource)
        {
            FeedConfigurations.Add(rssSource);
            JsonFeedPersister.SaveFeedConfigurations(FeedConfigurations);
            ReloadConfiguration(true);
        }

        private void OnUpdateIntervallElasped(object source, ElapsedEventArgs e)
        {
            GetFeedNotifications();
        }

        public void GetFeedNotifications(bool manuellTrigger = false)
        {
            var notificationCount = 0;
            foreach (var rssSource in FeedConfigurations)
            {
                var lastInfo = LastSavedInfos.Count == 0 ? null :
                    LastSavedInfos.FirstOrDefault(info => info.Link.Equals(rssSource.MainUrl, StringComparison.Ordinal));

                try
                {
                    var currentInfo = RssFeedReader.Instance.GetRssFeedOf(rssSource);

                    var notificationType = DetermineChange(lastInfo, currentInfo);
                    if (notificationType != NotificationType.NONE)
                    {
                        LastSavedInfos.Remove(lastInfo);
                        LastSavedInfos.Add(currentInfo);
                        JsonFeedPersister.SaveFeeds(LastSavedInfos);

                        var notification = new RssFeedNotification
                        {
                            FeedInfo = currentInfo,
                            NotificationType = notificationType
                        };
                        ShowFeedUpdate(notification);
                        notificationCount++;
                    }
                }
                catch (FeedEmptyException)
                {
                    getNewToastBuilder()
                        .AddText($"Unable to query URL \"{rssSource.RssUrl}\"!")
                        .Show();
                }
            }

            if (notificationCount == 0 && manuellTrigger)
            {
                getNewToastBuilder()
                .AddText($"No new notifications for {FeedConfigurations.Count} sources!")
                .Show();
             }
        }

        private void ShowFeedUpdate(RssFeedNotification notification)
        {
            string notificationText;
            switch (notification.NotificationType)
            {
                case NotificationType.NEW_FEED:
                    notificationText = $"New feed {notification.FeedInfo.Titel} is now monitored!";
                    break;

                case NotificationType.NEW_POST:
                    notificationText = $"Don't miss out on the new post in {notification.FeedInfo.Titel}!";
                    break;

                default:
                    notificationText = $"New Notification for feed {notification.FeedInfo.Titel}";
                    break;
            }

            getNewToastBuilder()
                 .AddText(notificationText)
                .AddButton(new ToastButton()
                    .SetContent("Take Me There!")
                    .SetProtocolActivation(new Uri(notification.FeedInfo.Link))
                )
                .Show();
        }

        private ToastContentBuilder getNewToastBuilder()
        {
            return new ToastContentBuilder()
               .AddArgument("action", "viewConversation")
               .AddArgument("conversationId", 9813);
        }

        private NotificationType DetermineChange(FeedInfo lastInfo, FeedInfo currentInfo)
        {
            if (lastInfo == null)
            {
                return NotificationType.NEW_FEED;
            }
            if (lastInfo.TotalPostCount < currentInfo.TotalPostCount)
            {
                return NotificationType.NEW_POST;
            }
            return NotificationType.NONE;
        }
    }
}
