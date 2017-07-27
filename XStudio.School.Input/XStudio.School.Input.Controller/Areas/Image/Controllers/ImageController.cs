/************************************************************************************************************************************************
 * FileName:       ImageController.cs
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
using XStudio.School.Input.Model.Image;
using XStudio.School.Input.Service.Image;

namespace XStudio.School.Input.Controller.Areas.Image.Controllers
{
    public partial class ImageController : BaseController
    {
        public ActionResult ImageIndex()
        {
            var model = new ImageModel
            {
                 Id = GetParams<int>("id"),
                 Name = GetParams<string>("name"),
                 Url = GetParams<string>("url"),
                 Introduction = GetParams<string>("introduction"),
                 MerchantId = GetParams<int>("merchantid"),
                 SchoolId = GetParams<int>("schoolid"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Images()
        {
            var items = new ImageService().GetImages();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ImagesByPaging(DataTablesPaging request)
        {
            var view = new ImageService().GetImagesByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewImage(int id)
        {
            if (id > 0)
            {
                var model = new ImageService().GetImage(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(ImageModel model)
        {
            return new ImageService().Save(model);
        }
	}
}
