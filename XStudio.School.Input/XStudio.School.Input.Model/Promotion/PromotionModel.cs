/************************************************************************************************************************************************
 * FileName:       PromotionModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Promotion
{
    /// <summary>
    /// 促销信息
    /// </summary>
    public partial class PromotionModel
    {
		/// <summary>
		/// 促销ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 短名称
		/// </summary>
		public string Shortname { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Description { get; set; }
        
		/// <summary>
		/// 适用产品类别ID
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
		/// 所属商户ID
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
		/// 创建时间
		/// </summary>
		public DateTime Createtime { get; set; }
        
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime Updatetime { get; set; }
        
    }
}
