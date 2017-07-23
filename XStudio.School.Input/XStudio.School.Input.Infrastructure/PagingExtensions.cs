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
        /// <param name="source"></param>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        public static IQueryable<T> Filter<T>(this IQueryable<T> query, Dictionary<string, string> searchParameters)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            Expression where = null;
            foreach (var entry in searchParameters)
            {
                var property = typeof(T).GetProperty(entry.Key);
                var constant = Expression.Constant(entry.Value);

                Expression left = Expression.Property(parameter, property);
                Expression expression;
                if (property.PropertyType.Name == "Int32")
                {
                    int value = int.Parse(entry.Value);
                    Expression right = Expression.Constant(value);
                    expression = Expression.Equal(left, right);
                }
                else
                {
                    Expression right = Expression.Constant(entry.Value);
                    expression = Expression.Call(left, typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), right);
                }
                if (where == null)
                {
                    where = expression;
                }
                else
                {
                    where = Expression.And(where, expression);
                }
            }
            if (where != null)
            {
                Func<T, bool> f = (Func<T, bool>)Expression.Lambda(where, parameter).Compile();
                return query.Where(f).AsQueryable();
            }
            return query;
        }
    }
}
