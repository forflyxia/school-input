/************************************************************************************************************************************************
 * FileName:       PromotionLadderController.cs
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
    public partial class PromotionLadderController : BaseController
    {
        public ActionResult PromotionLadderIndex()
        {
            var model = new PromotionLadderModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 PromotionId = GetParams<int>("promotionid"),
                 Totalamount = GetParams<decimal>("totalamount"),
                 Reduction = GetParams<decimal>("reduction"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult PromotionLadders()
        {
            var items = new PromotionLadderService().GetPromotionLadders();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PromotionLaddersByPaging(DataTablesPaging request)
        {
            var view = new PromotionLadderService().GetPromotionLaddersByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewPromotionLadder(int id)
        {
            if (id > 0)
            {
                var model = new PromotionLadderService().GetPromotionLadder(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(PromotionLadderModel model)
        {
            return new PromotionLadderService().Save(model);
        }
	}
}
