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
using XStudio.School.Input.Model.Basic;
using XStudio.School.Input.Service.Basic;

namespace XStudio.School.Input.Controller.Areas.Basic.Controllers
{
    public partial class CityController : BaseController
    {
        public ActionResult CityIndex()
        {
            var model = new CityModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Ename = GetParams<string>("ename"),
                 Citycode = GetParams<string>("citycode"),
                 Zipcode = GetParams<string>("zipcode"),
                 ProvinceId = GetParams<int>("provinceid"),
                 CountryId = GetParams<int>("countryid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Citys()
        {
            var items = new CityService().GetCitys();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CitysByPaging(DataTablesPaging request)
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
