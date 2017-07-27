/************************************************************************************************************************************************
 * FileName:       PromotionController.cs
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
using XStudio.School.Input.Model.Promotion;
using XStudio.School.Input.Service.Promotion;

namespace XStudio.School.Input.Controller.Areas.Promotion.Controllers
{
    public partial class PromotionController : BaseController
    {
        public ActionResult PromotionIndex()
        {
            var model = new PromotionModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Shortname = GetParams<string>("shortname"),
                 Description = GetParams<string>("description"),
                 ProductcategoryId = GetParams<string>("productcategoryid"),
                 Effectdate = GetParams<DateTime>("effectdate"),
                 Expiredate = GetParams<DateTime>("expiredate"),
                 MerchantId = GetParams<int>("merchantid"),
                 Merchantundertake = GetParams<int>("merchantundertake"),
                 Platundertake = GetParams<int>("platundertake"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Promotions()
        {
            var items = new PromotionService().GetPromotions();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PromotionsByPaging(DataTablesPaging request)
        {
            var view = new PromotionService().GetPromotionsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewPromotion(int id)
        {
            if (id > 0)
            {
                var model = new PromotionService().GetPromotion(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(PromotionModel model)
        {
            return new PromotionService().Save(model);
        }
	}
}
