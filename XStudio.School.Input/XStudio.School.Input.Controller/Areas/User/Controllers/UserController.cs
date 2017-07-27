/************************************************************************************************************************************************
 * FileName:       UserController.cs
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
    public partial class UserController : BaseController
    {
        public ActionResult UserIndex()
        {
            var model = new UserModel
            {
                 Id = GetParams<int>("id"),
                 Username = GetParams<string>("username"),
                 Password = GetParams<string>("password"),
                 Nickname = GetParams<string>("nickname"),
                 Email = GetParams<string>("email"),
                 Usertype = GetParams<string>("usertype"),
                 Moblie = GetParams<string>("moblie"),
                 Sex = GetParams<int>("sex"),
                 SchoolId = GetParams<int>("schoolid"),
                 Cash = GetParams<decimal>("cash"),
                 Point = GetParams<decimal>("point"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Users()
        {
            var items = new UserService().GetUsers();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UsersByPaging(DataTablesPaging request)
        {
            var view = new UserService().GetUsersByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewUser(int id)
        {
            if (id > 0)
            {
                var model = new UserService().GetUser(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(UserModel model)
        {
            return new UserService().Save(model);
        }
	}
}
