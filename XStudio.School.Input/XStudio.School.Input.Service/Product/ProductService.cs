using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Product;
using XStudio.School.Input.Repository.School;
using XStudio.School.Input.Service.Converter;

namespace XStudio.School.Input.Service.Product
{
    public class ProductService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductModel> GetProductsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var products = ProductRepository.GetListPaging(request, out total);
            var items = new List<ProductModel>();
            foreach (var product in products)
            {
                var item = product.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductModel>(request.Draw, total, products.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductModel GetProduct(int productId)
        {
            var product = ProductRepository.GetItem(productId);
            return product.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool Save(ProductModel model)
        {
            return ProductRepository.Save(model.ToPO());
        }
    }
}
