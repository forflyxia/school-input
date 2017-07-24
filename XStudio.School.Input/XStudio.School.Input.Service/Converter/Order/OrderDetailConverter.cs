/************************************************************************************************************************************************
 * FileName:       OrderDetailPO.cs
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
    public static class OrderDetailConverter
    {
        public static OrderDetailModel ToModel(this OrderDetailPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new OrderDetailModel
            {
                Id = item.Id,
                OrderId = item.OrderId,
                ProductId = item.ProductId,
                Unitprice = item.Unitprice,
                Quantity = item.Quantity,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static OrderDetailPO ToPO(this OrderDetailModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new OrderDetailPO
            {
                Id = item.Id,
                OrderId = item.OrderId,
                ProductId = item.ProductId,
                Unitprice = item.Unitprice,
                Quantity = item.Quantity,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}