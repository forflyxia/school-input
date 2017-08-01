/************************************************************************************************************************************************
 * FileName:       UserTaskModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.User
{
    /// <summary>
    /// 用户任务信息
    /// </summary>
    public partial class UserTaskModel
    {
		/// <summary>
		/// 任务ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserId { get; set; }
        
		/// <summary>
		/// 订单ID
		/// </summary>
		public int OrderId { get; set; }
        
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
