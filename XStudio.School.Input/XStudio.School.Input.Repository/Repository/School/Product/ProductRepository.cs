/************************************************************************************************************************************************
 * FileName:       ProductRepository.cs
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
    public partial class ProductRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ProductPO GetItem(int id) 
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
        public static List<ProductPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Products.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ProductPO GetDataForSave(int id)
        {
			ProductPO item;
            if (id == 0)
            {
                item = new ProductPO()
                {
    				Name = "",
    				Logo = "",
    				CategoryId = 0,
    				Introduction = "",
    				MerchantId = 0,
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
        public static bool Save(ProductPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Products.Add(item);
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
        public static List<ProductPO> GetList()
        {
			return new List<ProductPO>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new ProductPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(ProductPO item)
        {
            using (var context = new SchoolContext())
            {
                context.Products.Attach(item);
                context.Products.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
