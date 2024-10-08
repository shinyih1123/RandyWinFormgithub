﻿using ClosedXML.Excel;
using Dapper;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using System.Linq;
using DocumentFormat.OpenXml.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;


namespace RandyWinFormsApp1
{

    public partial class Form1 : Form
    {
        public string ConnString { get; set; }
        private DataTable itemsDataTable = new DataTable();
        private List<Items> itemsList = new List<Items>();
        public string Sqlstr = @"Server=localhost;Database=master;User Id=SYSADM;Password=SYSADM";
        private int[] ans = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//正確答案
        private String[] gnum = new string[10];//猜的答案數字
        private int tmp, r, time;
        private Random ran = new Random();
        List<Employee> items = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            Query();

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxInput.Enabled = true;
            textBoxResult.Text = "";
            textBoxInput.Text = "";
            time = 0;
            buttonGuess.Enabled = true;
            buttonGiveUp.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                ans[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                r = ran.Next(0, 10);
                tmp = ans[r];
                ans[r] = ans[9 - i];
                ans[9 - i] = tmp;
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string num = "";
            time = time + 1;
            int a = 0, b = 0;
            if (textBoxInput.TextLength != 4)
            {
                MessageBox.Show("請輸入4個不一樣的數字");
            }
            else
            {
                for (int j = 1; j <= 4; j++)
                {
                    gnum[j] = textBoxInput.Text.Substring(j - 1, 1);
                    num += gnum[j];
                }
                if ((gnum[1] == gnum[2] || gnum[1] == gnum[3] ||
                gnum[1] == gnum[4] || gnum[2] == gnum[3] ||
                gnum[2] == gnum[4] || gnum[3] == gnum[4]))
                {
                    MessageBox.Show("不能輸入重複的數字哦");
                }
                else
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        for (int l = 1; l <= 4; l++)
                        {
                            if (gnum[k] == ans[l].ToString())
                            {
                                if (k == l)
                                {
                                    a++;
                                }
                                else if (k != l)
                                {
                                    b++;
                                }
                            }
                        }
                    }
                    textBoxResult.Text += time + "---------" + num + "----------" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
                    //label3.Text = "第" + (listBoxResult.Lines.Length - 1) + "猜";
                    textBoxInput.Focus();
                    textBoxInput.SelectAll();
                }
                if (a == 4 && b == 0)
                {
                    MessageBox.Show("恭喜你猜對了");
                    textBoxInput.Enabled = false;
                }
                else if (textBoxResult.Lines.Length == 11)
                {
                    MessageBox.Show("你要再加油了");
                    textBoxInput.Enabled = false;
                }
            }
        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            //textBoxResult.Text = "";
            textBoxResult.Text += "Ans===" + ans[1] + ans[2] + ans[3] + ans[4] + "====" + "\r\n";
            textBoxInput.Enabled = false;
            buttonGuess.Enabled = false;
            buttonGiveUp.Enabled = false;
            //for (int i = 1; i <= 4; i++)
            //{
            //    textBoxResult.Text += ans[i];
            //}
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //測試是否可以連線到資料庫
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"
            //            Server=192.168.1.9;
            //            Database=_SmartManTest;
            //            user Id=SYSADM;
            //            Password=SYSADM";
            //itemsService.ConnString = conn.ConnectionString;
            //conn.Open();
            //MessageBox.Show("連線成功");
            Query();
            //conn.Close();
            //
        }
        public void Query()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Sqlstr;
            conn.Open();
            items = conn.Query<Employee>("Select * From Items").ToList();
            dataGridView1.DataSource = items;
            List<string> headerNames = ["項次", "名稱", "描述", "價值", "數量", "種類"];
            // set datagridview header names to above
            for (int i = 0; i < headerNames.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = headerNames[i];
            }

            //itemsDataTable.Clear();
            //itemsDataTable.DefaultView.RowFilter = string.Empty;
            //itemsDataTable.DefaultView.Sort = string.Empty;

            //using (SqlConnection conn = new SqlConnection(Sqlstr))
            //{
            //    conn.Open();
            //    using (var reader = conn.ExecuteReader("Select * From Items"))
            //    {
            //        itemsDataTable.Load(reader);
            //        dataGridView1.DataSource = itemsDataTable;
            //        dataGridView1.AllowUserToAddRows = true;

            //    }
            //}

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = itemsService.ConnString;
            //itemsService.ConnString = conn.ConnectionString;
            //conn.Open();
            //List<Employee> employees = new List<Employee>();
            //employees = conn.Query<Employee>("Select * From items").ToList();
            //conn.Close();
            //dataGridView1.DataSource = employees;
            //// set so whole row is selected 讓整行被選取
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //// can only select one row at a time 不可以多選
            //dataGridView1.MultiSelect = false;
            //// read only
            //dataGridView1.ReadOnly = true;
            Query();
            //折線圖
            // 按種類分組並計算總價值
            var groupedItems = items
                .GroupBy(p => p.Type)
                .Select(g => new
                {
                    Type = g.Key,
                    TotalMarketValue = g.Sum(p => decimal.Parse(p.MarketValue)), // 計算同一種類的總價值
                    TotalQualtity = g.Sum(p => decimal.Parse(p.Quantity)) // 計算同一種類的總價值
                })
                .OrderByDescending(g => g.TotalMarketValue) // 按總價值降序排序
                .Take(10) // 取前10個
                .ToList();
            cartesianChart1.Series =
                [
                    new LineSeries<int>
                    {
                        Values = groupedItems.Select(t => ((int)t.TotalMarketValue)) // 用Select選取總價值
                    },
                ];
            cartesianChart1.Title = new LabelVisual
            {
                Text = "勇者物品全種類價值",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            //X軸
            cartesianChart1.XAxes = new Axis[]
                {
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        Labels = groupedItems.Select(t => t.Type).ToList(),
                        Name = "物品種類",
                        NamePaint = new SolidColorPaint(SKColors.Black),
                        LabelsPaint = new SolidColorPaint(SKColors.Blue),
                        TextSize = 16,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) { StrokeThickness = 2 }
                    }
                };
            //Y軸
            cartesianChart1.YAxes = new Axis[]
               {
                    new Axis
                    {
                        Name = "價值",
                        NamePaint = new SolidColorPaint(SKColors.Red),
                        LabelsPaint = new SolidColorPaint(SKColors.Green),
                        TextSize = 20,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                        {
                            StrokeThickness = 2,
                            PathEffect = new DashEffect(new float[] { 3, 3 })
                        }
                    }
               };
            //直條圖
            // 按種類分組並計算總價值
            var top10ItemsQualtity = items
                .GroupBy(p => p.Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Quantity = g.Sum(p => decimal.Parse(p.Quantity)) // 計算同一種類的總價值
                })
                .OrderByDescending(g => g.Quantity) // 按總價值降序排序
                .Take(15) // 取前15個
                .ToList();
            cartesianChart2.Series =
                [
                    // 設定直條圖物件 (值是int整數型態)
                    new ColumnSeries<int>
                    {
                        Values = top10ItemsQualtity.Select(t => ((int)t.Quantity)).ToList(), // 選取停車格數量
                    }
                ];
            //cartesianChart2.Series = new ISeries[]
            //{
            //    new ColumnSeries<double>
            //    {
            //        Values = new double[] { 2, 5, 4, 2, 4, 9, 5 }
            //    }
            //};
            // 設定圖表上方的標題
            cartesianChart2.Title = new LabelVisual
            {
                Text = "前15名數量最多的物品",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            //X軸
            cartesianChart2.XAxes = new Axis[]
                {
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        //Labels = totalSpacesByAreaName.Select(t => t.areaName).ToList(),
                        //Labels = new string[] { "Anne", "Johnny", "Zac", "Rosa" },
                        Labels = top10ItemsQualtity.Select(t => t.Name).ToList(),
                        Name = "物品名稱",
                        NamePaint = new SolidColorPaint(SKColors.Black),
                        LabelsPaint = new SolidColorPaint(SKColors.Blue),
                        TextSize = 16,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) { StrokeThickness = 2 },
                        LabelsRotation = 45
                    }
                };
            //Y軸
            cartesianChart2.YAxes = new Axis[]
               {
                    new Axis
                    {
                        Name = "數量",
                        NamePaint = new SolidColorPaint(SKColors.Red),
                        LabelsPaint = new SolidColorPaint(SKColors.Green),
                        TextSize = 20,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                        {
                            StrokeThickness = 2,
                            PathEffect = new DashEffect(new float[] { 3, 3 })
                        }
                    }
               };
            //圓餅圖
            // 計算總市場價值的總和
            var totalMarketValue = groupedItems.Sum(t => t.TotalMarketValue);
            // 產生圓餅圖: 先用物品價值大到小排序，再用Select選取種類名稱和價值
            pieChart1.Series = groupedItems
                .OrderByDescending(t => t.TotalMarketValue)
                // 這裡每個Select都要建一個PieSeries物件
                .Select(t => new PieSeries<int>
                {
                    // 這裡是圓餅圖的值，這裡是物品價值
                    Values = new List<int> { ((int)t.TotalMarketValue) },
                    MaxRadialColumnWidth = 120,
                    Name = t.Type,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 22,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    // 設定圓餅圖上的標籤格式=區域名稱: 停車場數量
                    //DataLabelsFormatter = p => t.Type + ": " + t.TotalMarketValue +"("+ (t.TotalMarketValue / totalMarketValue * 100)+"%)"
                    DataLabelsFormatter = p =>
                    $"{t.Type}: {t.TotalMarketValue} ({(t.TotalMarketValue / totalMarketValue * 100):0.##}%)"
                })
                .ToList();

            // 設定圖表上方的標題
            pieChart1.Title = new LabelVisual
            {
                Text = "勇者物品全種類價值",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            //圓餅圖II
            pieChart2.Series = groupedItems
                .OrderByDescending(t => t.TotalMarketValue)
                // 這裡每個Select都要建一個PieSeries物件
                .Select(t => new PieSeries<int>
                {
                    // 這裡是圓餅圖的值，這裡是物品價值
                    Values = new List<int> { ((int)t.TotalMarketValue) },
                    MaxRadialColumnWidth = 120,

                    Name = t.Type,
                    Stroke = null,
                    Fill = new RadialGradientPaint(new SKColor(255, 205, 210), new SKColor(183, 218, 28)),
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    Pushout = 1,
                    //DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    // 設定圓餅圖上的標籤格式=區域名稱: 停車場數量
                    //DataLabelsFormatter = p => t.Type + ": " + t.TotalMarketValue +"("+ (t.TotalMarketValue / totalMarketValue * 100)+"%)"
                    DataLabelsFormatter = p =>
                    $"{t.Type}: {t.TotalMarketValue} ({(t.TotalMarketValue / totalMarketValue * 100):0.##}%)"
                })
                .ToList();

            //ISeries[] pieCharts2 =
            // [
            //   new PieSeries<int>
            //    {
            //        Name = "夏天",
            //        Values = new[] { 3 }, // 值
            //        Stroke = null,
            //        Fill = new RadialGradientPaint(new SKColor(255, 205, 210), new SKColor(183, 28, 28)) // 漸層顏色變化(這裡可以塞很多顏色)
            //    },
            //   new PieSeries<int>
            //    {
            //        Name = "秋天",
            //        Values = new[] { 4 },
            //        Stroke = null,
            //        Fill = new RadialGradientPaint([new SKColor(79, 229, 252)]),
            //        Pushout = 10,
            //        OuterRadiusOffset = 20
            //    },
            //   new PieSeries<int>
            //    {
            //        Name = "冬天",
            //        Values = new[] { 7 },
            //        Stroke = null,
            //        Fill = new RadialGradientPaint([new SKColor(179, 229, 252)]),
            //        Pushout = 10,
            //        OuterRadiusOffset = 20
            //    },
            //];
            //pieChart2.Series = pieCharts2;
            pieChart2.Title = new LabelVisual
            {
                Text = "勇者物品全種類價值",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };


        }


        private void tabPageGuessNumber_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // get the Employee data from row
            // 把員工資料抓出來
            Employee employee = new Employee();
            if (isSelected)
            {
                employee.Id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                employee.Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                employee.Description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
                employee.MarketValue = dataGridView1.SelectedRows[0].Cells["MarketValue"].Value.ToString();
                employee.Quantity = dataGridView1.SelectedRows[0].Cells["Quantity"].Value.ToString();
                employee.Type = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();
            }
            else
            {
                MessageBox.Show("請選擇一件物品");
                return;
            }
            FormUpdate formUpdate = new FormUpdate(employee);
            formUpdate.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // 檢查有沒有選一行資料列
            if (isSelected == false)
            {
                MessageBox.Show("請選擇一項物品");
                return;
            }
            //string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            //string Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            // 跳訊息確定是否要刪除
            //var result = MessageBox.Show("確定要刪除 編號" + id + " " + Name + "嗎?", "刪除物品", MessageBoxButtons.YesNo);
            // 如果選NO就結束
            //if (result == DialogResult.No)
            //{
            //    return;
            //}
            SqlConnection conn = new SqlConnection(Sqlstr);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                string id = row.Cells["id"].Value.ToString();
                conn.Execute("Delete From items Where id = @id", new { id });
            }
            //SqlConnection conn = new SqlConnection(itemsService.ConnString);
            //string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            //conn.Execute("Delete From items Where id = @id", new { id });
            MessageBox.Show("刪除成功");
            items = conn.Query<Employee>("Select * From Items").ToList();
            dataGridView1.DataSource = items;
            conn.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            FormInsert formInsert = new FormInsert(employee);
            formInsert.ShowDialog();
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            string indexfilter = textBoxIndex.Text;

            if (string.IsNullOrEmpty(indexfilter))
            {
                // 如果搜尋框是空的，顯示所有資料
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // 根據輸入內容進行條件搜尋
                string filterExpression = $"Name LIKE '%{indexfilter}%' OR Type LIKE '%{indexfilter}%' OR Description LIKE '%{indexfilter}%'";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // get the Employee data from row
            // 把員工資料抓出來
            Employee employee = new Employee();
            if (isSelected)
            {
                employee.Id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                employee.Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                employee.Description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
                employee.MarketValue = dataGridView1.SelectedRows[0].Cells["MarketValue"].Value.ToString();
                employee.Quantity = dataGridView1.SelectedRows[0].Cells["Quantity"].Value.ToString();
                employee.Type = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();
            }
            else
            {
                MessageBox.Show("請選擇一件物品");
                return;
            }
            FormUpdate formUpdate = new FormUpdate(employee);
            formUpdate.ShowDialog();
        }

        private void buttonUnLoadCSV_Click(object sender, EventArgs e)
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

        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            string LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "CSV files (*.csv)|*.csv";
            var result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // 顯示剛抓檔案的名稱
                //labelFileName.Text = OpenFileDialog.FileName;
                // 讀取檔案的內容 (讀取的每一行塞到data字串陣列string[]) 950 	big5
                string[] lines = File.ReadAllLines(OpenFileDialog.FileName);
                // 先清空listbox的items
                //listBoxCSV.Items.Clear();
                //foreach (var item in lines)
                //{
                //    listBoxCSV.Items.Add(item);
                //}
                // 把資料呈現到dataGridView 
                // 先建立陣列item
                List<Employee> items = new List<Employee>();
                SqlConnection conn = new SqlConnection(Sqlstr);
                conn.Open();
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
                    // 存檔
                    //SqlConnection conn = new SqlConnection(Sqlstr);
                    //conn.Open();
                    Sqlstr = @"Insert into Items(Name,Description,MarketValue,Quantity,Type,LastUpdated)
                               Values(@Name,@Description,@MarketValue,@Quantity,@Type,@LastUpdated)";
                    conn.Execute(Sqlstr,
                    new { item.Name, item.Description, item.MarketValue, item.Quantity, item.Type, LastUpdated }
                    );
                    conn.Close();
                }
                //dataGridView1.DataSource = items; // 把 items 顯示在 grid 上面
                MessageBox.Show("CSV匯入完成!");
                items = conn.Query<Employee>("Select * From Items").ToList();
                dataGridView1.DataSource = items;
                //Query();
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            List<string> headerNames = ["項次", "名稱", "描述", "價值", "數量", "種類"];
            // set datagridview header names to above
            for (int i = 0; i < headerNames.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = headerNames[i];
            }
            using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("勇者物品");
                for (int i = 0; i < headerNames.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headerNames[i];
                }
                worksheet.Cell(2, 1).InsertData(items);
                //價值前10高物品
                var worksheet2 = workbook.Worksheets.Add("價值前10高物品");
                var top = items.OrderByDescending(p => int.Parse(p.MarketValue)).Take(10).ToList();
                worksheet2.Cell(1, 1).Value = "項次";
                worksheet2.Cell(1, 2).Value = "名稱";
                worksheet2.Cell(1, 3).Value = "價值";
                worksheet2.Cell(1, 4).Value = "描述";
                worksheet2.Cell(1, 5).Value = "數量";
                worksheet2.Cell(1, 6).Value = "種類";
                for (int i = 0; i < top.Count; i++)
                {
                    worksheet2.Cell(i + 2, 1).Value = top[i].Id;
                    worksheet2.Cell(i + 2, 2).Value = top[i].Name;
                    worksheet2.Cell(i + 2, 3).Value = top[i].MarketValue;
                    worksheet2.Cell(i + 2, 4).Value = top[i].Description;
                    worksheet2.Cell(i + 2, 5).Value = top[i].Quantity;
                    worksheet2.Cell(i + 2, 6).Value = top[i].Type;
                }
                //數量前10高物品
                var worksheet3 = workbook.Worksheets.Add("數量前10高物品");
                var topQ10 = items.OrderByDescending(p => int.Parse(p.Quantity)).Take(10).ToList();
                worksheet3.Cell(1, 1).Value = "項次";
                worksheet3.Cell(1, 2).Value = "名稱";
                worksheet3.Cell(1, 3).Value = "數量";
                worksheet3.Cell(1, 4).Value = "描述";
                worksheet3.Cell(1, 5).Value = "價值";
                worksheet3.Cell(1, 6).Value = "種類";
                for (int i = 0; i < topQ10.Count; i++)
                {
                    worksheet3.Cell(i + 2, 1).Value = topQ10[i].Id;
                    worksheet3.Cell(i + 2, 2).Value = topQ10[i].Name;
                    worksheet3.Cell(i + 2, 3).Value = topQ10[i].Quantity;
                    worksheet3.Cell(i + 2, 4).Value = topQ10[i].Description;
                    worksheet3.Cell(i + 2, 5).Value = topQ10[i].MarketValue;
                    worksheet3.Cell(i + 2, 6).Value = topQ10[i].Type;
                }
                //數量前10高物品
                var worksheet4 = workbook.Worksheets.Add("物品類別總價值");
                // 設置工作表背景顏色為黃色
                worksheet4.TabColor = XLColor.Yellow;
                //var topType = items.OrderByDescending(p => int.Parse(p.Type)).Take(10).ToList();
                // 設置表頭樣式，灰色背景和白色字體
                var headerRange = worksheet4.Range(1, 1, 1, 2);
                headerRange.Style.Fill.BackgroundColor = XLColor.Gray;
                headerRange.Style.Font.FontColor = XLColor.White;
                headerRange.Style.Font.Bold = true; // 可選，讓字體加粗
                // 按種類分組並計算總價值
                var groupedItems = items
                    .GroupBy(p => p.Type)
                    .Select(g => new
                    {
                        Type = g.Key,
                        TotalMarketValue = g.Sum(p => decimal.Parse(p.MarketValue)) // 計算同一種類的總價值
                    })
                    .OrderByDescending(g => g.TotalMarketValue) // 按總價值降序排序
                    .Take(10) // 取前10個
                    .ToList();
                worksheet4.Cell(1, 1).Value = "種類";
                worksheet4.Cell(1, 2).Value = "價值";

                for (int i = 0; i < groupedItems.Count; i++)
                {
                    worksheet4.Cell(i + 2, 1).Value = groupedItems[i].Type;
                    worksheet4.Cell(i + 2, 2).Value = groupedItems[i].TotalMarketValue;
                    worksheet4.Cell(i + 2, 2).Style.Font.FontColor = XLColor.Red;
                }
                //以種類group by產出
                var groupByArea = items.GroupBy(p => p.Type);
                foreach (var group in groupByArea)
                {
                    var worksheetByArea = workbook.Worksheets.Add(group.Key);
                    var parkLotsByArea = group.ToList();
                    for (int i = 0; i < headerNames.Count; i++)
                    {
                        worksheetByArea.Cell(1, i + 1).Value = headerNames[i];
                    }
                    worksheetByArea.Cell(2, 1).InsertData(parkLotsByArea);
                }

                workbook.SaveAs("勇者物品.xlsx");
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "勇者物品.xlsx",
                    UseShellExecute = true,
                };
                System.Diagnostics.Process.Start(psi);
            }
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            string Font = "Microsoft JhengHei";
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    //
                    page.Header().
                    Background(QuestPDF.Helpers.Colors.LightGreen.Lighten5).
                    AlignCenter().
                    Padding(1).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(1);
                        });
                        table.Cell().AlignCenter().Text("勇者物品清單").FontFamily(Font).FontSize(16);
                        table.Cell().AlignRight().Text("列印日期: " + DateTime.Now.ToString("yyyy/MM/dd")).FontFamily(Font);
                    });
                    
                    page.Content().
                    Background(QuestPDF.Helpers.Colors.Cyan.Lighten5).
                    AlignCenter().
                    Padding(16).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            //columns.ConstantColumn(1);
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(1);
                        });
                        table.Header(headers =>
                        {
                            table.Cell().BorderBottom(2).BorderBottom(2).BorderTop(2).AlignCenter().Text("名稱").FontFamily(Font); 
                            table.Cell().BorderBottom(2).BorderTop(2).AlignCenter().Text("描述").FontFamily(Font);
                            table.Cell().BorderBottom(2).BorderTop(2).AlignCenter().Text("價值").FontFamily(Font);
                            table.Cell().BorderBottom(2).BorderTop(2).AlignCenter().Text("數量").FontFamily(Font);
                            table.Cell().BorderBottom(2).BorderTop(2).AlignCenter().Text("數類").FontFamily(Font);
                        });
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string Name = row.Cells[1].Value.ToString();
                            string Description = row.Cells[2].Value.ToString();
                            string MarketValueValue = row.Cells[3].Value.ToString();
                            string Quantity = row.Cells[4].Value.ToString();
                            string Type = row.Cells[5].Value.ToString();

                            table.Cell().BorderBottom(1).AlignCenter().Text(Name).FontFamily(Font);
                            table.Cell().BorderBottom(1).AlignLeft().Text(Description).FontFamily(Font);
                            table.Cell().BorderBottom(1).AlignCenter().Text(MarketValueValue);
                            table.Cell().BorderBottom(1).AlignCenter().Text(Quantity);
                            table.Cell().BorderBottom(1).AlignCenter().Text(Type).FontFamily(Font);
                        }
                        //for (int i = 0; i < 200; i++)
                        //{
                        //    table.Cell().BorderBottom(1).AlignCenter().Text($"Item {i}");
                        //}
                    });
 
                    page.Footer()
                //.Background(Colors.Purple.Lighten3)
                .Background(QuestPDF.Helpers.Colors.Red.Lighten5)
                .AlignCenter()
                //.Text("表尾")
                .Text(text =>
                        {
                           text.CurrentPageNumber();
                            text.Span(" / ");
                            text.TotalPages();
                        });
                });

            })
            .GeneratePdf("d:\\勇者物品.pdf");

            Process.Start(new ProcessStartInfo()
            {
                FileName = "d:\\勇者物品.pdf",
                UseShellExecute = true
            });
        }
    }
}