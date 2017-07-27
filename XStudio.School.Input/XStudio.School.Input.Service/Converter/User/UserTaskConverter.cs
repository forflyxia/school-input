/************************************************************************************************************************************************
 * FileName:       UserTaskPO.cs
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
    public static class UserTaskConverter
    {
        public static UserTaskModel ToModel(this UserTaskPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new UserTaskModel
            {
                Id = item.Id,
                UserId = item.UserId,
                OrderId = item.OrderId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static UserTaskPO ToPO(this UserTaskModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new UserTaskPO
            {
                Id = item.Id,
                UserId = item.UserId,
                OrderId = item.OrderId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}