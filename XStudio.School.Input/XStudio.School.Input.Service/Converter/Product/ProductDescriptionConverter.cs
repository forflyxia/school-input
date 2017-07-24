/************************************************************************************************************************************************
 * FileName:       ProductDescriptionPO.cs
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
    public static class ProductDescriptionConverter
    {
        public static ProductDescriptionModel ToModel(this ProductDescriptionPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductDescriptionModel
            {
                Id = item.Id,
                ProductId = item.ProductId,
                Description = item.Description,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProductDescriptionPO ToPO(this ProductDescriptionModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductDescriptionPO
            {
                Id = item.Id,
                ProductId = item.ProductId,
                Description = item.Description,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}