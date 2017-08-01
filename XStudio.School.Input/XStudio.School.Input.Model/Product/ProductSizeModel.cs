/************************************************************************************************************************************************
 * FileName:       ProductSizeModel.cs
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
    /// 产品价格信息
    /// </summary>
    public partial class ProductSizeModel
    {
		/// <summary>
		/// 产品规格ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 产品ID
		/// </summary>
		public int ProductId { get; set; }
        
		/// <summary>
		/// 规格
		/// </summary>
		public string Size { get; set; }
        
		/// <summary>
		/// 单价
		/// </summary>
		public decimal Unitprice { get; set; }
        
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
