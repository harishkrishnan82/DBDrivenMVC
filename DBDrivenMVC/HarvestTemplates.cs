using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBDrivenMVC.Models;
using DBDrivenMVC.Controllers;


namespace DBDrivenMVC
{
    internal class HarvestTemplates
    {
        public static IPhoneClass GetTemplateData(int  RouteId)
        {
            
                TemplateMapsDataContext dbTempMaps = new TemplateMapsDataContext();
                
                List<TempMapping> dbTemplateInfor = (from b in dbTempMaps.TempMappings
                                                     where b.RouteID == RouteId
                                           select b).ToList();

                return GetViewModal(dbTemplateInfor);

        }

        public static AspNetOneClass GetTemplateDataforASPNETONE(int RouteId)
        {

            TemplateMapsDataContext dbTempMaps = new TemplateMapsDataContext();

            List<TempMapping> dbTemplateInfor = (from b in dbTempMaps.TempMappings
                                                 where b.RouteID == RouteId
                                                 select b).ToList();

            return GetViewModalforASPNETONE(dbTemplateInfor);

        }

        public static IPhoneClass GetViewModal(List<TempMapping> dbTemplateInfo)
        {
            IPhoneClass ClassModel = new IPhoneClass();
            Models.TemplateInfo TemplateINFORDest = new Models.TemplateInfo();

            foreach (TempMapping TempMap in dbTemplateInfo)
            {
               
                if (TempMap.Key == "Title")
                {
                    ClassModel.Title = TempMap.Value;
                }

                if (TempMap.Key == "Heading")
                {
                    ClassModel.Heading = TempMap.Value;
                }


                foreach (DBDrivenMVC.Models.TemplateInfo TemplateINFOR in TempMap.TemplateInfos)
                {


                    TemplateINFORDest.TempID = TemplateINFOR.TempID;
                    TemplateINFORDest.TempName = TemplateINFOR.TempName;
                    TemplateINFORDest.TempPath = TemplateINFOR.TempPath;
                    ClassModel.TemplateInfos = TemplateINFORDest;
                    
                }
            }

           

            return ClassModel;

        }

        public static AspNetOneClass GetViewModalforASPNETONE(List<TempMapping> dbTemplateInfo)
        {
            AspNetOneClass ClassModel = new AspNetOneClass();
            Models.TemplateInfo TemplateINFORDest = new Models.TemplateInfo();

            foreach (TempMapping TempMap in dbTemplateInfo)
            {

                switch (TempMap.Key)
                {
                    case "PageTitle":
                        ClassModel.PageTitle = TempMap.Value;
                        break;
                    case "MainHeading":
                        ClassModel.MainHeading = TempMap.Value;
                        break;
                    case "Heading1":
                        ClassModel.Heading1 = TempMap.Value;
                        break;
                    case "Menu1":
                        ClassModel.Menu1 = TempMap.Value;
                        break;
                    case "Menu2":
                        ClassModel.Menu2 = TempMap.Value;
                        break;
                    case "Menu3":
                        ClassModel.Menu3 = TempMap.Value;
                        break;
                    case "SubMenu1":
                        ClassModel.SubMenu1 = TempMap.Value;
                        break;
                    case "SubMenu2":
                        ClassModel.SubMenu2 = TempMap.Value;
                        break;
                    case "PostHeading":
                        ClassModel.PostHeading = TempMap.Value;
                        break;
                    case "PostContent":
                        ClassModel.PostContent = TempMap.Value;
                        break;
                    case "PostHeading1":
                        ClassModel.PostHeading1 = TempMap.Value;
                        break;
                    case "PostContent1":
                        ClassModel.PostContent1 = TempMap.Value;
                        break;
                    case "SiteFooter":
                        ClassModel.SiteFooter = TempMap.Value;
                        break;
                    case "SiteName":
                        ClassModel.SiteName = TempMap.Value;
                        break;
                    default:
                        break;
                }

                foreach (DBDrivenMVC.Models.TemplateInfo TemplateINFOR in TempMap.TemplateInfos)
                {


                    TemplateINFORDest.TempID = TemplateINFOR.TempID;
                    TemplateINFORDest.TempName = TemplateINFOR.TempName;
                    TemplateINFORDest.TempPath = TemplateINFOR.TempPath;
                    ClassModel.TemplateInfos = TemplateINFORDest;

                }
            }



            return ClassModel;

        }


        public static int GetRouteID(string RouteName)
        {
            TemplateMapsDataContext dbTempMaps = new TemplateMapsDataContext();
            List<RouteInfo> dbRouteInfor = (from x in dbTempMaps.RouteInfos
                                            where x.RouteName == RouteName
                                            select x).ToList();
            int RouteID = 0;

            foreach (RouteInfo Route in dbRouteInfor)
            {
                RouteID = Convert.ToInt32(Route.RouteID);
            }
            return RouteID;
        }

    }
}