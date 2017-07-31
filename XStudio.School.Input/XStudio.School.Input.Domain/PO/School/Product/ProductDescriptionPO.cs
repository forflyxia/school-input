/************************************************************************************************************************************************
 * FileName:       ProductDescriptionPO.cs
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
    /// 产品描述信息
    /// </summary>
    [Table("product_product_description")]
    public partial class ProductDescriptionPO
    {
		/// <summary>
		/// 产品描述主键
		/// </summary>
		[Key]
		public int Id { get; set; }
        
		/// <summary>
		/// 产品id
		/// </summary>
		public int ProductId { get; set; }
        
		/// <summary>
		/// 商品描述
		/// </summary>
		public string Description { get; set; }
        
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
