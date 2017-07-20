/************************************************************************************************************************************************
 * FileName:       OrderRepository.cs
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
    public partial class OrderRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static OrderPO GetItem(int id) 
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
        public static List<OrderPO> GetItems(List<int> ids)
        {
            using (var context = new SchoolContext())
            {
                return context.Orders.Where(p => ids.Contains(p.Id)).ToList();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static OrderPO GetDataForSave(int id)
        {
			OrderPO item;
            if (id == 0)
            {
                item = new OrderPO()
                {
    				UserId = 0,
    				Contact = "",
    				Telphone = "",
    				Mobliephone = "",
    				Totalamount = 0,
    				Reduction = 0,
    				AmountpaId = 0,
    				Couponcode = "",
    				DeliverycityId = 0,
    				DeliveryschoolId = 0,
    				DeliveryschoolbranchId = 0,
    				Deliveryaddress = "",
    				Remark = "",
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
        public static bool Save(OrderPO item) 
        {
			using (var context = new SchoolContext())
            {
                if (item.Id == 0)
                {
                    context.Orders.Add(item);
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
        public static List<OrderPO> GetList()
        {
			return new List<OrderPO>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            var item = new OrderPO {Id = id};
            return Delete(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Delete(OrderPO item)
        {
            using (var context = new SchoolContext())
            {
                context.Orders.Attach(item);
                context.Orders.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
