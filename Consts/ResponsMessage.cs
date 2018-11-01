using System;
using System.Collections.Generic;
using System.Text;

namespace DariaCMS.Utilities.Consts
{
    /// <summary>
    /// Alert Message
    /// </summary>
    public static class ResponsMessage
    {
        public static string Saved(string title) => title + " ذخیره شد";
        public static string Edited(string title) => title + " ویرایش شد";
        public static string Deleted = "با موفقیت حذف شد";
        public static string Recover = "بازیابی با موفقیت انجام گردید";
        public static string Confirm = "عملیات با موفقیت انجام گردید";
        public static string Error = "عملیات انجام نشد، مقادیر ورودی را بررسی نمایید";
    }
}
