/************************************************************************************************************************************************
 * FileName:       UserPO.cs
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
    public static class UserConverter
    {
        public static UserModel ToModel(this UserPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new UserModel
            {
                Id = item.Id,
                Username = item.Username,
                Password = item.Password,
                Nickname = item.Nickname,
                Email = item.Email,
                Usertype = item.Usertype,
                Moblie = item.Moblie,
                Sex = item.Sex,
                SchoolId = item.SchoolId,
                Cash = item.Cash,
                Point = item.Point,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static UserPO ToPO(this UserModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new UserPO
            {
                Id = item.Id,
                Username = item.Username,
                Password = item.Password,
                Nickname = item.Nickname,
                Email = item.Email,
                Usertype = item.Usertype,
                Moblie = item.Moblie,
                Sex = item.Sex,
                SchoolId = item.SchoolId,
                Cash = item.Cash,
                Point = item.Point,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}