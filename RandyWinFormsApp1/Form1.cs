namespace RandyWinFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] ans = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//���T����
        private String[] gnum = new string[10];//�q�����׼Ʀr
        private int tmp, r ,time;
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
                    textBoxResult.Text += time +"---------"+num + "----------" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
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
            textBoxResult.Text += "Ans===" + ans[1] + ans[2] + ans[3] + ans[4] + "===="+"\r\n";
            textBoxInput.Enabled = false;
            buttonGuess.Enabled = false;
            buttonGiveUp.Enabled = false;
            //for (int i = 1; i <= 4; i++)
            //{
            //    textBoxResult.Text += ans[i];
            //}
        }
    }
}
