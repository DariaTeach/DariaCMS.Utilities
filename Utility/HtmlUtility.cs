using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DariaCMS.Utilities.Utility
{
    /// <summary>
    /// Remove Html From Text
    /// </summary>
   public class HtmlUtility
    {
        public static string RemoveHtmlTag(string HtmlCode)
        {
            if (HtmlCode != null)
            {
            Regex reg = new Regex("<[^>]+>|&nbsp;+|&zwnj;");
            var maches = reg.Matches(HtmlCode);
            foreach (Match item in maches)
            {
                HtmlCode = HtmlCode.Replace(item.Value, " ");
            }
            return HtmlCode;
            }
            else
            {
                return null;
            }
         
        }
    }
}
