/************************************************************************************************************************************************
 * FileName:       CountryController.cs
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
    public partial class CountryController : BaseController
    {
        public ActionResult CountryIndex()
        {
            return View();
        }

        public JsonResult Countrys(DataTablesPaging request)
        {
            var view = new CountryService().GetCountrysByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewCountry(int id)
        {
            if (id > 0)
            {
                var model = new CountryService().GetCountry(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(CountryModel model)
        {
            return new CountryService().Save(model);
        }
	}
}
