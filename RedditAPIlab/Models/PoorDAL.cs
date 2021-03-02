using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditAPIlab.Models
{
    public class PoorDAL
    {
        public string GetData(string poorSub)
        {
            string url = @$"https://www.reddit.com/r/{poorSub}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            //Anytime you need setup, it goes after your request
            //Indentifying info for the user, as well as what browser/device is making the request
            //request.UserAgent = "(grandcircus.co, tommy@grandcircus.co)";

            // Many APIs will want a certain header to work
            //request.Headers.Add();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();

            return JSON;
        }

        public PoorSubRoot ConvertToPoor(string s)
        {
            string poorSubData = GetData(s);
            PoorSubRoot w = JsonConvert.DeserializeObject<PoorSubRoot>(poorSubData);
            return w;
        }
    }
}
