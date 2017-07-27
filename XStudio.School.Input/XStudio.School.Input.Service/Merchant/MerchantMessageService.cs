/************************************************************************************************************************************************
 * FileName:       MerchantMessageController.cs
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
    public partial class MerchantMessageService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<MerchantMessageModel> GetMerchantMessages()
        {
            var items = MerchantMessageRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<MerchantMessageModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<MerchantMessageModel> GetMerchantMessagesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = MerchantMessageRepository.GetItemsByPaging(request, out total);
            var items = new List<MerchantMessageModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<MerchantMessageModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MerchantMessageModel GetMerchantMessage(int id)
        {
            var item = MerchantMessageRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(MerchantMessageModel model)
        {
            return MerchantMessageRepository.Save(model.ToPO());
        }
    }
}
