using System.Collections.Generic;
using System.Web;

namespace YoutubeAPI.Classes
{
    public static class URLBuilder
    {
        private const string BASE_URL = "https://www.googleapis.com/youtube/v3/";
        private const string API_KEY = "<YOUR_API_KEY>";

        private const string VIDEOS_URL = "videos";
        private const string CHANNEL_URL = "channels?part=contentDetails";
        private const string PLAYLIST_URL = "playlistItems?part=snippet";

        public static string Search(string searchValue)
        {
            Dictionary<string, string> parameters = new Dictionary<string,string>() {
                { "part", "snippet" },
                { "q", Encode(searchValue) },
                { "maxResults", "25" },
                { "type", "video" },
                { "key", API_KEY }
            };

            return BuildUrl(BASE_URL + "search", parameters);
        }

        private static string Encode(string value)
        {
            return HttpUtility.UrlEncode(value);
        }

        /// <summary>
        /// Builds an url by adding all parameters to the base
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static string BuildUrl(string url, Dictionary<string, string> parameters = null)
        {
            if(parameters != null && parameters.Count > 0) {
                url += "?";
                foreach(KeyValuePair<string, string> parameter in parameters) {
                    url += string.Format("{0}={1}&", parameter.Key, parameter.Value);
                }
                url = url.Remove(url.Length - 1);
            }
            return url;
        }
    }
}
