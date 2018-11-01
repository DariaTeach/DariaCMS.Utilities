using System;
using System.Collections.Generic;
using System.Text;

namespace DariaCMS.Utilities.Consts
{
    /// <summary>
    /// Model Error Message
    /// </summary>
  public class ErrMsg
    {
        public const string RequierdMsg = "{0} را وارد کنید";
        public const string MaxLenMsg = "{0} نباید بیشتر از {1} کاراکتر باشد";
        public const string MinLenMsg = "{0} نباید کمتر از {1} کاراکتر باشد ";
        public const string RegEx = "ساختار {0} درست نمی باشد";
        public const string StringLength = "{0} باید حداقل {2} و حداکثر{1} حرف باشد";
        public const string PassWordNotMatch = "رمزهای عبور وارد شده همخوانی ندارند.";
    }
}
