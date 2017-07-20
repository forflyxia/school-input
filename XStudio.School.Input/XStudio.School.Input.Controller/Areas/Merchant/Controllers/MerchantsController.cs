using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace XStudio.School.Input.Controller.Areas.Merchant.Controllers
{
    public class MerchantsController : BaseController
    {
        //
        // GET: /Merchant/Merchants/
        public ActionResult Index()
        {
            return Json(new { Result = "Success", Message = "MerchantsController Successfully" }, JsonRequestBehavior.AllowGet);
        }
	}
}