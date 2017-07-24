using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStudio.School.Input.Model.Product
{
    public class ProductModel
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
        public int CategoryId { get; set; }

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
