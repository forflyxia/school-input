/************************************************************************************************************************************************
 * FileName:       UserTaskController.cs
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
using XStudio.School.Input.Model.User;
using XStudio.School.Input.Service.User;

namespace XStudio.School.Input.Controller.Areas.User.Controllers
{
    public partial class UserTaskController : BaseController
    {
        public ActionResult UserTaskIndex()
        {
            var model = new UserTaskModel
            {
                 Id = GetParams<int>("id"),
                 UserId = GetParams<int>("userid"),
                 OrderId = GetParams<int>("orderid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult UserTasks()
        {
            var items = new UserTaskService().GetUserTasks();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UserTasksByPaging(DataTablesPaging request)
        {
            var view = new UserTaskService().GetUserTasksByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewUserTask(int id)
        {
            if (id > 0)
            {
                var model = new UserTaskService().GetUserTask(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(UserTaskModel model)
        {
            return new UserTaskService().Save(model);
        }
	}
}
