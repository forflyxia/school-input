/************************************************************************************************************************************************
 * FileName:       SchoolController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.School;
using XStudio.School.Input.Repository.School.School;
using XStudio.School.Input.Service.Converter.School;

namespace XStudio.School.Input.Service.School
{
    public partial class SchoolService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<SchoolModel> GetSchools()
        {
            var items = SchoolRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<SchoolModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<SchoolModel> GetSchoolsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = SchoolRepository.GetItemsByPaging(request, out total);
            var items = new List<SchoolModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<SchoolModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SchoolModel GetSchool(int id)
        {
            var item = SchoolRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(SchoolModel model)
        {
            return SchoolRepository.Save(model.ToPO());
        }
    }
}
