using System.Web.Mvc;

namespace XStudio.School.Input.Controller.Areas.Basic
{
    public class BasicAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Basic";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Basic_default",
                "Basic/{controller}/{action}/{id}",
                new { action = "BasicIndex", id = UrlParameter.Optional }
            );
        }
    }
}