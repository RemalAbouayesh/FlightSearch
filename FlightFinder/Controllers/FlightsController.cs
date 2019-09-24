using FlightFinder.Models;
using FlightFinder.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightFinder.Controllers
{
    public class FlightsController : Controller
    {
        private IFlightsSearch _flightsSearch;

        public FlightsController(IFlightsSearch flightsSearch)
        {
            _flightsSearch = flightsSearch;
        }

        // GET: Flight
        public ActionResult Index()
        {
            var model = new FlightsSearchModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FlightsSearchModel model)
        {
            var searchResults = _flightsSearch.Search(model.Origin, model.Destination);
            model.Flights = searchResults;
            return View(model);
        }
    }
}