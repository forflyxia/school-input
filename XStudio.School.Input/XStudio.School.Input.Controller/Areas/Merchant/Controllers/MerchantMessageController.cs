/************************************************************************************************************************************************
 * FileName:       MerchantMessageController.cs
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
    public partial class MerchantMessageController : BaseController
    {
        public ActionResult MerchantMessageIndex()
        {
            var model = new MerchantMessageModel
            {
                 Id = GetParams<int>("id"),
                 MerchantId = GetParams<int>("merchantid"),
                 Message = GetParams<string>("message"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult MerchantMessages()
        {
            var items = new MerchantMessageService().GetMerchantMessages();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MerchantMessagesByPaging(DataTablesPaging request)
        {
            var view = new MerchantMessageService().GetMerchantMessagesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewMerchantMessage(int id)
        {
            if (id > 0)
            {
                var model = new MerchantMessageService().GetMerchantMessage(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(MerchantMessageModel model)
        {
            return new MerchantMessageService().Save(model);
        }
	}
}
