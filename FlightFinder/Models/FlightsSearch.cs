using FlightFinder.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightFinder.Models
{
    public class FlightsSearchModel
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public IEnumerable<Flight> Flights { get; set; }
    }
}