/************************************************************************************************************************************************
 * FileName:       PromotionLadderController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Promotion;
using XStudio.School.Input.Repository.School.Promotion;
using XStudio.School.Input.Service.Converter.Promotion;

namespace XStudio.School.Input.Service.Promotion
{
    public partial class PromotionLadderService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<PromotionLadderModel> GetPromotionLadders()
        {
            var items = PromotionLadderRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<PromotionLadderModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<PromotionLadderModel> GetPromotionLaddersByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = PromotionLadderRepository.GetItemsByPaging(request, out total);
            var items = new List<PromotionLadderModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<PromotionLadderModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PromotionLadderModel GetPromotionLadder(int id)
        {
            var item = PromotionLadderRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(PromotionLadderModel model)
        {
            return PromotionLadderRepository.Save(model.ToPO());
        }
    }
}
