/************************************************************************************************************************************************
 * FileName:       ProductCategoryModel.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XStudio.School.Input.Model.Product
{
    /// <summary>
    /// 产品类别信息
    /// </summary>
    public partial class ProductCategoryModel
    {
		/// <summary>
		/// 类别ID
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 父类ID
		/// </summary>
		public int ParentcategoryId { get; set; }
        
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
