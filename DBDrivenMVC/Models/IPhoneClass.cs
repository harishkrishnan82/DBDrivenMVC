using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDrivenMVC.Models
{
    public class IPhoneClass
    {
        public int TemplateID { get; set; }
        public string TemplateName { get; set; }
        public string Title { get; set; }
        public string Heading { get; set; }
        public TemplateInfo TemplateInfos { get; set; }
    }
}