using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace FlightFinder.Helpers
{
    public static class HttpHelper
    {
        public static string SendGetRequest(string requestUrl)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Headers.Add("Authorization", "Bearer 89EF8594E2EA6756BAC84D26D75F8");
            request.Headers.Add("From", "test@domain.com");
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }
    }
}