/************************************************************************************************************************************************
 * FileName:       PromotionPO.cs
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
    [Table("promotion_promotion")]
    public partial class PromotionPO
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
		public string Description { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string ProductcategoryId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public DateTime Effectdate { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public DateTime Expiredate { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int Merchantundertake { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int Platundertake { get; set; }
        
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
