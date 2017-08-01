/************************************************************************************************************************************************
 * FileName:       SchoolNewsModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.School
{
    /// <summary>
    /// 学校新闻信息
    /// </summary>
    public partial class SchoolNewsModel
    {
		/// <summary>
		/// 学校新闻ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 学校ID
		/// </summary>
		public string SchoolId { get; set; }
        
		/// <summary>
		/// 新闻标题
		/// </summary>
		public string Newstitle { get; set; }
        
		/// <summary>
		/// 新闻
		/// </summary>
		public string News { get; set; }
        
		/// <summary>
		/// 状态
		/// </summary>
		public int Status { get; set; }
        
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime Createtime { get; set; }
        
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime Updatetime { get; set; }
        
    }
}
