/************************************************************************************************************************************************
 * FileName:       SchoolBranchController.cs
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
    public partial class SchoolBranchController : BaseController
    {
        public ActionResult SchoolBranchIndex()
        {
            return View();
        }

        public JsonResult SchoolBranchs(DataTablesPaging request)
        {
            var view = new SchoolBranchService().GetSchoolBranchsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewSchoolBranch(int id)
        {
            if (id > 0)
            {
                var model = new SchoolBranchService().GetSchoolBranch(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(SchoolBranchModel model)
        {
            return new SchoolBranchService().Save(model);
        }
	}
}
