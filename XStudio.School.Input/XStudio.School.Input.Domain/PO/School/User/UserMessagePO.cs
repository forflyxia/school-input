/************************************************************************************************************************************************
 * FileName:       UserMessagePO.cs
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
    /// 用户消息
    /// </summary>
    [Table("user_user_message")]
    public partial class UserMessagePO
    {
		/// <summary>
		/// 用户消息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }
        
		/// <summary>
		/// 消息
		/// </summary>
		public string Message { get; set; }
        
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
