/************************************************************************************************************************************************
 * FileName:       MerchantImagePO.cs
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
    /// 商户图片信息
    /// </summary>
    [Table("merchant_merchant_image")]
    public partial class MerchantImagePO
    {
		/// <summary>
		/// 商户图片主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 商户id
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 商户图片id
		/// </summary>
		public int ImageId { get; set; }
        
		/// <summary>
		/// 排序号
		/// </summary>
		public int Sequence { get; set; }
        
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
