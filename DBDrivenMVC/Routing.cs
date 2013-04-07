using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DBDrivenMVC.Models;

namespace DBDrivenMVC
{
    internal class Routing
    {
        public static RouteCollection Routes
        {
            get { return RouteTable.Routes; }
        }

        public static List<MVCRoute> GetConfiguredRoutes()
        {
            RoutesClassDataContext db = new RoutesClassDataContext();
            List<MVCRoute> dbRoutes = (from b in db.MVCRoutes
                                       where b.isActive == true
                                       orderby b.routeOrder
                                       select b).ToList();
            return dbRoutes;
        }

        public static void ResetAppRoutes()
        {
            Routes.Clear();
            SetAppRoutes();
        }

        public static void SetAppRoutes()
        {
            List<MVCRoute> configuredRoutes = GetConfiguredRoutes();
            SetAppRoutes(configuredRoutes);
        }

        public static void SetAppRoutes(List<MVCRoute> configuredRoutes)
        {
            //add the routes to the RouteCollection
            foreach (MVCRoute route in configuredRoutes)
            {
                //create RouteValueDictionary objects to add the default values and contraints to the route
                RouteValueDictionary constraints = new RouteValueDictionary();
                RouteValueDictionary routeVals = new RouteValueDictionary();

                foreach (MVCroutesParam param in route.MVCroutesParams)
                {
                    routeVals.Add(param.paramKey, param.paramValue);
                    if (!string.IsNullOrEmpty(param.paramContraint))
                    {
                        constraints.Add(param.paramKey, param.paramContraint);
                    }
                }

                //create the route using the defaults set above
                RouteTable.Routes.Add(new Route(route.routePattern, new MvcRouteHandler())
                {
                    Defaults = routeVals,
                    Constraints = constraints
                });
            }
        }

    }
}