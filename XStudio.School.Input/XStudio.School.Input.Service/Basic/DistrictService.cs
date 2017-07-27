/************************************************************************************************************************************************
 * FileName:       DistrictController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Basic;
using XStudio.School.Input.Repository.School.Basic;
using XStudio.School.Input.Service.Converter.Basic;

namespace XStudio.School.Input.Service.Basic
{
    public partial class DistrictService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<DistrictModel> GetDistricts()
        {
            var items = DistrictRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<DistrictModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<DistrictModel> GetDistrictsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = DistrictRepository.GetItemsByPaging(request, out total);
            var items = new List<DistrictModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<DistrictModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DistrictModel GetDistrict(int id)
        {
            var item = DistrictRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(DistrictModel model)
        {
            return DistrictRepository.Save(model.ToPO());
        }
    }
}
