/************************************************************************************************************************************************
 * FileName:       OrderPO.cs
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
    /// 订单信息
    /// </summary>
    [Table("order_order")]
    public partial class OrderPO
    {
		/// <summary>
		/// 订单ID
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserId { get; set; }
        
		/// <summary>
		/// 联系人
		/// </summary>
		public string Contact { get; set; }
        
		/// <summary>
		/// 电话
		/// </summary>
		public string Telphone { get; set; }
        
		/// <summary>
		/// 手机
		/// </summary>
		public string Mobliephone { get; set; }
        
		/// <summary>
		/// 总金额
		/// </summary>
		public decimal Totalamount { get; set; }
        
		/// <summary>
		/// 减免金额
		/// </summary>
		public decimal Reduction { get; set; }
        
		/// <summary>
		/// 实收金额
		/// </summary>
		public decimal AmountpaId { get; set; }
        
		/// <summary>
		/// 优惠券ID
		/// </summary>
		public string PromotionId { get; set; }
        
		/// <summary>
		/// 优惠阶梯ID
		/// </summary>
		public string PromotionladderId { get; set; }
        
		/// <summary>
		/// 配送学校ID
		/// </summary>
		public int SchoolId { get; set; }
        
		/// <summary>
		/// 配送地址
		/// </summary>
		public string Deliveryaddress { get; set; }
        
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }
        
		/// <summary>
		/// 订单状态
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
