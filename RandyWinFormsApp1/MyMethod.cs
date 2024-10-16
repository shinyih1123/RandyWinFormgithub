using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandyWinFormsApp1
{
    public class MyMethod
    {
        public void AddToCart(string msg)
        {
            MessageBox.Show(msg);
        }
        public void AddToCart(string msg, bool isAddCoupon)
        {
            if (isAddCoupon)
            {
                msg += "已加入購物車，使用了優惠券。";
            }
            else
            {
                msg += "已加入購物車。";
            }
            MessageBox.Show(msg);
        }

        public void AddToCart(string msg, int n)
        {
            if (n > 0)
            {
                msg = n.ToString() + " 個" + msg + "已加入購物車。";
            }
            else
            {
                msg += "已加入購物車。";
            }

            MessageBox.Show(msg);
        }
        public string AddEvent(string msg, DateTime dt)
        {
            string result = msg + " - " + dt.ToString("yyyy/MM/dd HH:mm");
            return result;
        }
        public string AddEvent(string msg, DateTime dt, bool AllDay)
        {
            string result = msg + " - " + dt.ToString("yyyy/MM/dd");
            if (AllDay)
            {
                result += " (全天)";
            }
            return result;
        }
        public string[] CleanProducts(string[] source)
        {
            string[] result = source.Select(x => x.Replace(" ", "")).Distinct().ToArray();
            return result;
        }
    }
}
