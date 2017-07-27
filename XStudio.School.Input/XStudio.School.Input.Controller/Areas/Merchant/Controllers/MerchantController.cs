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
            var model = new MerchantModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Shortname = GetParams<string>("shortname"),
                 Branch = GetParams<string>("branch"),
                 Logo = GetParams<string>("logo"),
                 Introduction = GetParams<string>("introduction"),
                 Contact = GetParams<string>("contact"),
                 Telphone = GetParams<string>("telphone"),
                 Mobliephone = GetParams<string>("mobliephone"),
                 Businesslicence = GetParams<string>("businesslicence"),
                 Legalperson = GetParams<string>("legalperson"),
                 DistrictId = GetParams<int>("districtid"),
                 Address = GetParams<string>("address"),
                 Longitude = GetParams<decimal>("longitude"),
                 Latitude = GetParams<decimal>("latitude"),
                 Cash = GetParams<decimal>("cash"),
                 Point = GetParams<decimal>("point"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
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
