/************************************************************************************************************************************************
 * FileName:       SchoolNewsRepository.cs
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

namespace XStudio.School.Input.Repository.School.School
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SchoolNewsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SchoolNewsPO GetItem(int id) 
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
        public static List<SchoolNewsPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.SchoolNewss.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SchoolNewsPO GetDataForSave(int id)
        {
			SchoolNewsPO item;
            if (id == 0)
            {
                item = new SchoolNewsPO()
                {
    				SchoolId = "",
    				Title = "",
    				News = "",
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
        public static bool Save(SchoolNewsPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.SchoolNewss.Add(item);
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
        public static List<SchoolNewsPO> GetItemsByPaging(DataTablesPaging paging, out int total)
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
                var items = context.SchoolNewss.Filter(filterParameters);
                total = items.Count();
                var datas = items.OrderBy(p => p.Id).Skip(paging.Start * paging.Length).Take(paging.Length).ToList();
                return datas;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<SchoolNewsPO> GetAll()
        {
			using (var context = new SchoolContext())
            {
                return context.SchoolNewss.ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new SchoolNewsPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(SchoolNewsPO item)
        {
            using (var context = new SchoolContext())
            {
                context.SchoolNewss.Attach(item);
                context.SchoolNewss.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
