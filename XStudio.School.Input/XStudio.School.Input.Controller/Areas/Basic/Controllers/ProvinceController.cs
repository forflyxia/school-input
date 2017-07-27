/************************************************************************************************************************************************
 * FileName:       ProvinceController.cs
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
    public partial class ProvinceController : BaseController
    {
        public ActionResult ProvinceIndex()
        {
            var model = new ProvinceModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Ename = GetParams<string>("ename"),
                 CountryId = GetParams<int>("countryid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Provinces()
        {
            var items = new ProvinceService().GetProvinces();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProvincesByPaging(DataTablesPaging request)
        {
            var view = new ProvinceService().GetProvincesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProvince(int id)
        {
            if (id > 0)
            {
                var model = new ProvinceService().GetProvince(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProvinceModel model)
        {
            return new ProvinceService().Save(model);
        }
	}
}
