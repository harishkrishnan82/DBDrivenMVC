using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBDrivenMVC;
using DBDrivenMVC.Models;

namespace DBDrivenMVC.Controllers
{
    public class TemplateController : Controller
    {
        //
        // GET: /Template/

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

       
        public ActionResult Details(string id)
        {
            string RouteName = id;
            int RouteID = 0;
            string ViewName;

            if (!string.IsNullOrEmpty(RouteName))
            {

                //Check if Valid Route 
                RouteID = HarvestTemplates.GetRouteID(RouteName);

                if (RouteID != 0)
                {
                    if (RouteID != 4)
                    {
                        IPhoneClass lsTempInfo = HarvestTemplates.GetTemplateData(RouteID);

                        ViewName = lsTempInfo.TemplateInfos.TempName;

                        return View(ViewName, lsTempInfo);
                    }
                    else
                    {
                        AspNetOneClass lsTempInfo = HarvestTemplates.GetTemplateDataforASPNETONE(RouteID);

                        ViewName = lsTempInfo.TemplateInfos.TempName;

                        return View(ViewName, lsTempInfo);
                    }
                }
                else
                {
                    //No Route Found 
                    ViewName = "Error";
                }

            }
            else
            {
                //First Page Load - Send the user back to Home Page itself..atsalavista
                ViewName = "";
                return RedirectToAction("About", "Home");

            }

            return View(ViewName);
        }

        

        
    }
}
