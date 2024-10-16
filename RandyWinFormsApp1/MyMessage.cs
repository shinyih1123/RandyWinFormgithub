using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandyWinFormsApp1
{
    // 列舉 (好處:可以讓呼叫者去用點的方式選擇)
    public enum MessageLevel
    {
        Info,
        Warning,
        Danger,
        EndOfTheWorld
    }
    public class MyMessage
    {
        public void PrintMyMessage()
        {
            MessageBox.Show("您呼叫了在新類別中的方法");
        }
        //多載
        public void PrintMyMessage(string message, bool isShowTime, MessageLevel level = MessageLevel.Info)
        {
            string formattedTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if (isShowTime == true)
            {
                message = formattedTime + " " + message;
            }
            string severity = "Info";
            if (level == MessageLevel.Warning)
            {
                severity = "Warning";
            }
            else if (level == MessageLevel.Danger)
            {
                severity = "Danger";
            }
            else if (level == MessageLevel.EndOfTheWorld)
            {
                severity = "End of the world!!!!";
            }
            message = severity + " " + message;
            MessageBox.Show(message);
        }
    }
}
