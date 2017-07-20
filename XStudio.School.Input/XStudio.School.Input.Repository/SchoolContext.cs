
/************************************************************************************************************************************************
 * FileName:       DbContext.cs
 * Author:         hbxia
 * Description:    this is auto genetated, don't change!
*************************************************************************************************************************************************/

using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MySql.Data.Entity;
using XStudio.School.Input.Domain.PO.School;

namespace XStudio.School.Input.Repository.DbContext
{
    /// <summary>
    /// SchoolContext
    /// </summary>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SchoolContext : System.Data.Entity.DbContext
    {    
        /// <summary>
        /// SchoolContext
        /// </summary>
        public SchoolContext() : base("SchoolContext")
        {

        }
    
        /// <summary>
        /// 
        /// </summary>
        public DbSet<CityPO> Citys { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<CountryPO> Countrys { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProvincePO> Provinces { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<MerchantPO> Merchants { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<OrderPO> Orders { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<OrderDetailPO> OrderDetails { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProductPO> Products { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProductCategoryPO> ProductCategorys { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProductDescriptionPO> ProductDescriptions { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProductPricePO> ProductPrices { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<SchoolPO> Schools { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<SchoolBranchPO> SchoolBranchs { get; set; }
        
    }
}
