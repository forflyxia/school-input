/************************************************************************************************************************************************
 * FileName:       MerchantCustomCategoryController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Merchant;
using XStudio.School.Input.Repository.School.Merchant;
using XStudio.School.Input.Service.Converter.Merchant;

namespace XStudio.School.Input.Service.Merchant
{
    public partial class MerchantCustomCategoryService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<MerchantCustomCategoryModel> GetMerchantCustomCategorys()
        {
            var items = MerchantCustomCategoryRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<MerchantCustomCategoryModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<MerchantCustomCategoryModel> GetMerchantCustomCategorysByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = MerchantCustomCategoryRepository.GetItemsByPaging(request, out total);
            var items = new List<MerchantCustomCategoryModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<MerchantCustomCategoryModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MerchantCustomCategoryModel GetMerchantCustomCategory(int id)
        {
            var item = MerchantCustomCategoryRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(MerchantCustomCategoryModel model)
        {
            return MerchantCustomCategoryRepository.Save(model.ToPO());
        }
    }
}
