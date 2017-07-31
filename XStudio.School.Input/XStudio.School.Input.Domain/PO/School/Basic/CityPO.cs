/************************************************************************************************************************************************
 * FileName:       CityPO.cs
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
    /// 城市信息
    /// </summary>
    [Table("basic_city")]
    public partial class CityPO
    {
		/// <summary>
		/// 城市信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 城市名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 城市英文名称
		/// </summary>
		public string Ename { get; set; }
        
		/// <summary>
		/// 城市三字码
		/// </summary>
		public string Citycode { get; set; }
        
		/// <summary>
		/// 邮编
		/// </summary>
		public string Zipcode { get; set; }
        
		/// <summary>
		/// 所属省份id
		/// </summary>
		public int ProvinceId { get; set; }
        
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
