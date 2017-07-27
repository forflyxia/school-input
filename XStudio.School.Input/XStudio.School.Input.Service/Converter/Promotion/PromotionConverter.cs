/************************************************************************************************************************************************
 * FileName:       PromotionPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Promotion;

namespace XStudio.School.Input.Service.Converter.Promotion
{
    public static class PromotionConverter
    {
        public static PromotionModel ToModel(this PromotionPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new PromotionModel
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Description = item.Description,
                ProductcategoryId = item.ProductcategoryId,
                Effectdate = item.Effectdate,
                Expiredate = item.Expiredate,
                MerchantId = item.MerchantId,
                Merchantundertake = item.Merchantundertake,
                Platundertake = item.Platundertake,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static PromotionPO ToPO(this PromotionModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new PromotionPO
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Description = item.Description,
                ProductcategoryId = item.ProductcategoryId,
                Effectdate = item.Effectdate,
                Expiredate = item.Expiredate,
                MerchantId = item.MerchantId,
                Merchantundertake = item.Merchantundertake,
                Platundertake = item.Platundertake,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}