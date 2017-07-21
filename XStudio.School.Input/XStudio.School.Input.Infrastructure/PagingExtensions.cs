using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XStudio.School.Input.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public static class PagingExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="q"></param>
        /// <param name="direction"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static IQueryable<T> OrderByEx<T>(this IQueryable<T> q, string direction, string fieldName)
        {
            var param = Expression.Parameter(typeof(T), "p");
            var prop = Expression.Property(param, fieldName);
            var exp = Expression.Lambda(prop, param);
            
            string method = direction.ToLower() == "asc" ? "OrderBy" : "OrderByDescending";
            Type[] types = new Type[] { q.ElementType, exp.Body.Type };
            var mce = Expression.Call(typeof(Queryable), method, types, q.Expression, exp);
            return q.Provider.CreateQuery<T>(mce);
        }  
    }
}
