/************************************************************************************************************************************************
 * FileName:       CountryPO.cs
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
    public static class CountryConverter
    {
        public static CountryModel ToModel(this CountryPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new CountryModel
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static CountryPO ToPO(this CountryModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new CountryPO
            {
                Id = item.Id,
                Name = item.Name,
                Ename = item.Ename,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}