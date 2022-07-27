using System;

namespace RssFeedNotifier
{
    public class FeedInfo
    {
        public string Titel { get; set; }
        public string Link { get; set; }

        public DateTimeOffset PublishDate { get; set; }
        public DateTimeOffset LastUpdatedDate { get; set; }

        public int TotalPostCount { get; set; }
    }
}
