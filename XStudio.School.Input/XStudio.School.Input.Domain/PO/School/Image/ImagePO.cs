/************************************************************************************************************************************************
 * FileName:       ImagePO.cs
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
    [Table("image_image")]
    public partial class ImagePO
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
		public string Url { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int SchoolId { get; set; }
        
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
