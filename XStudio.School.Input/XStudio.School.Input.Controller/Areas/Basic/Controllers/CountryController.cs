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
using XStudio.School.Input.Model.Basic;
using XStudio.School.Input.Service.Basic;

namespace XStudio.School.Input.Controller.Areas.Basic.Controllers
{
    public partial class CountryController : BaseController
    {
        public ActionResult CountryIndex()
        {
            var model = new CountryModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Ename = GetParams<string>("ename"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Countrys()
        {
            var items = new CountryService().GetCountrys();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CountrysByPaging(DataTablesPaging request)
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
