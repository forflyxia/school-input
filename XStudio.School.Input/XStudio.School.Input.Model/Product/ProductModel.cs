/************************************************************************************************************************************************
 * FileName:       ProductModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Product
{
    /// <summary>
    /// 产品信息
    /// </summary>
    public partial class ProductModel
    {
		/// <summary>
		/// 产品ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 名称:0000000000
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// Logo
		/// </summary>
		public string Logo { get; set; }
        
		/// <summary>
		/// 类别
		/// </summary>
		public int ProductcategoryId { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 商户ID
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 商户类别ID
		/// </summary>
		public int MerchantcustomcategoryId { get; set; }
        
		/// <summary>
		/// 学校ID
		/// </summary>
		public int SchoolId { get; set; }
        
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
