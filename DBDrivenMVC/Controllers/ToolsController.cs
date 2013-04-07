using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using System.Web;
using System.Web.Mvc;
using DBDrivenMVC;

namespace MvcAltRouting.Controllers
{
	public class ToolsController : Controller
	{
		public void Index()
		{
			// Add action logic here
		}

		public void ResetRoutes()
		{
			Routing.ResetAppRoutes();
			DisplayRoutes();
		}

		public ActionResult DisplayRoutes()
		{
			ViewData["routes"] = Routing.Routes;
			return View("DisplayRoutes");
		}
	}
}
