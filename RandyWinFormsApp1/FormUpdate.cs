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
    public partial class FormUpdate : Form
    {
        // Employee 容器
        Employee employee;
        // 建構子 constructor
        public FormUpdate(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            // 初始化物品
            this.textBoxUpdateId.Text = employee.Id.ToString();
            this.textBoxUpdateName.Text = employee.Name;
            this.textBoxUpdateDesc.Text = employee.Description;
            this.textBoxUpdateMkValue.Text = employee.MarketValue.ToString();
            this.textBoxUpdateQuantity.Text = employee.Quantity.ToString();
            this.textBoxUpdateType.Text = employee.Type.ToString();
        }

        private void buttonUpdateSave_Click(object sender, EventArgs e)
        {
            // 存檔
            SqlConnection conn = new SqlConnection(itemsService.ConnString);
            conn.Open();
            string updateId = textBoxUpdateId.Text; // Id
            string updatedName = textBoxUpdateName.Text; // Name
            string updateDesc = textBoxUpdateDesc.Text; // Desc
            string updateMkValue = textBoxUpdateMkValue.Text; //MarketValue
            string updateQuantity = textBoxUpdateQuantity.Text; //Quantity
            string updateType = textBoxUpdateType.Text;//Type
            conn.Execute(@"Update Items Set Name = @updatedName , Description = @updateDesc Where Id = @updateId",
                new { updatedName, updateDesc, updateId }
                );
            conn.Close();
            MessageBox.Show("存檔成功");
            Close();
        }

        private void buttonUpdateClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
