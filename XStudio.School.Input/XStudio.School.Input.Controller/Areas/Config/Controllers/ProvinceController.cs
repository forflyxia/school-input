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
using XStudio.School.Input.Model.Config;
using XStudio.School.Input.Service.Config;

namespace XStudio.School.Input.Controller.Areas.Config.Controllers
{
    public partial class ProvinceController : BaseController
    {
        public ActionResult ProvinceIndex()
        {
            return View();
        }

        public JsonResult Provinces(DataTablesPaging request)
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
