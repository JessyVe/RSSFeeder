using System;

namespace RssFeedNotifier
{
    public class FeedEmptyException : Exception
    {
        public FeedEmptyException(string message)
        : base(message)
        {
        }
    }
}
