/************************************************************************************************************************************************
 * FileName:       ImagePO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Image;

namespace XStudio.School.Input.Service.Converter.Image
{
    public static class ImageConverter
    {
        public static ImageModel ToModel(this ImagePO item)
        {
            if (item == null)
            {
                return null;
            }
            return new ImageModel
            {
                Id = item.Id,
                Name = item.Name,
                Url = item.Url,
                Introduction = item.Introduction,
                MerchantId = item.MerchantId,
                SchoolId = item.SchoolId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static ImagePO ToPO(this ImageModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new ImagePO
            {
                Id = item.Id,
                Name = item.Name,
                Url = item.Url,
                Introduction = item.Introduction,
                MerchantId = item.MerchantId,
                SchoolId = item.SchoolId,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}