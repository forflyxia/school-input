using System.Web.Mvc;

namespace XStudio.School.Input.Controller.Areas.Promotion
{
    public class PromotionAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Promotion";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Promotion_default",
                "Promotion/{controller}/{action}/{id}",
                new { action = "PromotionIndex", id = UrlParameter.Optional }
            );
        }
    }
}