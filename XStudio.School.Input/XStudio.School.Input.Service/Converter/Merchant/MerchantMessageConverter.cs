/************************************************************************************************************************************************
 * FileName:       MerchantMessagePO.cs
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
    public static class MerchantMessageConverter
    {
        public static MerchantMessageModel ToModel(this MerchantMessagePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantMessageModel
            {
                Id = item.Id,
                MerchantId = item.MerchantId,
                Message = item.Message,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static MerchantMessagePO ToPO(this MerchantMessageModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantMessagePO
            {
                Id = item.Id,
                MerchantId = item.MerchantId,
                Message = item.Message,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}