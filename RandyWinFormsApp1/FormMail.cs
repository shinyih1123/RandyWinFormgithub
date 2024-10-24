using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;


namespace RandyWinFormsApp1
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Randy", "randy.tsai@smartman.com.tw")); //寄件者
                //message.To.Add(new MailboxAddress("Randy", "randy.tsai@smartman.com.tw")); //收件者
                message.To.Add(new MailboxAddress(textBoxMailto.Text, textBoxMailto.Text)); //收件者
                message.Subject = textBoxSubject.Text;

                BodyBuilder bodyBuilder = new BodyBuilder(); //使用 bodybuilder來建立內文
                //bodyBuilder.TextBody = "Hi,Randy";  //設定內文
                bodyBuilder.TextBody = richTextBox1.Text;  //設定內文

                if (label5.Text != "附件名稱：")
                { 
                    bodyBuilder.Attachments.Add(label5.Text); //加入附件
                }
                message.Body = bodyBuilder.ToMessageBody();  //將bodybuilder轉成body

                //使用smtpClient 來設定伺服器資訊
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.hibox.biz", 587, false);

                    string password = File.ReadAllText("mypassword.txt");


                    client.Authenticate("randy.tsai@smartman.com.tw", password);

                    client.Send(message);
                    client.Disconnect(true);
                    MessageBox.Show("寄送完成");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤" + ex.Message);
                File.AppendAllText("error.txt", "發生錯誤" + ex.Message);
            }
            finally
            {
                MessageBox.Show("程式結束");
                //File.AppendAllText("log.txt", "程式結束" + ex.Message + "\n");
            }

        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool isOk = openFileDialog.ShowDialog() == DialogResult.OK;
            if (isOk == false)
            {
                return;  //Early Return提前結束
            }
            //取得檔案名稱(全路徑)並SHOW到畫面上
            string fileName=openFileDialog.FileName;
            label5.Text = fileName;

        }
    }
}
