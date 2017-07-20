/************************************************************************************************************************************************
 * FileName:       CityRepository.cs
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
    public partial class CityRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static CityPO GetItem(int id) 
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
        public static List<CityPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Citys.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static CityPO GetDataForSave(int id)
        {
			CityPO item;
            if (id == 0)
            {
                item = new CityPO()
                {
    				Name = "",
    				Ename = "",
    				Citycode = "",
    				Zipcode = "",
    				ProvinceId = 0,
    				CountryId = 0,
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
        public static bool Save(CityPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Citys.Add(item);
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
        public static List<CityPO> GetList()
        {
			return new List<CityPO>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new CityPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(CityPO item)
        {
            using (var context = new SchoolContext())
            {
                context.Citys.Attach(item);
                context.Citys.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
