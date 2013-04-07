using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAltRouting.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View("Index");
		}

        public ActionResult About()
		{
            return View("About");
            
		}
        public ActionResult ParamValue(string id)
        {
            return RedirectToAction("DisplayRoutes", "Tools");
        }
	}
}
