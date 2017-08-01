/************************************************************************************************************************************************
 * FileName:       SchoolBusinessModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.School
{
    /// <summary>
    /// 学校业务信息
    /// </summary>
    public partial class SchoolBusinessModel
    {
		/// <summary>
		/// 学校业务ID
		/// </summary>
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
