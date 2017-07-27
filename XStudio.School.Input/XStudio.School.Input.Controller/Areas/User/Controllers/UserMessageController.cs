/************************************************************************************************************************************************
 * FileName:       UserMessageController.cs
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
    public partial class UserMessageController : BaseController
    {
        public ActionResult UserMessageIndex()
        {
            var model = new UserMessageModel
            {
                 Id = GetParams<int>("id"),
                 UserId = GetParams<int>("userid"),
                 Message = GetParams<string>("message"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult UserMessages()
        {
            var items = new UserMessageService().GetUserMessages();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UserMessagesByPaging(DataTablesPaging request)
        {
            var view = new UserMessageService().GetUserMessagesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewUserMessage(int id)
        {
            if (id > 0)
            {
                var model = new UserMessageService().GetUserMessage(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(UserMessageModel model)
        {
            return new UserMessageService().Save(model);
        }
	}
}
