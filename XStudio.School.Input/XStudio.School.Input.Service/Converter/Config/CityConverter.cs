/************************************************************************************************************************************************
 * FileName:       CityPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Config;

namespace XStudio.School.Input.Service.Converter.Config
{
    public static class CityConverter
    {
        public static CityModel ToModel(this CityPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new CityModel
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                Citycode = item.Citycode,
                Zipcode = item.Zipcode,
                ProvinceId = item.ProvinceId,
                CountryId = item.CountryId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static CityPO ToPO(this CityModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new CityPO
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                Citycode = item.Citycode,
                Zipcode = item.Zipcode,
                ProvinceId = item.ProvinceId,
                CountryId = item.CountryId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}