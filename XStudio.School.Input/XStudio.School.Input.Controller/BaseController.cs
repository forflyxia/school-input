using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XStudio.School.Input.Infrastructure;

namespace XStudio.School.Input.Controller
{
    public class BaseController : System.Web.Mvc.Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="paraName"></param>
        /// <returns></returns>
        public T GetParams<T>(string paraName)
        {
            var value = Request.QueryString[paraName];
            if (string.IsNullOrWhiteSpace(value))
            {
                return default(T);
            }
            return value.ToTypeT<T>();
        }
    }
}