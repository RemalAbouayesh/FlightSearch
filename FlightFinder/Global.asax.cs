using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using FlightFinder.Services;
using FlightFinder.Integration;

namespace FlightFinder
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IFlightsSearch>().To<FlightsSearch>().InTransientScope();
            kernel.Bind<IClientProvider>().To<FlightFinderClient>().InTransientScope();
            return kernel;
        }
    }
}
