/************************************************************************************************************************************************
 * FileName:       ProductCategoryPO.cs
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
    public static class ProductCategoryConverter
    {
        public static ProductCategoryModel ToModel(this ProductCategoryPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductCategoryModel
            {
                Id = item.Id,
                Name = item.Name,
                ParentcategoryId = item.ParentcategoryId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProductCategoryPO ToPO(this ProductCategoryModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProductCategoryPO
            {
                Id = item.Id,
                Name = item.Name,
                ParentcategoryId = item.ParentcategoryId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}