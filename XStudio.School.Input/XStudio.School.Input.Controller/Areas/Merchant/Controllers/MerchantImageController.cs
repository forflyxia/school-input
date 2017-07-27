/************************************************************************************************************************************************
 * FileName:       MerchantImageController.cs
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
    public partial class MerchantImageController : BaseController
    {
        public ActionResult MerchantImageIndex()
        {
            var model = new MerchantImageModel
            {
                 Id = GetParams<int>("id"),
                 MerchantId = GetParams<int>("merchantid"),
                 ImageId = GetParams<int>("imageid"),
                 Sequence = GetParams<int>("sequence"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult MerchantImages()
        {
            var items = new MerchantImageService().GetMerchantImages();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MerchantImagesByPaging(DataTablesPaging request)
        {
            var view = new MerchantImageService().GetMerchantImagesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewMerchantImage(int id)
        {
            if (id > 0)
            {
                var model = new MerchantImageService().GetMerchantImage(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(MerchantImageModel model)
        {
            return new MerchantImageService().Save(model);
        }
	}
}
