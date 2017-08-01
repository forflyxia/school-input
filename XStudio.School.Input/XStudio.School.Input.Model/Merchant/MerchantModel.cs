/************************************************************************************************************************************************
 * FileName:       MerchantModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Merchant
{
    /// <summary>
    /// 商户信息
    /// </summary>
    public partial class MerchantModel
    {
		/// <summary>
		/// 商户ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 短名称
		/// </summary>
		public string Shortname { get; set; }
        
		/// <summary>
		/// 分店
		/// </summary>
		public string Branch { get; set; }
        
		/// <summary>
		/// Logo
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
		/// 行政区ID
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
		/// 创建时间
		/// </summary>
		public DateTime Createtime { get; set; }
        
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime Updatetime { get; set; }
        
    }
}
