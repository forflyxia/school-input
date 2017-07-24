/************************************************************************************************************************************************
 * FileName:       ProductPriceController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Product;
using XStudio.School.Input.Repository.School.Product;
using XStudio.School.Input.Service.Converter.Product;

namespace XStudio.School.Input.Service.Product
{
    public partial class ProductPriceService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductPriceModel> GetProductPricesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProductPriceRepository.GetListPaging(request, out total);
            var items = new List<ProductPriceModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductPriceModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductPriceModel GetProductPrice(int id)
        {
            var item = ProductPriceRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProductPriceModel model)
        {
            return ProductPriceRepository.Save(model.ToPO());
        }
    }
}
