/************************************************************************************************************************************************
 * FileName:       MerchantRepository.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Repository.DbContext;

namespace XStudio.School.Input.Repository.School
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MerchantRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static MerchantPO GetItem(int id) 
        {
			var ids = new List<int> {id};
            var items = GetItems(ids);
            if (items.Count > 0)
            {
                return items.First();
            }
            return null;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static List<MerchantPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Merchants.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static MerchantPO GetDataForSave(int id)
        {
			MerchantPO item;
            if (id == 0)
            {
                item = new MerchantPO()
                {
    				Name = "",
    				Shortname = "",
    				Branch = "",
    				Logo = "",
    				Introduction = "",
    				Contact = "",
    				Telphone = "",
    				Mobliephone = "",
    				Businesslicence = "",
    				Legalperson = "",
    				CityId = 0,
    				Address = "",
    				Longitude = 0,
    				Latitude = 0,
    				Status = 0,
    				Createtime = DateTime.Now,
    				Updatetime = DateTime.Now,
                };
            }
            else
            {
                item = GetItem(id);
            }
            return item;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Save(MerchantPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Merchants.Add(item);
                }
                else
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
            return true;
        } 
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<MerchantPO> GetList()
        {
			return new List<MerchantPO>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new MerchantPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(MerchantPO item)
        {
            using (var context = new SchoolContext())
            {
                context.Merchants.Attach(item);
                context.Merchants.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
