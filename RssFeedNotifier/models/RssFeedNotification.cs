namespace RssFeedNotifier
{
    public class RssFeedNotification
    {
        public FeedInfo FeedInfo { get; set; }

        public NotificationType NotificationType { get; set; }
    }

    public enum NotificationType
    {
        NEW_POST,
        NEW_FEED,
        NONE
    }
}
