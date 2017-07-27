/************************************************************************************************************************************************
 * FileName:       SchoolBusinessController.cs
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
    public partial class SchoolBusinessController : BaseController
    {
        public ActionResult SchoolBusinessIndex()
        {
            var model = new SchoolBusinessModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 SchoolId = GetParams<string>("schoolid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult SchoolBusinesss()
        {
            var items = new SchoolBusinessService().GetSchoolBusinesss();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SchoolBusinesssByPaging(DataTablesPaging request)
        {
            var view = new SchoolBusinessService().GetSchoolBusinesssByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewSchoolBusiness(int id)
        {
            if (id > 0)
            {
                var model = new SchoolBusinessService().GetSchoolBusiness(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(SchoolBusinessModel model)
        {
            return new SchoolBusinessService().Save(model);
        }
	}
}
