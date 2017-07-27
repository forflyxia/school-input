
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
        public DbSet<DistrictPO> Districts { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProvincePO> Provinces { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ImagePO> Images { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<MerchantPO> Merchants { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<MerchantCustomCategoryPO> MerchantCustomCategorys { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<MerchantImagePO> MerchantImages { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<MerchantMessagePO> MerchantMessages { get; set; }
        
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
        public DbSet<ProductImagePO> ProductImages { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProductSizePO> ProductSizes { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<PromotionPO> Promotions { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<PromotionLadderPO> PromotionLadders { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<SchoolPO> Schools { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<SchoolBusinessPO> SchoolBusinesss { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<SchoolNewsPO> SchoolNewss { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<UserPO> Users { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<UserMessagePO> UserMessages { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<UserTaskPO> UserTasks { get; set; }
        
    }
}
