/************************************************************************************************************************************************
 * FileName:       UserPO.cs
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
    [Table("user_user")]
    public partial class UserPO
    {
		/// <summary>
		/// 
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Username { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Password { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Nickname { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Email { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Usertype { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Moblie { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int Sex { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int SchoolId { get; set; }
        
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
