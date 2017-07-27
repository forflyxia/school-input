/************************************************************************************************************************************************
 * FileName:       ProductImagePO.cs
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
    public static class ProductImageConverter
    {
        public static ProductImageModel ToModel(this ProductImagePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductImageModel
            {
                Id = item.Id,
                ProductId = item.ProductId,
                ImageId = item.ImageId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProductImagePO ToPO(this ProductImageModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductImagePO
            {
                Id = item.Id,
                ProductId = item.ProductId,
                ImageId = item.ImageId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}