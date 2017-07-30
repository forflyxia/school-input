using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XStudio.School.Input.Web.App_Start
{
    public class ViewLocationExpander
    {
        /// <summary>
        /// 
        /// </summary>
        private static List<string> ExpandLocations = new List<string>
        {
            "~/Views/School/{1}/{0}.cshtml",
            "~/Views/Merchant/{1}/{0}.cshtml",
            "~/Views/User/{1}/{0}.cshtml",
            "~/Views/Product/{1}/{0}.cshtml",
            "~/Views/Order/{1}/{0}.cshtml",
            "~/Views/Image/{1}/{0}.cshtml",
            "~/Views/Promotion/{1}/{0}.cshtml",
            "~/Views/Basic/{1}/{0}.cshtml",
        };

        /// <summary>
        /// 
        /// </summary>
        public static void ExpandViewLocations()
        {
            var engine = ViewEngines.Engines.OfType<RazorViewEngine>().First();
            engine.ViewLocationFormats = engine.ViewLocationFormats.Concat(ExpandLocations).ToArray();
        }
    }
}