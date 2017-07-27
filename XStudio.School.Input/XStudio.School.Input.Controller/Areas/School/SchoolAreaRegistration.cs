using System.Web.Mvc;

namespace XStudio.School.Input.Controller.Areas.School
{
    public class SchoolAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "School";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "School_default",
                "School/{controller}/{action}/{id}",
                new { action = "SchoolIndex", id = UrlParameter.Optional }
            );
        }
    }
}