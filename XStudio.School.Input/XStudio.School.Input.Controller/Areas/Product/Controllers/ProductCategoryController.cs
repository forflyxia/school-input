/************************************************************************************************************************************************
 * FileName:       ProductCategoryController.cs
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
using XStudio.School.Input.Model.Product;
using XStudio.School.Input.Service.Product;

namespace XStudio.School.Input.Controller.Areas.Product.Controllers
{
    public partial class ProductCategoryController : BaseController
    {
        public ActionResult ProductCategoryIndex()
        {
            return View();
        }
        
        public JsonResult ProductCategorys()
        {
            var items = new ProductCategoryService().GetProductCategorys();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProductCategorysByPaging(DataTablesPaging request)
        {
            var view = new ProductCategoryService().GetProductCategorysByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProductCategory(int id)
        {
            if (id > 0)
            {
                var model = new ProductCategoryService().GetProductCategory(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProductCategoryModel model)
        {
            return new ProductCategoryService().Save(model);
        }
	}
}
