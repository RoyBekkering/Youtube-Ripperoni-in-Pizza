using System.Collections.Generic;

namespace Youtube_Ripperoni_in_Pizza.Models
{
    internal class VideoInformation
    {
        public IEnumerable<int> Resolutions { get; set; }

        public IEnumerable<YoutubeExtractor.VideoType> VideoTypes { get; set; }

        public IEnumerable<YoutubeExtractor.AudioType> AudioTypes { get; set; }
    }
}