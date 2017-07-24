/************************************************************************************************************************************************
 * FileName:       OrderDetailModel.cs
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
    public partial class OrderDetailModel
    {
		/// <summary>
		/// 
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int OrderId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int ProductId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Unitprice { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int Quantity { get; set; }
        
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
