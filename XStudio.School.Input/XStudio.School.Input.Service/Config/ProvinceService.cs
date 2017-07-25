/************************************************************************************************************************************************
 * FileName:       ProvinceController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Config;
using XStudio.School.Input.Repository.School.Config;
using XStudio.School.Input.Service.Converter.Config;

namespace XStudio.School.Input.Service.Config
{
    public partial class ProvinceService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ProvinceModel> GetProvinces()
        {
            var items = ProvinceRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<ProvinceModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ProvinceModel> GetProvincesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ProvinceRepository.GetItemsByPaging(request, out total);
            var items = new List<ProvinceModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ProvinceModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProvinceModel GetProvince(int id)
        {
            var item = ProvinceRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ProvinceModel model)
        {
            return ProvinceRepository.Save(model.ToPO());
        }
    }
}
