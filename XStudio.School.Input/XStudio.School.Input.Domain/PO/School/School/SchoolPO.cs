/************************************************************************************************************************************************
 * FileName:       SchoolPO.cs
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
    /// 学校信息
    /// </summary>
    [Table("school_school")]
    public partial class SchoolPO
    {
		/// <summary>
		/// 学校信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 学校名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 学校短名称
		/// </summary>
		public string Shortname { get; set; }
        
		/// <summary>
		/// 分校
		/// </summary>
		public string Branchname { get; set; }
        
		/// <summary>
		/// 学校logo
		/// </summary>
		public string Logo { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 行政区
		/// </summary>
		public int DistrictId { get; set; }
        
		/// <summary>
		/// 地址
		/// </summary>
		public string Address { get; set; }
        
		/// <summary>
		/// 经度
		/// </summary>
		public decimal Longitude { get; set; }
        
		/// <summary>
		/// 纬度
		/// </summary>
		public decimal Latitude { get; set; }
        
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
