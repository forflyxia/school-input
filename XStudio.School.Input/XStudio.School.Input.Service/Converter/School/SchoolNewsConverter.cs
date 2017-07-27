/************************************************************************************************************************************************
 * FileName:       SchoolNewsPO.cs
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
    public static class SchoolNewsConverter
    {
        public static SchoolNewsModel ToModel(this SchoolNewsPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolNewsModel
            {
                Id = item.Id,
                SchoolId = item.SchoolId,
                Title = item.Title,
                News = item.News,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static SchoolNewsPO ToPO(this SchoolNewsModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new SchoolNewsPO
            {
                Id = item.Id,
                SchoolId = item.SchoolId,
                Title = item.Title,
                News = item.News,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}