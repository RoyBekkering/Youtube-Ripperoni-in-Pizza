using System;

namespace YoutubeAPI.Classes
{
    public static class UtilityManager
    {
        public static string ScrapeUploadsID(string response)
        {
            string stringToLookFor = "\"uploads\": \"";
            int startIndex = response.IndexOf(stringToLookFor);
            if(startIndex >= 0) {
                response = response.Substring(startIndex + stringToLookFor.Length);
                int endIndex = response.IndexOf("\"");
                return response.Remove(endIndex);
            }
            return string.Empty;
        }

        /// <summary>
        /// Converts a string in format "PT1H3M22S" to a timespan
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private static TimeSpan ConvertToTimeSpan(string time)
        {
            time = time.Remove(0, 2);

            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            int hourIndication = time.IndexOf('H');
            if(hourIndication >= 0) {
                hours = Convert.ToInt32(time.Substring(0, hourIndication));
                try {
                    time = time.Remove(0, hourIndication + 1);
                }
                catch {
                }
            }
            int minuteIndication = time.IndexOf('M');
            if(minuteIndication >= 0) {
                minutes = Convert.ToInt32(time.Substring(0, minuteIndication));
                try {
                    time = time.Remove(0, minuteIndication + 1);
                }
                catch {
                }
            }
            int secondIndication = time.IndexOf('S');
            if(secondIndication >= 0) {
                seconds = Convert.ToInt32(time.Substring(0, secondIndication));
            }
            return new TimeSpan(hours, minutes, seconds);
        }
    }
}