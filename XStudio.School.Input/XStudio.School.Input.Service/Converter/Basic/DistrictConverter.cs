/************************************************************************************************************************************************
 * FileName:       DistrictPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Basic;

namespace XStudio.School.Input.Service.Converter.Basic
{
    public static class DistrictConverter
    {
        public static DistrictModel ToModel(this DistrictPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new DistrictModel
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                Zipcode = item.Zipcode,
                CityId = item.CityId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static DistrictPO ToPO(this DistrictModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new DistrictPO
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                Zipcode = item.Zipcode,
                CityId = item.CityId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}