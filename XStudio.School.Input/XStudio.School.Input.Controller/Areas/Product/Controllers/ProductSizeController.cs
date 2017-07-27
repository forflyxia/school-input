/************************************************************************************************************************************************
 * FileName:       ProductSizeController.cs
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
    public partial class ProductSizeController : BaseController
    {
        public ActionResult ProductSizeIndex()
        {
            var model = new ProductSizeModel
            {
                 Id = GetParams<int>("id"),
                 ProductId = GetParams<int>("productid"),
                 Size = GetParams<int>("size"),
                 Unitprice = GetParams<decimal>("unitprice"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult ProductSizes()
        {
            var items = new ProductSizeService().GetProductSizes();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProductSizesByPaging(DataTablesPaging request)
        {
            var view = new ProductSizeService().GetProductSizesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProductSize(int id)
        {
            if (id > 0)
            {
                var model = new ProductSizeService().GetProductSize(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProductSizeModel model)
        {
            return new ProductSizeService().Save(model);
        }
	}
}
