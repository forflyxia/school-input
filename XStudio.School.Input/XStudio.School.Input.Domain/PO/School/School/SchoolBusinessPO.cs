/************************************************************************************************************************************************
 * FileName:       SchoolBusinessPO.cs
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
    /// 学校业务信息
    /// </summary>
    [Table("school_school_business")]
    public partial class SchoolBusinessPO
    {
		/// <summary>
		/// 学校业务ID
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 学校ID
		/// </summary>
		public string SchoolId { get; set; }
        
		/// <summary>
		/// 业务名称
		/// </summary>
		public string Name { get; set; }
        
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
