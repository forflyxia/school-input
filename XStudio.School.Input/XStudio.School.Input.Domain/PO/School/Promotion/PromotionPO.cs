/************************************************************************************************************************************************
 * FileName:       PromotionPO.cs
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
    /// 促销信息
    /// </summary>
    [Table("promotion_promotion")]
    public partial class PromotionPO
    {
		/// <summary>
		/// 促销信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 促销名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 促销短名称
		/// </summary>
		public string Shortname { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Description { get; set; }
        
		/// <summary>
		/// 适用产品类别
		/// </summary>
		public string ProductcategoryId { get; set; }
        
		/// <summary>
		/// 生效日期
		/// </summary>
		public DateTime Effectdate { get; set; }
        
		/// <summary>
		/// 失效日期
		/// </summary>
		public DateTime Expiredate { get; set; }
        
		/// <summary>
		/// 所属商户id
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 商户承担金额
		/// </summary>
		public int Merchantundertake { get; set; }
        
		/// <summary>
		/// 平台承担金额
		/// </summary>
		public int Platundertake { get; set; }
        
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
