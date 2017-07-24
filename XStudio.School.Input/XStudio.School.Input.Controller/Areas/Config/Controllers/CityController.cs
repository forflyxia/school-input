/************************************************************************************************************************************************
 * FileName:       CityController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using XStudio.School.Input;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Config;
using XStudio.School.Input.Service.Config;

namespace XStudio.School.Input.Controller.Areas.Config.Controllers
{
    public partial class CityController : BaseController
    {
        public ActionResult CityIndex()
        {
            return View();
        }

        public JsonResult Citys(DataTablesPaging request)
        {
            var view = new CityService().GetCitysByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewCity(int id)
        {
            if (id > 0)
            {
                var model = new CityService().GetCity(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(CityModel model)
        {
            return new CityService().Save(model);
        }
	}
}
