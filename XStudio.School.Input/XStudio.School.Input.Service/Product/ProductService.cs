/************************************************************************************************************************************************
 * FileName:       ProductController.cs
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
    public partial class ProductService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductModel> GetProductsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProductRepository.GetListPaging(request, out total);
            var items = new List<ProductModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductModel GetProduct(int id)
        {
            var item = ProductRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProductModel model)
        {
            return ProductRepository.Save(model.ToPO());
        }
    }
}
