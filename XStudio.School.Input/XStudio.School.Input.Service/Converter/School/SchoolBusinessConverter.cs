/************************************************************************************************************************************************
 * FileName:       SchoolBusinessPO.cs
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
    public static class SchoolBusinessConverter
    {
        public static SchoolBusinessModel ToModel(this SchoolBusinessPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolBusinessModel
            {
                Id = item.Id,
                SchoolId = item.SchoolId,
                Name = item.Name,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static SchoolBusinessPO ToPO(this SchoolBusinessModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolBusinessPO
            {
                Id = item.Id,
                SchoolId = item.SchoolId,
                Name = item.Name,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}