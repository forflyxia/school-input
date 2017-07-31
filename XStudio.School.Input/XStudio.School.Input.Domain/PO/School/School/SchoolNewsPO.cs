/************************************************************************************************************************************************
 * FileName:       SchoolNewsPO.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Domain.PO.School
{
    /// <summary>
    /// 学校新闻信息
    /// </summary>
    [Table("school_school_news")]
    public partial class SchoolNewsPO
    {
		/// <summary>
		/// 学校新闻主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 学校id
		/// </summary>
		public string SchoolId { get; set; }
        
		/// <summary>
		/// 新闻title
		/// </summary>
		public string Title { get; set; }
        
		/// <summary>
		/// 新闻
		/// </summary>
		public string News { get; set; }
        
		/// <summary>
		/// 状态
		/// </summary>
		public int Status { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public DateTime Createtime { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public DateTime Updatetime { get; set; }
        
    }
}
