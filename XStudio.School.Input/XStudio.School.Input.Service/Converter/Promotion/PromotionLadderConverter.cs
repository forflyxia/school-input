/************************************************************************************************************************************************
 * FileName:       PromotionLadderPO.cs
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
    public static class PromotionLadderConverter
    {
        public static PromotionLadderModel ToModel(this PromotionLadderPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new PromotionLadderModel
            {
                Id = item.Id,
                Name = item.Name,
                PromotionId = item.PromotionId,
                Totalamount = item.Totalamount,
                Reduction = item.Reduction,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static PromotionLadderPO ToPO(this PromotionLadderModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new PromotionLadderPO
            {
                Id = item.Id,
                Name = item.Name,
                PromotionId = item.PromotionId,
                Totalamount = item.Totalamount,
                Reduction = item.Reduction,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}