﻿/************************************************************************************************************************************************
 * FileName:       SchoolNewsController.cs
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
    public partial class SchoolNewsService
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<SchoolNewsModel> GetSchoolNewss()
        {
            var items = SchoolNewsRepository.GetAll();
            if (items != null)
            {
                return items.Select(p => p.ToModel()).ToList();
            }
            return new List<SchoolNewsModel>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DatatablesView<SchoolNewsModel> GetSchoolNewssByPaging(DataTablesPaging request)
        {
            int total = 0;
            var pagingItems = SchoolNewsRepository.GetItemsByPaging(request, out total);
            var items = new List<SchoolNewsModel>();
            foreach (var pagingItem in pagingItems)
            {
                var item = pagingItem.ToModel();
                items.Add(item);
            }
            return new DatatablesView<SchoolNewsModel>(request.Draw, total, pagingItems.Count, items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SchoolNewsModel GetSchoolNews(int id)
        {
            var item = SchoolNewsRepository.GetItem(id);
            return item.ToModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Save(SchoolNewsModel model)
        {
            return SchoolNewsRepository.Save(model.ToPO());
        }
    }
}