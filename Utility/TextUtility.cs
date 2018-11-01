using System;
using System.Collections.Generic;
using System.Text;

namespace DariaCMS.Utilities.Utility
{
    /// <summary>
    /// Text Limitation
    /// </summary>
   public class TextUtility
    {
        public static string TextLimitLength(string Text, int maxLength)
        {
            if (Text != null)
            {
                if (Text.Length <= maxLength)
                {
                    return Text;
                }
                else
                {
                    return Text.Substring(0, maxLength) + "...";
                }

            }
            else
            {
                return null;
            }

        }
    }
}
