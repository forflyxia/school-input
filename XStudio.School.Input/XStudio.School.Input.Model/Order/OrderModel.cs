/************************************************************************************************************************************************
 * FileName:       OrderModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Order
{
    /// <summary>
    /// 
    /// </summary>
    public partial class OrderModel
    {
		/// <summary>
		/// 
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int UserId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Contact { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Telphone { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Mobliephone { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Totalamount { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Reduction { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal AmountpaId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Couponcode { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int DeliverycityId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int DeliveryschoolId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int DeliveryschoolbranchId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Deliveryaddress { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Remark { get; set; }
        
		/// <summary>
		/// 
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
