using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using XStudio.School.Input.Model;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Product;

namespace XStudio.School.Input.Controller.Areas.Product.Controllers
{
    public class ProductsController : BaseController
    {
        //
        // GET: /Product/Products/
        public JsonResult Index(DataTablesPaging request)
        {
            var view = new DatatablesView<ProductModel>(request.Draw, 17, 17);
            view.data.Add(new ProductModel {ProductID = 1, Name = "test1"});
            view.data.Add(new ProductModel { ProductID = 2, Name = "test2" });
            view.data.Add(new ProductModel { ProductID = 3, Name = "test3" });
            view.data.Add(new ProductModel { ProductID = 4, Name = "test4" });
            view.data.Add(new ProductModel { ProductID = 5, Name = "test5" });
            view.data.Add(new ProductModel { ProductID = 6, Name = "test6" });
            view.data.Add(new ProductModel { ProductID = 7, Name = "test7" });
            view.data.Add(new ProductModel { ProductID = 8, Name = "test8" });
            view.data.Add(new ProductModel { ProductID = 9, Name = "test9" });
            view.data.Add(new ProductModel { ProductID = 10, Name = "test10" });
            view.data.Add(new ProductModel { ProductID = 11, Name = "test11" });
            view.data.Add(new ProductModel { ProductID = 12, Name = "test12" });
            view.data.Add(new ProductModel { ProductID = 13, Name = "test13" });
            view.data.Add(new ProductModel { ProductID = 14, Name = "test14" });
            view.data.Add(new ProductModel { ProductID = 15, Name = "test15" });
            view.data.Add(new ProductModel { ProductID = 16, Name = "test16" });
            view.data.Add(new ProductModel { ProductID = 17, Name = "test17" });
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult test(string p)
        {
            return View();
        }
	}
}