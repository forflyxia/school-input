/************************************************************************************************************************************************
 * FileName:       MerchantPO.cs
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
    /// 
    /// </summary>
    [Table("merchant_merchant")]
    public partial class MerchantPO
    {
		/// <summary>
		/// 
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Shortname { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Branch { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Logo { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Introduction { get; set; }
        
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
		public string Businesslicence { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Legalperson { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int DistrictId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Address { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Longitude { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Latitude { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Cash { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public decimal Point { get; set; }
        
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
