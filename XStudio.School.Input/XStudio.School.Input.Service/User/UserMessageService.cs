/************************************************************************************************************************************************
 * FileName:       UserMessageController.cs
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
    public partial class UserMessageService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<UserMessageModel> GetUserMessages()
        {
            var items = UserMessageRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<UserMessageModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<UserMessageModel> GetUserMessagesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = UserMessageRepository.GetItemsByPaging(request, out total);
            var items = new List<UserMessageModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<UserMessageModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserMessageModel GetUserMessage(int id)
        {
            var item = UserMessageRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(UserMessageModel model)
        {
            return UserMessageRepository.Save(model.ToPO());
        }
    }
}
