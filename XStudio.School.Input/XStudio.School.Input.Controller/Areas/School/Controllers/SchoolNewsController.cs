/************************************************************************************************************************************************
 * FileName:       SchoolNewsController.cs
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
    public partial class SchoolNewsController : BaseController
    {
        public ActionResult SchoolNewsIndex()
        {
            var model = new SchoolNewsModel
            {
                 Id = GetParams<int>("id"),
                 SchoolId = GetParams<string>("schoolid"),
                 Title = GetParams<string>("title"),
                 News = GetParams<string>("news"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult SchoolNewss()
        {
            var items = new SchoolNewsService().GetSchoolNewss();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SchoolNewssByPaging(DataTablesPaging request)
        {
            var view = new SchoolNewsService().GetSchoolNewssByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewSchoolNews(int id)
        {
            if (id > 0)
            {
                var model = new SchoolNewsService().GetSchoolNews(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(SchoolNewsModel model)
        {
            return new SchoolNewsService().Save(model);
        }
	}
}
