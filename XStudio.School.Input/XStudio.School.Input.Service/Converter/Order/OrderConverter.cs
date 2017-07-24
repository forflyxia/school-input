/************************************************************************************************************************************************
 * FileName:       OrderPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Order;

namespace XStudio.School.Input.Service.Converter.Order
{
    public static class OrderConverter
    {
        public static OrderModel ToModel(this OrderPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new OrderModel
            {
                Id = item.Id,
                UserId = item.UserId,
                Contact = item.Contact,
                Telphone = item.Telphone,
                Mobliephone = item.Mobliephone,
                Totalamount = item.Totalamount,
                Reduction = item.Reduction,
                AmountpaId = item.AmountpaId,
                Couponcode = item.Couponcode,
                DeliverycityId = item.DeliverycityId,
                DeliveryschoolId = item.DeliveryschoolId,
                DeliveryschoolbranchId = item.DeliveryschoolbranchId,
                Deliveryaddress = item.Deliveryaddress,
                Remark = item.Remark,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static OrderPO ToPO(this OrderModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new OrderPO
            {
                Id = item.Id,
                UserId = item.UserId,
                Contact = item.Contact,
                Telphone = item.Telphone,
                Mobliephone = item.Mobliephone,
                Totalamount = item.Totalamount,
                Reduction = item.Reduction,
                AmountpaId = item.AmountpaId,
                Couponcode = item.Couponcode,
                DeliverycityId = item.DeliverycityId,
                DeliveryschoolId = item.DeliveryschoolId,
                DeliveryschoolbranchId = item.DeliveryschoolbranchId,
                Deliveryaddress = item.Deliveryaddress,
                Remark = item.Remark,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}