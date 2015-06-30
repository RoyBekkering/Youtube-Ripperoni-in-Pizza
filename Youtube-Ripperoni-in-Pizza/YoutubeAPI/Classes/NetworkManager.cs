using System;
using System.IO;
using System.Net;

namespace YoutubeAPI.Classes
{
    public static class NetworkManager
    {
        public static string GetResponse(string url)
        {
            try {
                WebResponse response = WebRequest.Create(url).GetResponse();
                using(StreamReader sr = new StreamReader(response.GetResponseStream())) {
                    return sr.ReadToEnd();
                }
            }
            catch(Exception ex) {
                Console.WriteLine("[YoutubeAPI WebRequest] URL: " + url + " | Error: " + ex.Message);
                return string.Empty;
            }
        }
    }
}