using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using YH_LAB1.Services.XKCD.Models;

namespace YH_LAB1.Services.XKCD
{
    public class XKCDService : IXKCDService
    {
        private readonly IXKCDConfig config;

        public XKCDService(IXKCDConfig config)
        {
            this.config = config;
        }

        public Comic GetComic(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create($"{this.config.Url}/{id}/info.0.json");
            request.Method = "GET";


            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }

            var comic = JsonConvert.DeserializeObject<Comic>(content);

            return comic;
        }
    }
}
