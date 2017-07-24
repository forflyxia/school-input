/************************************************************************************************************************************************
 * FileName:       MerchantController.cs
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
    public partial class MerchantService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<MerchantModel> GetMerchantsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = MerchantRepository.GetListPaging(request, out total);
            var items = new List<MerchantModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<MerchantModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MerchantModel GetMerchant(int id)
        {
            var item = MerchantRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(MerchantModel model)
        {
            return MerchantRepository.Save(model.ToPO());
        }
    }
}
