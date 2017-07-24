/************************************************************************************************************************************************
 * FileName:       OrderDetailController.cs
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
using XStudio.School.Input.Model.Order;
using XStudio.School.Input.Service.Order;

namespace XStudio.School.Input.Controller.Areas.Order.Controllers
{
    public partial class OrderDetailController : BaseController
    {
        public ActionResult OrderDetailIndex()
        {
            return View();
        }

        public JsonResult OrderDetails(DataTablesPaging request)
        {
            var view = new OrderDetailService().GetOrderDetailsByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewOrderDetail(int id)
        {
            if (id > 0)
            {
                var model = new OrderDetailService().GetOrderDetail(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(OrderDetailModel model)
        {
            return new OrderDetailService().Save(model);
        }
	}
}
