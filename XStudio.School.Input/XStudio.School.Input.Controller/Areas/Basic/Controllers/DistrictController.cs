﻿/************************************************************************************************************************************************
 * FileName:       DistrictController.cs
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
    public partial class DistrictController : BaseController
    {
        public ActionResult DistrictIndex()
        {
            var model = new DistrictModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Ename = GetParams<string>("ename"),
                 Zipcode = GetParams<string>("zipcode"),
                 CityId = GetParams<int>("cityid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Districts()
        {
            var items = new DistrictService().GetDistricts();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DistrictsByPaging(DataTablesPaging request)
        {
            var view = new DistrictService().GetDistrictsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewDistrict(int id)
        {
            if (id > 0)
            {
                var model = new DistrictService().GetDistrict(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(DistrictModel model)
        {
            return new DistrictService().Save(model);
        }
	}
}