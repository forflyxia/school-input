/************************************************************************************************************************************************
 * FileName:       MerchantImageController.cs
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
    public partial class MerchantImageService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<MerchantImageModel> GetMerchantImages()
        {
            var items = MerchantImageRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<MerchantImageModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<MerchantImageModel> GetMerchantImagesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = MerchantImageRepository.GetItemsByPaging(request, out total);
            var items = new List<MerchantImageModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<MerchantImageModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MerchantImageModel GetMerchantImage(int id)
        {
            var item = MerchantImageRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(MerchantImageModel model)
        {
            return MerchantImageRepository.Save(model.ToPO());
        }
    }
}
