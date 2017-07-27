/************************************************************************************************************************************************
 * FileName:       MerchantPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Model.Merchant;

namespace XStudio.School.Input.Service.Converter.Merchant
{
    public static class MerchantConverter
    {
        public static MerchantModel ToModel(this MerchantPO item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantModel
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Branch = item.Branch,
                Logo = item.Logo,
                Introduction = item.Introduction,
                Contact = item.Contact,
                Telphone = item.Telphone,
                Mobliephone = item.Mobliephone,
                Businesslicence = item.Businesslicence,
                Legalperson = item.Legalperson,
                DistrictId = item.DistrictId,
                Address = item.Address,
                Longitude = item.Longitude,
                Latitude = item.Latitude,
                Cash = item.Cash,
                Point = item.Point,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }

        public static MerchantPO ToPO(this MerchantModel item)
        {
            if (item == null)
            {
                return null;
            }
            return new MerchantPO
            {
                Id = item.Id,
                Name = item.Name,
                Shortname = item.Shortname,
                Branch = item.Branch,
                Logo = item.Logo,
                Introduction = item.Introduction,
                Contact = item.Contact,
                Telphone = item.Telphone,
                Mobliephone = item.Mobliephone,
                Businesslicence = item.Businesslicence,
                Legalperson = item.Legalperson,
                DistrictId = item.DistrictId,
                Address = item.Address,
                Longitude = item.Longitude,
                Latitude = item.Latitude,
                Cash = item.Cash,
                Point = item.Point,
                Status = item.Status,
                Createtime = item.Createtime,
                Updatetime = item.Updatetime,
            };
        }
    }
}