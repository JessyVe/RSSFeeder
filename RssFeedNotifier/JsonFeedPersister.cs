using Newtonsoft.Json;
using RssFeedNotifier.models;
using System.Collections.Generic;
using System.IO;

namespace RssFeedNotifier
{
    public class JsonFeedPersister 
    {
        public static readonly string LAST_FETCHED_FEED_INFOS = Path.Combine("resources", "feed-infos.json");
        public static readonly string FEEDER_CONFIGURATION = Path.Combine("resources", "feed-sources.json");

        public readonly string FullLastFetchedPath;
        public readonly string FullConfigurationPath;

        public JsonFeedPersister()
        {
            FullLastFetchedPath = Path.Combine(Directory.GetCurrentDirectory(), LAST_FETCHED_FEED_INFOS);
            FullConfigurationPath = Path.Combine(Directory.GetCurrentDirectory(), FEEDER_CONFIGURATION);    
        }

        public void SaveFeedConfigurations(List<RssSource> rssSources)
        {
            var jsonString = JsonConvert.SerializeObject(rssSources, Formatting.Indented);
            File.WriteAllText(FullConfigurationPath, jsonString);
        }

        public List<RssSource> GetConfiguration()
        {
            var fullJsonText = File.ReadAllText(FullConfigurationPath);
            return fullJsonText.Equals("") ? new List<RssSource>() :
                 JsonConvert.DeserializeObject<List<RssSource>>(fullJsonText);
        }

        public void SaveFeeds(List<FeedInfo> feedInfo)
        {
            var jsonString = JsonConvert.SerializeObject(feedInfo, Formatting.Indented);
            File.WriteAllText(FullLastFetchedPath, jsonString);
        }

        public List<FeedInfo> GetAllFeedInfos()
        {
           var fullJsonText = File.ReadAllText(FullLastFetchedPath);
           return fullJsonText.Equals("") ? new List<FeedInfo>() :
                JsonConvert.DeserializeObject<List<FeedInfo>>(fullJsonText);
        }
    }
}
