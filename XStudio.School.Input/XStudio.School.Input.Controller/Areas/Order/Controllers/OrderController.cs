/************************************************************************************************************************************************
 * FileName:       OrderController.cs
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
    public partial class OrderController : BaseController
    {
        public ActionResult OrderIndex()
        {
            var model = new OrderModel
            {
                 Id = GetParams<int>("id"),
                 UserId = GetParams<int>("userid"),
                 Contact = GetParams<string>("contact"),
                 Telphone = GetParams<string>("telphone"),
                 Mobliephone = GetParams<string>("mobliephone"),
                 Totalamount = GetParams<decimal>("totalamount"),
                 Reduction = GetParams<decimal>("reduction"),
                 AmountpaId = GetParams<decimal>("amountpaid"),
                 PromotionId = GetParams<string>("promotionid"),
                 PromotionladderId = GetParams<string>("promotionladderid"),
                 SchoolId = GetParams<int>("schoolid"),
                 Deliveryaddress = GetParams<string>("deliveryaddress"),
                 Remark = GetParams<string>("remark"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult Orders()
        {
            var items = new OrderService().GetOrders();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult OrdersByPaging(DataTablesPaging request)
        {
            var view = new OrderService().GetOrdersByPaging(request);
            return Json(view, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewOrder(int id)
        {
            if (id > 0)
            {
                var model = new OrderService().GetOrder(id);
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        public bool Save(OrderModel model)
        {
            return new OrderService().Save(model);
        }
	}
}
