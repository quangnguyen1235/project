using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HarpstoreWeb.Common
{
    public static class ApiHelper<T> where T : class
    {
        public static T HttpGetAsync(string apiUrl, string method = "GET")
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
            httpWebRequest.Method = method;
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader sr = new StreamReader(responseStream);
                    {
                        responseData = sr.ReadToEnd();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                return JsonConvert.DeserializeObject<T>(responseData);
            }
        }
    }
}
