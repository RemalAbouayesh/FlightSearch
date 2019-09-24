using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlightFinder.Integration;
using FlightFinder.Services.Entities;

namespace FlightFinder.Services
{
    public class FlightsSearch : IFlightsSearch
    {
        private readonly IClientProvider _flightFinderProvider;

        public FlightsSearch(IClientProvider flightFinderClient)
        {
            _flightFinderProvider = flightFinderClient;
        }
        public IEnumerable<Flight> Search(string origin, string destination)
        {
            return (IEnumerable<Flight>)_flightFinderProvider.GetData(origin, destination);
        }
    }
}