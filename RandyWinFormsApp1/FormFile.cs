using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandyWinFormsApp1
{
    public partial class FormFile : Form
    {
        List<Employee> items = new List<Employee>();
        public FormFile()
        {
            InitializeComponent();
            //註冊點擊事件 +=
            buttonLoad.Click += ButtonLoad_Click;
        }

        private void ButtonLoad_Click(object? sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "CSV files (*.csv)|*.csv";
            var result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // 顯示剛抓檔案的名稱
                labelFileName.Text = OpenFileDialog.FileName;
                // 讀取檔案的內容 (讀取的每一行塞到data字串陣列string[]) 950 	big5
                string[] lines = File.ReadAllLines(OpenFileDialog.FileName);
                // 先清空listbox的items
                listBoxFileData.Items.Clear();
                foreach (var item in lines)
                {
                    listBoxFileData.Items.Add(item);
                }
                // 把資料呈現到dataGridView 
                // 先建立陣列item
                //List<Employee> items = new List<Employee>();
                // 跑迴圈一個一個到進去上面的item陣列
                for (var i = 1; i < lines.Length; i++)
                {
                    var splitData = lines[i].Split(","); // 用後號分割，分割完後回傳字串陣列string[]
                    Employee item = new Employee();
                    item.Name = splitData[0]; // 第一個是名稱
                    item.Type = splitData[1];
                    item.MarketValue = splitData[2];
                    item.Quantity = splitData[3];
                    item.Description = splitData[4];
                    items.Add(item); // 把建立好的 item 加到 items 陣列
                }
                dataGridViewFileData.DataSource = items; // 把 items 顯示在 grid 上面
            }


        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // 將匯入的資料再轉出去一次，但是可以指定路徑
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // 開啟存檔案dialog
            var result = saveFileDialog.ShowDialog();
            // 建立空的字串行資料
            List<string> lines = new List<string>();
            // 若使用者按下OK
            if (result == DialogResult.OK)
            {
                // 檔案名稱
                string filePath = saveFileDialog.FileName;
                lines.Add("名稱,種類,價值,數量,描述");
                // 把lines塞滿資料
                foreach (var item in items)
                {
                    string singleLineData = item.Name + "," + item.Type + "," + item.MarketValue + "," + item.Quantity.ToString() + "," + item.Description;
                    lines.Add(singleLineData);
                }
                // 把剛剛匯入的資料寫道指定檔案中
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("儲存到" + filePath + "了!");
            }
        }
     }
}
