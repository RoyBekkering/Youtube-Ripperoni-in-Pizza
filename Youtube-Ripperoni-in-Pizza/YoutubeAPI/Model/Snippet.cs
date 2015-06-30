using System;

namespace YoutubeAPI.Model
{
    public class Snippet
    {
        public DateTime publishedAt { get; set; }

        public string channelId { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public ThumbnailList thumbnails { get; set; }

        public string channelTitle { get; set; }

        public string liveBroadcastContent { get; set; }

        /*public string playlistId { get; set; }

        public string position { get; set; }

        public Resources resourceId { get; set; }

        public TimeSpan duration { get; set; }*/
    }
}