/************************************************************************************************************************************************
 * FileName:       ProductSizePO.cs
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
    /// 产品价格信息
    /// </summary>
    [Table("product_product_size")]
    public partial class ProductSizePO
    {
		/// <summary>
		/// 产品价格主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 产品id
		/// </summary>
		public int ProductId { get; set; }
        
		/// <summary>
		/// 产品尺寸
		/// </summary>
		public int Size { get; set; }
        
		/// <summary>
		/// 单价
		/// </summary>
		public decimal Unitprice { get; set; }
        
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
