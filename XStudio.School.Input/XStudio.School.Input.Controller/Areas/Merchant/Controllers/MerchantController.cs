/************************************************************************************************************************************************
 * FileName:       MerchantController.cs
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
using XStudio.School.Input.Model.Merchant;
using XStudio.School.Input.Service.Merchant;

namespace XStudio.School.Input.Controller.Areas.Merchant.Controllers
{
    public partial class MerchantController : BaseController
    {
        public ActionResult MerchantIndex()
        {
            return View();
        }
        
        public JsonResult Merchants()
        {
            var items = new MerchantService().GetMerchants();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MerchantsByPaging(DataTablesPaging request)
        {
            var view = new MerchantService().GetMerchantsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewMerchant(int id)
        {
            if (id > 0)
            {
                var model = new MerchantService().GetMerchant(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(MerchantModel model)
        {
            return new MerchantService().Save(model);
        }
	}
}
