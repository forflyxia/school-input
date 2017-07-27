/************************************************************************************************************************************************
 * FileName:       SchoolController.cs
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
using XStudio.School.Input.Model.School;
using XStudio.School.Input.Service.School;

namespace XStudio.School.Input.Controller.Areas.School.Controllers
{
    public partial class SchoolController : BaseController
    {
        public ActionResult SchoolIndex()
        {
            var model = new SchoolModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Shortname = GetParams<string>("shortname"),
                 Branchname = GetParams<string>("branchname"),
                 Logo = GetParams<string>("logo"),
                 Introduction = GetParams<string>("introduction"),
                 DistrictId = GetParams<int>("districtid"),
                 Address = GetParams<string>("address"),
                 Longitude = GetParams<decimal>("longitude"),
                 Latitude = GetParams<decimal>("latitude"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Schools()
        {
            var items = new SchoolService().GetSchools();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SchoolsByPaging(DataTablesPaging request)
        {
            var view = new SchoolService().GetSchoolsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewSchool(int id)
        {
            if (id > 0)
            {
                var model = new SchoolService().GetSchool(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(SchoolModel model)
        {
            return new SchoolService().Save(model);
        }
	}
}
