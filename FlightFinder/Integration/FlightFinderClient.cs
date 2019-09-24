using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlightFinder.Entities;
using FlightFinder.Helpers;
using FlightFinder.Services.Entities;

namespace FlightFinder.Integration
{
    public class FlightFinderClient : IClientProvider
    {
        //Can be added to config file
        private const string apiUrl = "http://flightsearch/api/flights/{0}/{1}/{2}";

        public IEnumerable<DataItem> GetData(string origin, string dest)
        {
            var requestUrl = string.Format(apiUrl, origin, dest, 1);
            var response = HttpHelper.SendGetRequest(requestUrl);

            //Deserialize to flight object
            return new List<Flight>();

        }
    }
}