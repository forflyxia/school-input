/************************************************************************************************************************************************
 * FileName:       MerchantCustomCategoryPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Merchant;

namespace XStudio.School.Input.Service.Converter.Merchant
{
    public static class MerchantCustomCategoryConverter
    {
        public static MerchantCustomCategoryModel ToModel(this MerchantCustomCategoryPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantCustomCategoryModel
            {
                Id = item.Id,
                MerchatId = item.MerchatId,
                Categoryname = item.Categoryname,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static MerchantCustomCategoryPO ToPO(this MerchantCustomCategoryModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantCustomCategoryPO
            {
                Id = item.Id,
                MerchatId = item.MerchatId,
                Categoryname = item.Categoryname,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}