/************************************************************************************************************************************************
 * FileName:       ProductImageModel.cs
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
    /// 产品图片信息
    /// </summary>
    public partial class ProductImageModel
    {
		/// <summary>
		/// 产品图片ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 产品ID
		/// </summary>
		public string ProductId { get; set; }
        
		/// <summary>
		/// 图片ID
		/// </summary>
		public string ImageId { get; set; }
        
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
