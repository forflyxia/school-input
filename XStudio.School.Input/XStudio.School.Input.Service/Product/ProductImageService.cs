﻿/************************************************************************************************************************************************
 * FileName:       ProductImageController.cs
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
    public partial class ProductImageService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ProductImageModel> GetProductImages()
        {
            var items = ProductImageRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<ProductImageModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProductImageModel> GetProductImagesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProductImageRepository.GetItemsByPaging(request, out total);
            var items = new List<ProductImageModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProductImageModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductImageModel GetProductImage(int id)
        {
            var item = ProductImageRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProductImageModel model)
        {
            return ProductImageRepository.Save(model.ToPO());
        }
    }
}
