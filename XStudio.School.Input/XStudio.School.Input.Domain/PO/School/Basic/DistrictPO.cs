﻿/************************************************************************************************************************************************
 * FileName:       DistrictPO.cs
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
    /// 行政区信息
    /// </summary>
    [Table("basic_district")]
    public partial class DistrictPO
    {
		/// <summary>
		/// 行政区ID
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 英文名称
		/// </summary>
		public string Ename { get; set; }
        
		/// <summary>
		/// 邮编
		/// </summary>
		public string Zipcode { get; set; }
        
		/// <summary>
		/// 城市ID
		/// </summary>
		public int CityId { get; set; }
        
		/// <summary>
		/// 状态
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
