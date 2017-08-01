/************************************************************************************************************************************************
 * FileName:       PromotionLadderModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Promotion
{
    /// <summary>
    /// 促销阶梯信息
    /// </summary>
    public partial class PromotionLadderModel
    {
		/// <summary>
		/// 促销阶梯ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 阶梯名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 促销ID
		/// </summary>
		public int PromotionId { get; set; }
        
		/// <summary>
		/// 满多少
		/// </summary>
		public decimal Totalamount { get; set; }
        
		/// <summary>
		/// 减多少
		/// </summary>
		public decimal Reduction { get; set; }
        
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
