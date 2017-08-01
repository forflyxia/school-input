/************************************************************************************************************************************************
 * FileName:       CityModel.cs
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
    /// 城市信息
    /// </summary>
    public partial class CityModel
    {
		/// <summary>
		/// 城市ID
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
		/// 三字码
		/// </summary>
		public string Citycode { get; set; }
        
		/// <summary>
		/// 邮编
		/// </summary>
		public string Zipcode { get; set; }
        
		/// <summary>
		/// 省份ID
		/// </summary>
		public int ProvinceId { get; set; }
        
		/// <summary>
		/// 国家ID
		/// </summary>
		public int CountryId { get; set; }
        
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
