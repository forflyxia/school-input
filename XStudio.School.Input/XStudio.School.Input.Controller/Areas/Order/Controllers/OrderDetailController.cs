﻿/************************************************************************************************************************************************
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
            var model = new OrderDetailModel
            {
                 Id = GetParams<int>("id"),
                 OrderId = GetParams<int>("orderid"),
                 ProductId = GetParams<int>("productid"),
                 ProductsizeId = GetParams<int>("productsizeid"),
                 Unitprice = GetParams<decimal>("unitprice"),
                 Quantity = GetParams<int>("quantity"),
                 Status = GetParams<int>("status"),
                 Createtime = GetParams<DateTime>("createtime"),
                 Updatetime = GetParams<DateTime>("updatetime"),
            };
            return View(model);
        }
        
        public JsonResult OrderDetails()
        {
            var items = new OrderDetailService().GetOrderDetails();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public JsonResult OrderDetailsByPaging(DataTablesPaging request)
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
