/************************************************************************************************************************************************
 * FileName:       SchoolBranchPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.School;

namespace XStudio.School.Input.Service.Converter.School
{
    public static class SchoolBranchConverter
    {
        public static SchoolBranchModel ToModel(this SchoolBranchPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolBranchModel
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Logo = item.Logo,
                Introduction = item.Introduction,
                SchoolId = item.SchoolId,
                CityId = item.CityId,
                Address = item.Address,
                Longitude = item.Longitude,
                Latitude = item.Latitude,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static SchoolBranchPO ToPO(this SchoolBranchModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolBranchPO
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Logo = item.Logo,
                Introduction = item.Introduction,
                SchoolId = item.SchoolId,
                CityId = item.CityId,
                Address = item.Address,
                Longitude = item.Longitude,
                Latitude = item.Latitude,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}