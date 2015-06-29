using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeAPI.Model;
using YoutubeExtractor;

namespace Youtube_Ripperoni_in_Pizza.Models
{
    public class Video
    {
        public Item Item { get; set; }

        public IEnumerable<VideoInfo> VideoInfos { get; set; }
    }
}
