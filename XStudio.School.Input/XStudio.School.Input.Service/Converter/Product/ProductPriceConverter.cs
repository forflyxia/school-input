/************************************************************************************************************************************************
 * FileName:       ProductPricePO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Product;

namespace XStudio.School.Input.Service.Converter.Product
{
    public static class ProductPriceConverter
    {
        public static ProductPriceModel ToModel(this ProductPricePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductPriceModel
            {
                Id = item.Id,
                ProductId = item.ProductId,
                Unitprice = item.Unitprice,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProductPricePO ToPO(this ProductPriceModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductPricePO
            {
                Id = item.Id,
                ProductId = item.ProductId,
                Unitprice = item.Unitprice,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}