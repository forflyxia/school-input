/************************************************************************************************************************************************
 * FileName:       CountryController.cs
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
    public partial class CountryService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<CountryModel> GetCountrys()
        {
            var items = CountryRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<CountryModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<CountryModel> GetCountrysByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = CountryRepository.GetItemsByPaging(request, out total);
            var items = new List<CountryModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<CountryModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CountryModel GetCountry(int id)
        {
            var item = CountryRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(CountryModel model)
        {
            return CountryRepository.Save(model.ToPO());
        }
    }
}
