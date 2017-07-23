using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Product;

namespace XStudio.School.Input.Service.Converter
{
    public static class ProductConverter
    {
        public static ProductModel ToModel(this ProductPO product)
        {
            if (product == null)
            {
                return null;
            }
            return new ProductModel
            {
                ProductID = product.Id,
                Name = product.Name,
                CategoryId = product.CategoryId,
                Logo = product.Logo,
                Introduction = product.Introduction,
                MerchantId = product.MerchantId,
                Status = product.Status
            };
        }

        public static ProductPO ToPO(this ProductModel product)
        {
            if (product == null)
            {
                return null;
            }
            return new ProductPO
            {
                Id = product.ProductID,
                Name = product.Name,
                CategoryId = product.CategoryId,
                Logo = product.Logo,
                Introduction = product.Introduction,
                MerchantId = product.MerchantId,
                Status = product.Status
            };
        }
    }
}
