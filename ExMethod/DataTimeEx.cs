using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DariaCMS.Utilities.ExMethod
{
    /// <summary>
    /// To Shamsi Extention Method
    /// </summary>
   public static class DataTimeEx
    {
        public static DateTime ToShamsi(this DateTime dt)
        {
            PersianCalendar pDate = new PersianCalendar();
            int Day = pDate.GetDayOfMonth(dt);
            int Month = pDate.GetMonth(dt);
            int Year = pDate.GetYear(dt);
            int Hour = pDate.GetHour(dt);
            int Minute = pDate.GetMinute(dt);
            int Second = pDate.GetSecond(dt);
            return new DateTime(Year, Month, Day, Hour, Minute, Second);
        }
    }
}
