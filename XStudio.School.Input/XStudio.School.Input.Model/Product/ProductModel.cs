﻿/************************************************************************************************************************************************
 * FileName:       ProductModel.cs
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
    /// 
    /// </summary>
    public partial class ProductModel
    {
		/// <summary>
		/// 
		/// </summary>
		public int Id { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Logo { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int ProductcategoryId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int MerchantcustomcategoryId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public string Introduction { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int MerchantId { get; set; }
        
		/// <summary>
		/// 
		/// </summary>
		public int SchoolId { get; set; }
        
		/// <summary>
		/// 
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
