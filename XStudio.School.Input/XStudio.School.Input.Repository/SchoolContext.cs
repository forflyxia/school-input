
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
        /// 城市信息
        /// </summary>
        public DbSet<CityPO> Citys { get; set; }
        
        /// <summary>
        /// 国家信息
        /// </summary>
        public DbSet<CountryPO> Countrys { get; set; }
        
        /// <summary>
        /// 行政区信息
        /// </summary>
        public DbSet<DistrictPO> Districts { get; set; }
        
        /// <summary>
        /// 省份信息
        /// </summary>
        public DbSet<ProvincePO> Provinces { get; set; }
        
        /// <summary>
        /// 图片信息
        /// </summary>
        public DbSet<ImagePO> Images { get; set; }
        
        /// <summary>
        /// 商户信息
        /// </summary>
        public DbSet<MerchantPO> Merchants { get; set; }
        
        /// <summary>
        /// 商户自定义类别信息
        /// </summary>
        public DbSet<MerchantCustomCategoryPO> MerchantCustomCategorys { get; set; }
        
        /// <summary>
        /// 商户图片信息
        /// </summary>
        public DbSet<MerchantImagePO> MerchantImages { get; set; }
        
        /// <summary>
        /// 商户消息
        /// </summary>
        public DbSet<MerchantMessagePO> MerchantMessages { get; set; }
        
        /// <summary>
        /// 订单信息
        /// </summary>
        public DbSet<OrderPO> Orders { get; set; }
        
        /// <summary>
        /// 订单详情信息
        /// </summary>
        public DbSet<OrderDetailPO> OrderDetails { get; set; }
        
        /// <summary>
        /// 产品信息
        /// </summary>
        public DbSet<ProductPO> Products { get; set; }
        
        /// <summary>
        /// 产品类别信息
        /// </summary>
        public DbSet<ProductCategoryPO> ProductCategorys { get; set; }
        
        /// <summary>
        /// 产品描述信息
        /// </summary>
        public DbSet<ProductDescriptionPO> ProductDescriptions { get; set; }
        
        /// <summary>
        /// 产品图片信息
        /// </summary>
        public DbSet<ProductImagePO> ProductImages { get; set; }
        
        /// <summary>
        /// 产品价格信息
        /// </summary>
        public DbSet<ProductSizePO> ProductSizes { get; set; }
        
        /// <summary>
        /// 促销信息
        /// </summary>
        public DbSet<PromotionPO> Promotions { get; set; }
        
        /// <summary>
        /// 促销阶梯信息
        /// </summary>
        public DbSet<PromotionLadderPO> PromotionLadders { get; set; }
        
        /// <summary>
        /// 学校信息
        /// </summary>
        public DbSet<SchoolPO> Schools { get; set; }
        
        /// <summary>
        /// 学校业务信息
        /// </summary>
        public DbSet<SchoolBusinessPO> SchoolBusinesss { get; set; }
        
        /// <summary>
        /// 学校新闻信息
        /// </summary>
        public DbSet<SchoolNewsPO> SchoolNewss { get; set; }
        
        /// <summary>
        /// 用户信息
        /// </summary>
        public DbSet<UserPO> Users { get; set; }
        
        /// <summary>
        /// 用户消息
        /// </summary>
        public DbSet<UserMessagePO> UserMessages { get; set; }
        
        /// <summary>
        /// 用户任务信息
        /// </summary>
        public DbSet<UserTaskPO> UserTasks { get; set; }
        
    }
}
