/************************************************************************************************************************************************
 * FileName:       ProductPriceController.cs
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
    public partial class ProductPriceController : BaseController
    {
        public ActionResult ProductPriceIndex()
        {
            return View();
        }
        
        public JsonResult ProductPrices()
        {
            var items = new ProductPriceService().GetProductPrices();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProductPricesByPaging(DataTablesPaging request)
        {
            var view = new ProductPriceService().GetProductPricesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProductPrice(int id)
        {
            if (id > 0)
            {
                var model = new ProductPriceService().GetProductPrice(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProductPriceModel model)
        {
            return new ProductPriceService().Save(model);
        }
	}
}
