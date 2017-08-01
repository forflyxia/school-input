/************************************************************************************************************************************************
 * FileName:       MerchantMessageModel.cs
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
    /// 商户消息
    /// </summary>
    public partial class MerchantMessageModel
    {
		/// <summary>
		/// 商户消息ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 商户ID
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 消息
		/// </summary>
		public string Message { get; set; }
        
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
