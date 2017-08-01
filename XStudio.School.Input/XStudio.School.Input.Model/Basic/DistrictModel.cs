/************************************************************************************************************************************************
 * FileName:       DistrictModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Basic
{
    /// <summary>
    /// 行政区信息
    /// </summary>
    public partial class DistrictModel
    {
		/// <summary>
		/// 行政区ID
		/// </summary>
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
