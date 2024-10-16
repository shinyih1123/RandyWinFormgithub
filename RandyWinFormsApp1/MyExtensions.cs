using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandyWinFormsApp1
{
    static internal class MyExtensions
    {
        public static bool IsValidEmail(this string mailadd)
        {
            bool result = false;
            //判斷該字串是否符合電子郵件格式（包含 "@" 和 "." 的基本驗證）
            if (mailadd.Contains("@") && mailadd.Contains("."))
            {
                result = true;
            }


            return result;
        }
    }
}
