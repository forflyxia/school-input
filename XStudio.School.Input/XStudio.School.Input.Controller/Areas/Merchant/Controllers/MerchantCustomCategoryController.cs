/************************************************************************************************************************************************
 * FileName:       MerchantCustomCategoryController.cs
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
    public partial class MerchantCustomCategoryController : BaseController
    {
        public ActionResult MerchantCustomCategoryIndex()
        {
            var model = new MerchantCustomCategoryModel
            {
                 Id = GetParams<int>("id"),
                 MerchatId = GetParams<int>("merchatid"),
                 Categoryname = GetParams<string>("categoryname"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult MerchantCustomCategorys()
        {
            var items = new MerchantCustomCategoryService().GetMerchantCustomCategorys();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MerchantCustomCategorysByPaging(DataTablesPaging request)
        {
            var view = new MerchantCustomCategoryService().GetMerchantCustomCategorysByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewMerchantCustomCategory(int id)
        {
            if (id > 0)
            {
                var model = new MerchantCustomCategoryService().GetMerchantCustomCategory(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(MerchantCustomCategoryModel model)
        {
            return new MerchantCustomCategoryService().Save(model);
        }
	}
}
