using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeAPI.Model
{
    class Result
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public object pageInfo { get; set; }
        public List<Item> items { get; set; }
    }
}
