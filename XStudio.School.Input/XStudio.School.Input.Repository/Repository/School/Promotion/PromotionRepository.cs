/************************************************************************************************************************************************
 * FileName:       PromotionRepository.cs
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

namespace XStudio.School.Input.Repository.School.Promotion
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PromotionRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static PromotionPO GetItem(int id) 
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
        public static List<PromotionPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Promotions.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static PromotionPO GetDataForSave(int id)
        {
			PromotionPO item;
            if (id == 0)
            {
                item = new PromotionPO()
                {
    				Name = "",
    				Shortname = "",
    				Description = "",
    				ProductcategoryId = "",
    				Effectdate = DateTime.Now,
    				Expiredate = DateTime.Now,
    				MerchantId = 0,
    				Merchantundertake = 0,
    				Platundertake = 0,
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
        public static bool Save(PromotionPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Promotions.Add(item);
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
        public static List<PromotionPO> GetItemsByPaging(DataTablesPaging paging, out int total)
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
                var items = context.Promotions.Filter(filterParameters);
                total = items.Count();
                var datas = items.OrderBy(p => p.Id).Skip(paging.Start * paging.Length).Take(paging.Length).ToList();
                return datas;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<PromotionPO> GetAll()
        {
			using (var context = new SchoolContext())
            {
                return context.Promotions.ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new PromotionPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(PromotionPO item)
        {
            using (var context = new SchoolContext())
            {
                context.Promotions.Attach(item);
                context.Promotions.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
