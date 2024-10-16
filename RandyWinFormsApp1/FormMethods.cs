using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandyWinFormsApp1
{
    public partial class FormMethods : Form
    {
        public void GetAllFilePaths(string dir, TreeNode curNote)
        {
            try
            {
                foreach (var directory in System.IO.Directory.GetDirectories(dir))
                {
                    var node = curNote.Nodes.Add(System.IO.Path.GetFileName(directory));
                    if (System.IO.Directory.GetDirectories(directory).Length > 0)
                    {
                        GetAllFilePaths(directory, node);
                    }
                }
            }
            catch (Exception ex)
            {
                // 處理異常，例如記錄錯誤訊息
                Console.WriteLine($"Error accessing directory {dir}: {ex.Message}");
            }
        }
        public FormMethods()
        {
            InitializeComponent();
        }
        private void PrintInClassMessage()
        {
            MessageBox.Show("您呼叫了在同類別中的方法");
        }
        private void buttonInScope_Click(object sender, EventArgs e)
        {
            //定義
            void PrintMessage()
            {
                MessageBox.Show("您呼叫了範圍中的方法");
            }
            //呼叫()
            PrintMessage();
        }

        private void buttonInClass_Click(object sender, EventArgs e)
        {
            PrintInClassMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintMyMessage();
        }

        private void buttonThreeParams_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            //myMessage.PrintMyMessage("自訂的方法 :)");
            myMessage.PrintMyMessage("我的自訂訊息", true, MessageLevel.Warning);
        }

        private void buttonOptionalParams_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintMyMessage("我的自訂訊息", true);
        }

        private void buttonNamedParams_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintMyMessage(isShowTime: false,
                                     level: MessageLevel.EndOfTheWorld,
                                     message: "具名參數!!!");
        }

        private void buttonDateTimeExtension_Click(object sender, EventArgs e)
        {
            DateTime taiwanNow = DateTime.Now;
            string formattedTime = taiwanNow.ToTaiwan();
            // 民國113年10月11日 (星期五)
            MessageBox.Show("台灣格式化時間 --> " + formattedTime);

        }

        private void buttonCreteTree_Click(object sender, EventArgs e)
        {
            //treeViewFolders.Nodes.Add("我的節點");
            var myNode = treeViewFolders.Nodes.Add("我的節點");
            // 從目前的目錄開始建立樹狀圖
            CreateTree(Environment.CurrentDirectory, myNode);

        }
        // 建立資料夾樹狀圖 (參數: 目錄, 當前節點)
        void CreateTree(string dir, TreeNode currentNode)
        {
            // 跑迴圈去看所有資料夾
            foreach (var directory in System.IO.Directory.GetDirectories(dir))
            {
                var node = currentNode.Nodes.Add(directory);
                // 若底下還有資料夾，繼續往下長
                if (System.IO.Directory.GetDirectories(directory).Length > 0)
                {
                    CreateTree(directory, node);
                }
            }
        }

        private void buttonQ1_Click(object sender, EventArgs e)
        {
            string Name = textBoxQ1.Text;
            if (Name == "")
            {
                MessageBox.Show("請輸入 手機 或 筆記型電腦 ");
                return;
            }
            else if (Name == "手機")
            {
                MyMethod myMethod = new MyMethod();
                myMethod.AddToCart("手機", isAddCoupon: true);
            }
            else if (Name == "筆記型電腦")
            {
                MyMethod myMethod = new MyMethod();
                myMethod.AddToCart("筆記型電腦", 2);
            }
            else
            {
                MessageBox.Show("請輸入 手機 或 筆記型電腦 ");
                return;
            }
        }

        private void buttonQ2_Click(object sender, EventArgs e)
        {
            string Name = textBoxQ2.Text;
            if (Name == "")
            {
                MessageBox.Show("請輸入 會議 或 生日 ");
                return;
            }
            else if (Name == "會議")
            {
                MyMethod myMethod = new MyMethod();
                string eventInfo = myMethod.AddEvent("會議", new DateTime(2024, 12, 31, hour: 14, minute: 30, second: 0));
                MessageBox.Show(eventInfo);
            }
            else if (Name == "生日")
            {
                MyMethod myMethod = new MyMethod();
                string eventInfo = myMethod.AddEvent("生日", new DateTime(2024, 9, 18), true);
                MessageBox.Show(eventInfo);
            }
            else
            {
                MessageBox.Show("請輸入 會議 或 生日 ");
                return;
            }
        }

        private void buttonQ3_Click(object sender, EventArgs e)
        {

            bool isValid = textBoxQ3.Text.IsValidEmail();
            if (isValid)
            {
                MessageBox.Show("電子郵件格式正確");
            }
            else
            {
                MessageBox.Show("電子郵件格式錯誤");
            }
        }

        private void buttonQ4_Click(object sender, EventArgs e)
        {
            string Name = textBoxQ4.Text;
            if (Name == "")
            {
                MessageBox.Show("請輸入 物品 ");
                return;

            }
            else
            {
                // 使用逗號分隔字串，並去除前後的空白字元
                string[] items = textBoxQ4.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                MyMethod myMethod = new MyMethod();
                string[] cleaned = myMethod.CleanProducts(items);
                MessageBox.Show(string.Join(",", cleaned));

            }

        }

        private void buttonQ5_Click(object sender, EventArgs e)
        {
            string DirFolder = textBoxQ5.Text;
            var myNode = treeViewFolders.Nodes.Add("我的節點");
            //GetAllFilePaths(Environment.CurrentDirectory, myNode);
            GetAllFilePaths(DirFolder, myNode);
        }
    }
}
