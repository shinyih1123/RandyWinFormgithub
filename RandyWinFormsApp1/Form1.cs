using Dapper;
using System.Data.SqlClient;

namespace RandyWinFormsApp1
{

    public partial class Form1 : Form
    {
        private int[] ans = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//正確答案
        private String[] gnum = new string[10];//猜的答案數字
        private int tmp, r, time;
        private Random ran = new Random();
        public Form1()
        {
            InitializeComponent();

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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"
                        Server=localhost;
                        Database=master;
                        user Id=SYSADM;
                        Password=SYSADM";
            itemsService.ConnString = conn.ConnectionString;
            //itemsService.ConnString = conn.ConnectionString;

            conn.Open();
            MessageBox.Show("連線成功");
            conn.Close();
            //
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = itemsService.ConnString;
            itemsService.ConnString = conn.ConnectionString;
            conn.Open();
            List<Employee> employees = new List<Employee>();
            employees = conn.Query<Employee>("Select * From items").ToList();
            conn.Close();
            dataGridView1.DataSource = employees;
            // set so whole row is selected 讓整行被選取
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // can only select one row at a time 不可以多選
            dataGridView1.MultiSelect = false;
            // read only
            dataGridView1.ReadOnly = true;
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
            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            // 跳訊息確定是否要刪除
            var result = MessageBox.Show("確定要刪除 編號" + id + " " + Name + "嗎?", "刪除物品", MessageBoxButtons.YesNo);
            // 如果選NO就結束
            if (result == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(itemsService.ConnString);
            conn.Execute("Delete From items Where id = @id", new { id });
            MessageBox.Show("刪除成功");
            conn.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            FormInsert formInsert = new FormInsert(employee);
            formInsert.ShowDialog();
        }
    }
}
