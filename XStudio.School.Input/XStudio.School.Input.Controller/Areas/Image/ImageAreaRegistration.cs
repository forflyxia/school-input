using System.Web.Mvc;

namespace XStudio.School.Input.Controller.Areas.Product
{
    public class ImageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Image";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Image_default",
                "Image/{controller}/{action}/{id}",
                new { action = "ImageIndex", id = UrlParameter.Optional }
            );
        }
    }
}