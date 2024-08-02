using Dapper;
using System.Data.SqlClient;

namespace RandyWinFormsApp1
{

    public partial class Form1 : Form
    {
        private int[] ans = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//���T����
        private String[] gnum = new string[10];//�q�����׼Ʀr
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
                MessageBox.Show("�п�J4�Ӥ��@�˪��Ʀr");
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
                    MessageBox.Show("�����J���ƪ��Ʀr�@");
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
                    //label3.Text = "��" + (listBoxResult.Lines.Length - 1) + "�q";
                    textBoxInput.Focus();
                    textBoxInput.SelectAll();
                }
                if (a == 4 && b == 0)
                {
                    MessageBox.Show("���ߧA�q��F");
                    textBoxInput.Enabled = false;
                }
                else if (textBoxResult.Lines.Length == 11)
                {
                    MessageBox.Show("�A�n�A�[�o�F");
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
            //���լO�_�i�H�s�u���Ʈw
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"
                        Server=localhost;
                        Database=master;
                        user Id=SYSADM;
                        Password=SYSADM";
            itemsService.ConnString = conn.ConnectionString;
            //itemsService.ConnString = conn.ConnectionString;

            conn.Open();
            MessageBox.Show("�s�u���\");
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
            // set so whole row is selected �����Q���
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // can only select one row at a time ���i�H�h��
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
            // ����u��Ƨ�X��
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
                MessageBox.Show("�п�ܤ@�󪫫~");
                return;
            }
            FormUpdate formUpdate = new FormUpdate(employee);
            formUpdate.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // �ˬd���S����@���ƦC
            if (isSelected == false)
            {
                MessageBox.Show("�п�ܤ@�����~");
                return;
            }
            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            // ���T���T�w�O�_�n�R��
            var result = MessageBox.Show("�T�w�n�R�� �s��" + id + " " + Name + "��?", "�R�����~", MessageBoxButtons.YesNo);
            // �p�G��NO�N����
            if (result == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(itemsService.ConnString);
            conn.Execute("Delete From items Where id = @id", new { id });
            MessageBox.Show("�R�����\");
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
