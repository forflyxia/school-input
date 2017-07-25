/************************************************************************************************************************************************
 * FileName:       ProductController.cs
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
    public partial class ProductController : BaseController
    {
        public ActionResult ProductIndex()
        {
            return View();
        }
        
        public JsonResult Products()
        {
            var items = new ProductService().GetProducts();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProductsByPaging(DataTablesPaging request)
        {
            var view = new ProductService().GetProductsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProduct(int id)
        {
            if (id > 0)
            {
                var model = new ProductService().GetProduct(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProductModel model)
        {
            return new ProductService().Save(model);
        }
	}
}
