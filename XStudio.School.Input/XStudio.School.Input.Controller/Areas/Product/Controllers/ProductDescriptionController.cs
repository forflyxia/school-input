/************************************************************************************************************************************************
 * FileName:       ProductDescriptionController.cs
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
    public partial class ProductDescriptionController : BaseController
    {
        public ActionResult ProductDescriptionIndex()
        {
            return View();
        }

        public JsonResult ProductDescriptions(DataTablesPaging request)
        {
            var view = new ProductDescriptionService().GetProductDescriptionsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewProductDescription(int id)
        {
            if (id > 0)
            {
                var model = new ProductDescriptionService().GetProductDescription(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ProductDescriptionModel model)
        {
            return new ProductDescriptionService().Save(model);
        }
	}
}
