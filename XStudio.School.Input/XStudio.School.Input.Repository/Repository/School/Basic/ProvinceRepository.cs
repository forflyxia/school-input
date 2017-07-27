/************************************************************************************************************************************************
 * FileName:       ProvinceRepository.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using XStudio.School.Input.Domain.PO.School;
using XStudio.School.Input.Repository.DbContext;
using XStudio.School.Input.Infrastructure;
using XStudio.School.Input.Model.Paging;

namespace XStudio.School.Input.Repository.School.Basic
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ProvinceRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ProvincePO GetItem(int id) 
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
        public static List<ProvincePO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Provinces.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ProvincePO GetDataForSave(int id)
        {
			ProvincePO item;
            if (id == 0)
            {
                item = new ProvincePO()
                {
    				Name = "",
    				Ename = "",
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
        public static bool Save(ProvincePO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Provinces.Add(item);
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
        public static List<ProvincePO> GetItemsByPaging(DataTablesPaging paging, out int total)
        {
            var filterParameters = new Dictionary<string, string>();
            foreach (var filterItem in paging.CustomFilterParameters)
            {
                if (!string.IsNullOrWhiteSpace(filterItem.Value))
                {
                    filterParameters.Add(filterItem.Name, filterItem.Value);
                }
            }
            using (var context = new SchoolContext())
            {
                var items = context.Provinces.Filter(filterParameters);
                total = items.Count();
                var datas = items.OrderBy(p => p.Id).Skip(paging.Start * paging.Length).Take(paging.Length).ToList();
                return datas;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ProvincePO> GetAll()
        {
			using (var context = new SchoolContext())
            {
                return context.Provinces.ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new ProvincePO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(ProvincePO item)
        {
            using (var context = new SchoolContext())
            {
                context.Provinces.Attach(item);
                context.Provinces.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
