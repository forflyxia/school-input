/************************************************************************************************************************************************
 * FileName:       UserTaskController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.User;
using XStudio.School.Input.Repository.School.User;
using XStudio.School.Input.Service.Converter.User;

namespace XStudio.School.Input.Service.User
{
    public partial class UserTaskService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<UserTaskModel> GetUserTasks()
        {
            var items = UserTaskRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<UserTaskModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<UserTaskModel> GetUserTasksByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = UserTaskRepository.GetItemsByPaging(request, out total);
            var items = new List<UserTaskModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<UserTaskModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserTaskModel GetUserTask(int id)
        {
            var item = UserTaskRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(UserTaskModel model)
        {
            return UserTaskRepository.Save(model.ToPO());
        }
    }
}
