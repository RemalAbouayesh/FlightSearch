using FlightFinder.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFinder.Services
{
    public interface IFlightsSearch
    {
        IEnumerable<Flight> Search(string origin, string destination);
    }
}
