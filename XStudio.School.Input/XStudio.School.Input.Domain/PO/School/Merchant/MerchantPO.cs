/************************************************************************************************************************************************
 * FileName:       MerchantPO.cs
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
    /// 商户信息
    /// </summary>
    [Table("merchant_merchant")]
    public partial class MerchantPO
    {
		/// <summary>
		/// 主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 商户名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 商户短名称
		/// </summary>
		public string Shortname { get; set; }
        
		/// <summary>
		/// 商户分店
		/// </summary>
		public string Branch { get; set; }
        
		/// <summary>
		/// 商户logo
		/// </summary>
		public string Logo { get; set; }
        
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 联系人
		/// </summary>
		public string Contact { get; set; }
        
		/// <summary>
		/// 电话
		/// </summary>
		public string Telphone { get; set; }
        
		/// <summary>
		/// 手机
		/// </summary>
		public string Mobliephone { get; set; }
        
		/// <summary>
		/// 营业执照
		/// </summary>
		public string Businesslicence { get; set; }
        
		/// <summary>
		/// 法人
		/// </summary>
		public string Legalperson { get; set; }
        
		/// <summary>
		/// 所属行政区
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
		/// 现金
		/// </summary>
		public decimal Cash { get; set; }
        
		/// <summary>
		/// 积分
		/// </summary>
		public decimal Point { get; set; }
        
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
