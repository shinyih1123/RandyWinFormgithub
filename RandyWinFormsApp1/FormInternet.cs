using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandyWinFormsApp1
{
    public partial class FormInternet : Form
    {
        public List<StockData> StockDatas { get; set; } = new List<StockData>();
        public FormInternet()
        {
            InitializeComponent();
            textBoxURL.Text = "https://www.twse.com.tw/exchangeReport/STOCK_DAY_ALL?response=open_data";
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text;


            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(url).Result;
                //抓下來的檔案先存起來，檔案名稱為stock.csv
                File.WriteAllText("stock.csv", data);
                //直接開啟檔案
                //ProcessStartInfo psi = new ProcessStartInfo()
                //{
                //    FileName = "stock.csv",
                //    UseShellExecute = true,
                //};
                //Process.Start(psi);
                // 換行符號/r/n
                List<string> lines = new List<string>();
                lines = data.Split("\r\n").ToList();
                // 資料呈現listbox
                foreach (string line in lines)
                {
                    listBoxFileData.Items.Add(line);
                }
                // 用類別把資料接起來
                List<StockData> stocks = new List<StockData>();
                for (int i = 0; i < lines.Count; i++)
                {
                    lines[i] = lines[i].Replace("\"", "");
                    if (i == 0)
                    {
                        continue;
                    }
                    var items = lines[i].Split(",").ToList();
                    if (items.Count < 2)
                    {
                        continue;
                    }
                    StockData stockData = new StockData();
                    stockData.ID = items[0];
                    //stockData.ID = items[0].Replace("\"", "");
                    stockData.StockName = items[1].Replace("\"", "");
                    stockData.StockTraded = int.TryParse(items[2], out _) ? int.Parse(items[2]) : 0;
                    stockData.StockAmount = int.TryParse(items[3], out _) ? int.Parse(items[3]) : 0;
                    stockData.StartAmount = double.TryParse(items[4], out _) ? double.Parse(items[4]) : 0;
                    stockData.HighestAmount = double.TryParse(items[5], out _) ? double.Parse(items[5]) : 0;
                    stockData.LowestAmount = double.TryParse(items[6], out _) ? double.Parse(items[6]) : 0;
                    stockData.FinalTradedAmount = double.TryParse(items[7], out _) ? double.Parse(items[7]) : 0;
                    stockData.AmountChanged = double.TryParse(items[8], out _) ? double.Parse(items[8]) : 0;
                    stockData.TradeCount = int.TryParse(items[9], out _) ? int.Parse(items[9]) : 0;
                    // Generate rest
                    stocks.Add(stockData);
                    // 把股票資料加到陣列
                    StockDatas.Add(stockData);
                }
                dataGridViewStockData.DataSource = stocks;
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("股票資訊");
                // 把標頭寫到A1 ~ E1儲存格
                //證券代號,證券名稱,成交股數,成交金額,開盤價,最高價,最低價,收盤價,漲跌價差,成交筆數
                worksheet.Cell("A1").Value = "證券代號";
                worksheet.Cell("B1").Value = "證券名稱";
                worksheet.Cell("C1").Value = "成交股數";
                worksheet.Cell("D1").Value = "成交金額";
                worksheet.Cell("E1").Value = "開盤價";
                worksheet.Cell("F1").Value = "最高價";
                worksheet.Cell("G1").Value = "最低價";
                worksheet.Cell("H1").Value = "收盤價";
                worksheet.Cell("I1").Value = "漲跌價差";
                worksheet.Cell("J1").Value = "成交筆數";

                // 針對股票物件陣列去跑迴圈
                for (int i = 0; i < StockDatas.Count; i++)
                {
                    // 目前迴圈當前的股票物件 (第i個資料列)
                    var stock = StockDatas[i];
                    // 把每筆資料塞到目前Excel中的資料列 Cell(水平列位置、垂直欄位位置) 記得Excel起始值是從1開始不是0。
                    worksheet.Cell(i + 2, 1).Value = stock.ID;
                    worksheet.Cell(i + 2, 2).Value = stock.StockName;
                    worksheet.Cell(i + 2, 3).Value = stock.StockTraded;
                    worksheet.Cell(i + 2, 4).Value = stock.StockAmount;
                    worksheet.Cell(i + 2, 5).Value = stock.StartAmount;
                    worksheet.Cell(i + 2, 6).Value = stock.HighestAmount;
                    worksheet.Cell(i + 2, 7).Value = stock.LowestAmount;
                    worksheet.Cell(i + 2, 8).Value = stock.FinalTradedAmount;
                    worksheet.Cell(i + 2, 9).Value = stock.AmountChanged;
                    worksheet.Cell(i + 2, 10).Value = stock.TradeCount;
                    // HighestAmount根據漲跌條件顯示綠色或紅色
                    if (stock.HighestAmount > stock.StartAmount)
                    {
                        worksheet.Cell(i + 2, 6).Style.Font.FontColor = XLColor.Red;
                    }
                    else
                    {
                        worksheet.Cell(i + 2, 6).Style.Font.FontColor = XLColor.Black;
                    }
                    // LowestAmount根據漲跌條件顯示綠色或紅色
                    if (stock.LowestAmount < stock.StartAmount)
                    {
                        worksheet.Cell(i + 2, 7).Style.Font.FontColor = XLColor.Green;
                    }
                    else
                    {
                        worksheet.Cell(i + 2, 7).Style.Font.FontColor = XLColor.Black;
                    }
                    // FinalTradedAmount根據漲跌條件顯示綠色或紅色
                    if (stock.FinalTradedAmount < stock.StartAmount)
                    {
                        worksheet.Cell(i + 2, 8).Style.Font.FontColor = XLColor.Green;
                    }
                    else if (stock.HighestAmount > stock.StartAmount)
                    {
                        worksheet.Cell(i + 2, 8).Style.Font.FontColor = XLColor.Red;
                    }
                    else 
                    {
                        worksheet.Cell(i + 2, 8).Style.Font.FontColor = XLColor.Black;
                    }

                    // 根據漲跌條件顯示綠色或紅色
                    if (stock.AmountChanged > 0)
                    {
                        // set to green
                        worksheet.Cell(i + 2, 9).Style.Font.FontColor = XLColor.Red;
                    }
                    else
                    {
                        worksheet.Cell(i + 2, 9).Style.Font.FontColor = XLColor.Green;
                    }
                }
                // 把Excel存起來
                workbook.SaveAs("StockData.xlsx");
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "StockData.xlsx",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}
