/************************************************************************************************************************************************
 * FileName:       MerchantImagePO.cs
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
    public static class MerchantImageConverter
    {
        public static MerchantImageModel ToModel(this MerchantImagePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantImageModel
            {
                Id = item.Id,
                MerchantId = item.MerchantId,
                ImageId = item.ImageId,
                Sequence = item.Sequence,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static MerchantImagePO ToPO(this MerchantImageModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantImagePO
            {
                Id = item.Id,
                MerchantId = item.MerchantId,
                ImageId = item.ImageId,
                Sequence = item.Sequence,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}