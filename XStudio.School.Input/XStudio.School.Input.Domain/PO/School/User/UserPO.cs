﻿/************************************************************************************************************************************************
 * FileName:       UserPO.cs
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
    /// 用户信息
    /// </summary>
    [Table("user_user")]
    public partial class UserPO
    {
		/// <summary>
		/// 用户信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 用户名称
		/// </summary>
		public string Username { get; set; }
        
		/// <summary>
		/// 密码
		/// </summary>
		public string Password { get; set; }
        
		/// <summary>
		/// 用户昵称
		/// </summary>
		public string Nickname { get; set; }
        
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email { get; set; }
        
		/// <summary>
		/// 用户类型(用户还是商户)
		/// </summary>
		public string Usertype { get; set; }
        
		/// <summary>
		/// 手机
		/// </summary>
		public string Moblie { get; set; }
        
		/// <summary>
		/// 性别
		/// </summary>
		public int Sex { get; set; }
        
		/// <summary>
		/// 所属学校id
		/// </summary>
		public int SchoolId { get; set; }
        
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
