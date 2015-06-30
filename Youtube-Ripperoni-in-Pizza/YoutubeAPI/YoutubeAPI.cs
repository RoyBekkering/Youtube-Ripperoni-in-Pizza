using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeAPI.Classes;
using YoutubeAPI.Model;

namespace YoutubeAPI
{
    public static class YoutubeAPI
    {
        public static List<Item> Search(string searchValue)
        {
            string response = NetworkManager.GetResponse(URLBuilder.Search(searchValue));
            if(response.Length > 0) {
                return JsonConvert.DeserializeObject<Result>(response).items;
            }
            return null;
        }
    }
}