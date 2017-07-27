/************************************************************************************************************************************************
 * FileName:       UserController.cs
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
    public partial class UserService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<UserModel> GetUsers()
        {
            var items = UserRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<UserModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<UserModel> GetUsersByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = UserRepository.GetItemsByPaging(request, out total);
            var items = new List<UserModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<UserModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserModel GetUser(int id)
        {
            var item = UserRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(UserModel model)
        {
            return UserRepository.Save(model.ToPO());
        }
    }
}
