/************************************************************************************************************************************************
 * FileName:       ImagePO.cs
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
    /// 图片信息
    /// </summary>
    [Table("image_image")]
    public partial class ImagePO
    {
		/// <summary>
		/// 图片信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 图片名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 图片url
		/// </summary>
		public string Url { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 商户id
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 学校id
		/// </summary>
		public int SchoolId { get; set; }
        
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
