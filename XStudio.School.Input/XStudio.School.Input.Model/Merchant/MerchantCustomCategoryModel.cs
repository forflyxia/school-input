/************************************************************************************************************************************************
 * FileName:       MerchantCustomCategoryModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Merchant
{
    /// <summary>
    /// 商户自定义类别信息
    /// </summary>
    public partial class MerchantCustomCategoryModel
    {
		/// <summary>
		/// 类别ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 商户ID
		/// </summary>
		public int MerchatId { get; set; }
        
		/// <summary>
		/// 类别名称
		/// </summary>
		public string Categoryname { get; set; }
        
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
