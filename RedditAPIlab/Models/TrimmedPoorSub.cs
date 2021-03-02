using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPIlab.Models
{
    public class TrimmedPoorSub
    {
        public string Title { get; set; }
        public string  ImageUrl { get; set; }
        public string Link { get; set; }

        public TrimmedPoorSub()
        {

        }

        public TrimmedPoorSub(string Title, string ImageUrl, string Link)
        {
            this.Title = Title;
            this.ImageUrl = ImageUrl;
            this.Link = Link;
        }
    }


}
