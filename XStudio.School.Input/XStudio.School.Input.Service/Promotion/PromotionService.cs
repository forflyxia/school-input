/************************************************************************************************************************************************
 * FileName:       PromotionController.cs
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
    public partial class PromotionService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<PromotionModel> GetPromotions()
        {
            var items = PromotionRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<PromotionModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<PromotionModel> GetPromotionsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = PromotionRepository.GetItemsByPaging(request, out total);
            var items = new List<PromotionModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<PromotionModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PromotionModel GetPromotion(int id)
        {
            var item = PromotionRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(PromotionModel model)
        {
            return PromotionRepository.Save(model.ToPO());
        }
    }
}
