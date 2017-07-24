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
            return View();
        }

        public JsonResult Schools(DataTablesPaging request)
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
