/************************************************************************************************************************************************
 * FileName:       UserMessagePO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.User;

namespace XStudio.School.Input.Service.Converter.User
{
    public static class UserMessageConverter
    {
        public static UserMessageModel ToModel(this UserMessagePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new UserMessageModel
            {
                Id = item.Id,
                UserId = item.UserId,
                Message = item.Message,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static UserMessagePO ToPO(this UserMessageModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new UserMessagePO
            {
                Id = item.Id,
                UserId = item.UserId,
                Message = item.Message,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}