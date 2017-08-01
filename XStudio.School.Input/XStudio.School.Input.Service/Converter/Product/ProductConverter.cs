/************************************************************************************************************************************************
 * FileName:       ProductPO.cs
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
    public static class ProductConverter
    {
        public static ProductModel ToModel(this ProductPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductModel
            {
                Id = item.Id,
                Name = item.Name,
                Logo = item.Logo,
                ProductcategoryId = item.ProductcategoryId,
                Introduction = item.Introduction,
                MerchantId = item.MerchantId,
                MerchantcustomcategoryId = item.MerchantcustomcategoryId,
                SchoolId = item.SchoolId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProductPO ToPO(this ProductModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductPO
            {
                Id = item.Id,
                Name = item.Name,
                Logo = item.Logo,
                ProductcategoryId = item.ProductcategoryId,
                Introduction = item.Introduction,
                MerchantId = item.MerchantId,
                MerchantcustomcategoryId = item.MerchantcustomcategoryId,
                SchoolId = item.SchoolId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}