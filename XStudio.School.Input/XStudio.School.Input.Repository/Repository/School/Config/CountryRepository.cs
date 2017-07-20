/************************************************************************************************************************************************
 * FileName:       CountryRepository.cs
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
    public partial class CountryRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static CountryPO GetItem(int id) 
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
        public static List<CountryPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Countrys.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static CountryPO GetDataForSave(int id)
        {
			CountryPO item;
            if (id == 0)
            {
                item = new CountryPO()
                {
    				Name = "",
    				Ename = "",
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
        public static bool Save(CountryPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Countrys.Add(item);
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
        public static List<CountryPO> GetList()
        {
			return new List<CountryPO>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new CountryPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(CountryPO item)
        {
            using (var context = new SchoolContext())
            {
                context.Countrys.Attach(item);
                context.Countrys.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
