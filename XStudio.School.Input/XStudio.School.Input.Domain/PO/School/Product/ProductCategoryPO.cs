/************************************************************************************************************************************************
 * FileName:       ProductCategoryPO.cs
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
    /// 产品类别信息
    /// </summary>
    [Table("product_product_category")]
    public partial class ProductCategoryPO
    {
		/// <summary>
		/// 产品类别信息主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 所属父类
		/// </summary>
		public int ParentcategoryId { get; set; }
        
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
