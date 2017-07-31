/************************************************************************************************************************************************
 * FileName:       OrderDetailPO.cs
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
    /// 订单详情信息
    /// </summary>
    [Table("order_order_detail")]
    public partial class OrderDetailPO
    {
		/// <summary>
		/// 订单详情id主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }
        
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }
        
		/// <summary>
		/// 商品规格id
		/// </summary>
		public int ProductsizeId { get; set; }
        
		/// <summary>
		/// 单价
		/// </summary>
		public decimal Unitprice { get; set; }
        
		/// <summary>
		/// 购买数量
		/// </summary>
		public int Quantity { get; set; }
        
		/// <summary>
		/// 订单状态
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
