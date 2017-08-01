/************************************************************************************************************************************************
 * FileName:       ProductDescriptionModel.cs
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
    /// 产品描述信息
    /// </summary>
    public partial class ProductDescriptionModel
    {
		/// <summary>
		/// 描述ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 产品ID
		/// </summary>
		public int ProductId { get; set; }
        
		/// <summary>
		/// 描述
		/// </summary>
		public string Description { get; set; }
        
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
