/************************************************************************************************************************************************
 * FileName:       ProvincePO.cs
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
    public static class ProvinceConverter
    {
        public static ProvinceModel ToModel(this ProvincePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProvinceModel
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                CountryId = item.CountryId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ProvincePO ToPO(this ProvinceModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ProvincePO
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                CountryId = item.CountryId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}