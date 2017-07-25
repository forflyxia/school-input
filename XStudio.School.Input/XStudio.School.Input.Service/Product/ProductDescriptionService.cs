/************************************************************************************************************************************************
 * FileName:       ProductDescriptionController.cs
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
    public partial class ProductDescriptionService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ProductDescriptionModel> GetProductDescriptions()
        {
            var items = ProductDescriptionRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<ProductDescriptionModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductDescriptionModel> GetProductDescriptionsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProductDescriptionRepository.GetItemsByPaging(request, out total);
            var items = new List<ProductDescriptionModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductDescriptionModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDescriptionModel GetProductDescription(int id)
        {
            var item = ProductDescriptionRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProductDescriptionModel model)
        {
            return ProductDescriptionRepository.Save(model.ToPO());
        }
    }
}
