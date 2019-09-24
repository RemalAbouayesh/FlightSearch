using FlightFinder.Entities;
using FlightFinder.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFinder.Integration
{
    public interface IClientProvider
    {
        IEnumerable<DataItem> GetData(string origin, string dest);
    }
}
