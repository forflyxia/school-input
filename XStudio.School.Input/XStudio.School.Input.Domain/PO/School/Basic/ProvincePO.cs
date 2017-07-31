/************************************************************************************************************************************************
 * FileName:       ProvincePO.cs
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
    /// 省份信息
    /// </summary>
    [Table("basic_province")]
    public partial class ProvincePO
    {
		/// <summary>
		/// 省份信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 省份名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 省份英文名称
		/// </summary>
		public string Ename { get; set; }
        
		/// <summary>
		/// 所属国家id
		/// </summary>
		public int CountryId { get; set; }
        
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
