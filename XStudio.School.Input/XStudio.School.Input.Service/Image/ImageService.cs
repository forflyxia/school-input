/************************************************************************************************************************************************
 * FileName:       ImageController.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStudio.School.Input.Model.Paging;
using XStudio.School.Input.Model.Image;
using XStudio.School.Input.Repository.School.Image;
using XStudio.School.Input.Service.Converter.Image;

namespace XStudio.School.Input.Service.Image
{
    public partial class ImageService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ImageModel> GetImages()
        {
            var items = ImageRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<ImageModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<ImageModel> GetImagesByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = ImageRepository.GetItemsByPaging(request, out total);
            var items = new List<ImageModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<ImageModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ImageModel GetImage(int id)
        {
            var item = ImageRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(ImageModel model)
        {
            return ImageRepository.Save(model.ToPO());
        }
    }
}
