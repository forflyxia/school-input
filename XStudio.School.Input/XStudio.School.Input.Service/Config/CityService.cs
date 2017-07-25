/************************************************************************************************************************************************
 * FileName:       CityController.cs
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
    public partial class CityService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<CityModel> GetCitys()
        {
            var items = CityRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<CityModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<CityModel> GetCitysByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = CityRepository.GetItemsByPaging(request, out total);
            var items = new List<CityModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<CityModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CityModel GetCity(int id)
        {
            var item = CityRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(CityModel model)
        {
            return CityRepository.Save(model.ToPO());
        }
    }
}
