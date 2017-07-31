/************************************************************************************************************************************************
 * FileName:       UserTaskPO.cs
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
    /// 用户任务信息
    /// </summary>
    [Table("user_user_task")]
    public partial class UserTaskPO
    {
		/// <summary>
		/// 用户任务主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }
        
		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }
        
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
