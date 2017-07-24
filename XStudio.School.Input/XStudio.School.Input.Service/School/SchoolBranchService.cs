/************************************************************************************************************************************************
 * FileName:       SchoolBranchController.cs
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
    public partial class SchoolBranchService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<SchoolBranchModel> GetSchoolBranchsByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = SchoolBranchRepository.GetListPaging(request, out total);
            var items = new List<SchoolBranchModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<SchoolBranchModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SchoolBranchModel GetSchoolBranch(int id)
        {
            var item = SchoolBranchRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(SchoolBranchModel model)
        {
            return SchoolBranchRepository.Save(model.ToPO());
        }
    }
}
