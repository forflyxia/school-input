/************************************************************************************************************************************************
 * FileName:       ProductPO.cs
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
    /// 产品信息
    /// </summary>
    [Table("product_product")]
    public partial class ProductPO
    {
		/// <summary>
		/// 产品主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 产品logo
		/// </summary>
		public string Logo { get; set; }
        
		/// <summary>
		/// 所属类别
		/// </summary>
		public int ProductcategoryId { get; set; }
        
		/// <summary>
		/// 所属商户自定义类别id
		/// </summary>
		public int MerchantcustomcategoryId { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 所属商户
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
