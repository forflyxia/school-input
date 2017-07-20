/************************************************************************************************************************************************
 * FileName:       SchoolBranchPO.cs
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
    [Table("school_school_branch")]
    public partial class SchoolBranchPO
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
		public string Logo { get; set; }        
        
		/// <summary>
		/// 
		/// </summary>
		public string Introduction { get; set; }        
        
		/// <summary>
		/// 
		/// </summary>
		public int SchoolId { get; set; }        
        
		/// <summary>
		/// 
		/// </summary>
		public int CityId { get; set; }        
        
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
