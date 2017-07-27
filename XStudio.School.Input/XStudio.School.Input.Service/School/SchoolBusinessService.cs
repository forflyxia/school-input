/************************************************************************************************************************************************
 * FileName:       SchoolBusinessController.cs
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
    public partial class SchoolBusinessService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<SchoolBusinessModel> GetSchoolBusinesss()
        {
            var items = SchoolBusinessRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<SchoolBusinessModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<SchoolBusinessModel> GetSchoolBusinesssByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = SchoolBusinessRepository.GetItemsByPaging(request, out total);
            var items = new List<SchoolBusinessModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<SchoolBusinessModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SchoolBusinessModel GetSchoolBusiness(int id)
        {
            var item = SchoolBusinessRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(SchoolBusinessModel model)
        {
            return SchoolBusinessRepository.Save(model.ToPO());
        }
    }
}
