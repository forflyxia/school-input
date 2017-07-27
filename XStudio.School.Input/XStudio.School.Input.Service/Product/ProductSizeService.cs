/************************************************************************************************************************************************
 * FileName:       ProductSizeController.cs
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
    public partial class ProductSizeService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ProductSizeModel> GetProductSizes()
        {
            var items = ProductSizeRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<ProductSizeModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductSizeModel> GetProductSizesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProductSizeRepository.GetItemsByPaging(request, out total);
            var items = new List<ProductSizeModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductSizeModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductSizeModel GetProductSize(int id)
        {
            var item = ProductSizeRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProductSizeModel model)
        {
            return ProductSizeRepository.Save(model.ToPO());
        }
    }
}
