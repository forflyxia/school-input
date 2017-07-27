using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStudio.School.Input.Infrastructure
{
    public static class StringTo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ToTypeT<T>(this string source)
        {
            return (T)Convert.ChangeType(source, typeof(T));
        }
    }
}
