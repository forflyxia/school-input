/************************************************************************************************************************************************
 * FileName:       SchoolPO.cs
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
    public static class SchoolConverter
    {
        public static SchoolModel ToModel(this SchoolPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolModel
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Logo = item.Logo,
                Introduction = item.Introduction,
                CityId = item.CityId,
                Address = item.Address,
                Longitude = item.Longitude,
                Latitude = item.Latitude,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static SchoolPO ToPO(this SchoolModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolPO
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Logo = item.Logo,
                Introduction = item.Introduction,
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