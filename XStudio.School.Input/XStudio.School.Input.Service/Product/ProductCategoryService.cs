/************************************************************************************************************************************************
 * FileName:       ProductCategoryController.cs
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
    public partial class ProductCategoryService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductCategoryModel> GetProductCategorysByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProductCategoryRepository.GetListPaging(request, out total);
            var items = new List<ProductCategoryModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductCategoryModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductCategoryModel GetProductCategory(int id)
        {
            var item = ProductCategoryRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProductCategoryModel model)
        {
            return ProductCategoryRepository.Save(model.ToPO());
        }
    }
}
