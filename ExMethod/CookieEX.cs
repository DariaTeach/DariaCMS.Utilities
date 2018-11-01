using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace DariaCMS.Utilities.ExMethod
{
    /// <summary>
    /// Cookies Extention Method
    /// </summary>
   public static class CookieEX
    {

        /// <summary>  
        /// Get the cookie  
        /// </summary>  
        /// <param name="key">Key </param>  
        /// <returns>string value</returns>  
        public static string Get(IHttpContextAccessor accessor, string key)
        {
            return accessor.HttpContext.Request.Cookies[key];
        }

        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        public static void Set(IHttpContextAccessor accessor, string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);
            
            accessor.HttpContext.Response.Cookies.Append(key, value, option);
        }

        /// <summary>  
        /// Delete the key  
        /// </summary>  
        /// <param name="key">Key</param>  
        public static void Remove(IHttpContextAccessor accessor,string key)
        {
            accessor.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
