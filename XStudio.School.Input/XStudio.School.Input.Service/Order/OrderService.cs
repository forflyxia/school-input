/************************************************************************************************************************************************
 * FileName:       OrderController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Order;
using XStudio.School.Input.Repository.School.Order;
using XStudio.School.Input.Service.Converter.Order;

namespace XStudio.School.Input.Service.Order
{
    public partial class OrderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<OrderModel> GetOrdersByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = OrderRepository.GetListPaging(request, out total);
            var items = new List<OrderModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<OrderModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderModel GetOrder(int id)
        {
            var item = OrderRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(OrderModel model)
        {
            return OrderRepository.Save(model.ToPO());
        }
    }
}
