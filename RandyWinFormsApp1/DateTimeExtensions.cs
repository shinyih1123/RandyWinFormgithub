using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RandyWinFormsApp1
{
    static public class DateTimeExtensions
    {
        static public string ToTaiwan(this DateTime dateTime)
        {
            // 民國年
            int taiwanYear = dateTime.Year - 1911;
            // 抓星期幾 (星期幾是DayOfWeek的列舉enum)
            DayOfWeek dayOfWeek = dateTime.DayOfWeek;
            string taiwanDayOfWeek = "";
            if (dayOfWeek == DayOfWeek.Monday)
            {
                taiwanDayOfWeek = "一";
            }
            else if (dayOfWeek == DayOfWeek.Tuesday)
            {
                taiwanDayOfWeek = "二";
            }
            else if (dayOfWeek == DayOfWeek.Wednesday)
            {
                taiwanDayOfWeek = "三";
            }
            else if (dayOfWeek == DayOfWeek.Thursday)
            {
                taiwanDayOfWeek = "四";
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                taiwanDayOfWeek = "五";
            }
            else if (dayOfWeek == DayOfWeek.Saturday)
            {
                taiwanDayOfWeek = "六";
            }
            else if (dayOfWeek == DayOfWeek.Sunday)
            {
                taiwanDayOfWeek = "日";
            }
            // 回傳格式化後的時間
            return $"民國{taiwanYear}年{dateTime.Month}月{dateTime.Day} (星期{taiwanDayOfWeek})";
        }
    }
}
