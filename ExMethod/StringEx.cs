using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DariaCMS.Utilities.ExMethod
{
  public static  class StringEx
    {
        /// <summary>
        /// Remove Html Tags
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveHtmlTags(this string source)
        {
            if (source != null)
                return Regex.Replace(source, "<.*?>|&.*?;", string.Empty);
            else
                return "";
        }
        /// <summary>
        /// Convert Persian Numbers To English Numbers
        /// </summary>
        /// <param name="PersianNumbers"></param>
        /// <returns></returns>
        public static string ConvertNumbersToEnglish(this string PersianNumbers)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < PersianNumbers.Length; i++)
            {
                switch (PersianNumbers[i])
                {
                    //Persian digits
                    case '\u06f0':
                        sb.Append('0');
                        break;
                    case '\u06f1':
                        sb.Append('1');
                        break;
                    case '\u06f2':
                        sb.Append('2');
                        break;
                    case '\u06f3':
                        sb.Append('3');
                        break;
                    case '\u06f4':
                        sb.Append('4');
                        break;
                    case '\u06f5':
                        sb.Append('5');
                        break;
                    case '\u06f6':
                        sb.Append('6');
                        break;
                    case '\u06f7':
                        sb.Append('7');
                        break;
                    case '\u06f8':
                        sb.Append('8');
                        break;
                    case '\u06f9':
                        sb.Append('9');
                        break;

                    //Arabic digits    
                    case '\u0660':
                        sb.Append('0');
                        break;
                    case '\u0661':
                        sb.Append('1');
                        break;
                    case '\u0662':
                        sb.Append('2');
                        break;
                    case '\u0663':
                        sb.Append('3');
                        break;
                    case '\u0664':
                        sb.Append('4');
                        break;
                    case '\u0665':
                        sb.Append('5');
                        break;
                    case '\u0666':
                        sb.Append('6');
                        break;
                    case '\u0667':
                        sb.Append('7');
                        break;
                    case '\u0668':
                        sb.Append('8');
                        break;
                    case '\u0669':
                        sb.Append('9');
                        break;
                    default:
                        sb.Append(PersianNumbers[i]);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}
