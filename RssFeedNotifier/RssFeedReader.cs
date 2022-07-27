using RssFeedNotifier.models;
using SimpleFeedReader;
using System.Collections.Generic;
using System.Linq;

namespace RssFeedNotifier
{
    public class RssFeedReader
    {
        #region Singleton
        private static RssFeedReader instance = null;
        private static readonly object padlock = new object();

        public static RssFeedReader Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RssFeedReader();
                    }
                    return instance;
                }
            }
        }
        #endregion

        private FeedReader reader;

        private RssFeedReader()
        {
            reader = new FeedReader();
        }

        public FeedInfo GetRssFeedOf(RssSource rssSource)
        {
            var items = new List<FeedItem>(reader.RetrieveFeed(rssSource.RssUrl));

            if(items.Count == 0)
            {
                throw new FeedEmptyException($"Given feedurl {rssSource.RssUrl} is invalid or points to empty feed!");
            }

            var firstPost = items.First();
            var latestPost = items.Last();

            return new FeedInfo
            {
                Link = rssSource.MainUrl,
                Titel = latestPost.Title, 
                PublishDate = firstPost.PublishDate,
                LastUpdatedDate = latestPost.LastUpdatedDate,
                TotalPostCount = items.Count
            };
        }
    }
}
