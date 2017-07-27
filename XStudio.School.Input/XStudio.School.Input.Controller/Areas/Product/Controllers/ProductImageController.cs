/************************************************************************************************************************************************
 * FileName:       ProductImageController.cs
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
    public partial class ProductImageController : BaseController
    {
        public ActionResult ProductImageIndex()
        {
            var model = new ProductImageModel
            {
                 Id = GetParams<int>("id"),
                 ProductId = GetParams<string>("productid"),
                 ImageId = GetParams<string>("imageid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult ProductImages()
        {
            var items = new ProductImageService().GetProductImages();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProductImagesByPaging(DataTablesPaging request)
        {
            var view = new ProductImageService().GetProductImagesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProductImage(int id)
        {
            if (id > 0)
            {
                var model = new ProductImageService().GetProductImage(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProductImageModel model)
        {
            return new ProductImageService().Save(model);
        }
	}
}
