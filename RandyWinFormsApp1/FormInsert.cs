using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandyWinFormsApp1
{
    public partial class FormInsert : Form
    {
        // Employee 容器
        Employee employee;
        // 建構子 constructor
        public FormInsert(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            // 設置 KeyPress 事件處理程序
            textBoxInsertMkValue.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBoxInsertQuantity.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBoxInsertMkValue.Text = "0";
            textBoxInsertQuantity.Text = "0";
        }

        private void buttonUpdateClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 檢查輸入字符是否是數字或控制字符（如退格鍵）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 阻止非數字字符的輸入
            }
        }
        private void buttonUpdateSave_Click(object sender, EventArgs e)
        {
            // 系統日期轉string 
            string LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string Name = textBoxInsertName.Text.Length <= 100 ? textBoxInsertName.Text : textBoxInsertName.Text.Substring(0, 100);
            if (Name == "")
            {
                MessageBox.Show("物品名稱不可為空");
                return;
            }
            //get textBoxMarketValue.Text 轉成 int  
            int MarketValueInt = int.Parse(textBoxInsertMkValue.Text);
            if (MarketValueInt > 10000)
            {
                MessageBox.Show("價值不可超過10000");
                return;
            }
            string Description = textBoxInsertDesc.Text.Length <= 1000 ? textBoxInsertDesc.Text : textBoxInsertDesc.Text.Substring(0, 1000);
            string MarketValue = textBoxInsertMkValue.Text;
            string Quantity = textBoxInsertQuantity.Text;
            string Type = textBoxInsertType.Text;
            string ID = textBoxInsertId.Text;
            // 存檔
            SqlConnection conn = new SqlConnection(itemsService.ConnString);
            conn.Open();
            conn.Execute(@"Insert into Items(Name,Description,MarketValue,Quantity,Type,LastUpdated)
                               Values(@Name,@Description,@MarketValue,@Quantity,@Type,@LastUpdated)",
                new { Name, Description, MarketValue, Quantity, Type, ID, LastUpdated }
                );
            conn.Close();
            MessageBox.Show("存檔成功");
            Close();
        }
    }
}
