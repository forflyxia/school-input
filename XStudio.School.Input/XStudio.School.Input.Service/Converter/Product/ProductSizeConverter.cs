/************************************************************************************************************************************************
 * FileName:       ProductSizePO.cs
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
    public static class ProductSizeConverter
    {
        public static ProductSizeModel ToModel(this ProductSizePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductSizeModel
            {
                Id = item.Id,
                ProductId = item.ProductId,
                Size = item.Size,
                Unitprice = item.Unitprice,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProductSizePO ToPO(this ProductSizeModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductSizePO
            {
                Id = item.Id,
                ProductId = item.ProductId,
                Size = item.Size,
                Unitprice = item.Unitprice,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}