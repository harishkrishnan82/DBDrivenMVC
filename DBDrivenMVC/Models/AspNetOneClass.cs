using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDrivenMVC.Models
{
    public class AspNetOneClass
    {
        public string PageTitle { get; set; }
        public string MainHeading { get; set; }
        public string Heading1 { get; set; }
        public string Menu1 { get; set; }
        public string Menu2 { get; set; }
        public string Menu3 { get; set; }
        public string SubMenu1 { get; set; }
        public string SubMenu2 { get; set; }
        public string PostHeading { get; set; }
        public string PostContent { get; set; }
        public string PostHeading1 { get; set; }
        public string PostContent1 { get; set; }
        public string SiteFooter { get; set; }
        public string SiteName { get; set; }
        
        public TemplateInfo TemplateInfos { get; set; }

    }
}