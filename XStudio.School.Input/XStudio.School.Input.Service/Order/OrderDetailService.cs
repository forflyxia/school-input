/************************************************************************************************************************************************
 * FileName:       OrderDetailController.cs
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
    public partial class OrderDetailService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<OrderDetailModel> GetOrderDetails()
        {
            var items = OrderDetailRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<OrderDetailModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<OrderDetailModel> GetOrderDetailsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = OrderDetailRepository.GetItemsByPaging(request, out total);
            var items = new List<OrderDetailModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<OrderDetailModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDetailModel GetOrderDetail(int id)
        {
            var item = OrderDetailRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(OrderDetailModel model)
        {
            return OrderDetailRepository.Save(model.ToPO());
        }
    }
}
