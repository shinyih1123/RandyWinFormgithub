namespace RandyWinFormsApp1
{
    partial class FormMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMailto = new TextBox();
            textBoxSubject = new TextBox();
            richTextBox1 = new RichTextBox();
            buttonFilePath = new Button();
            buttonSend = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "收件者";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F);
            label2.Location = new Point(39, 61);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "標題";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F);
            label3.Location = new Point(39, 100);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 4;
            label3.Text = "內容";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F);
            label4.Location = new Point(39, 243);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 6;
            label4.Text = "附件";
            // 
            // textBoxMailto
            // 
            textBoxMailto.Location = new Point(125, 29);
            textBoxMailto.Name = "textBoxMailto";
            textBoxMailto.Size = new Size(514, 27);
            textBoxMailto.TabIndex = 1;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(125, 63);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(514, 27);
            textBoxSubject.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(125, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(510, 120);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "Mail內文";
            // 
            // buttonFilePath
            // 
            buttonFilePath.Location = new Point(125, 243);
            buttonFilePath.Name = "buttonFilePath";
            buttonFilePath.Size = new Size(94, 29);
            buttonFilePath.TabIndex = 7;
            buttonFilePath.Text = "瀏覽…";
            buttonFilePath.UseVisualStyleBackColor = true;
            buttonFilePath.Click += buttonFilePath_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonSend.Location = new Point(516, 290);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(119, 29);
            buttonSend.TabIndex = 9;
            buttonSend.Text = "送出郵件";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F);
            label5.Location = new Point(284, 243);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 8;
            label5.Text = "附件名稱：";
            // 
            // FormMail
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(label5);
            Controls.Add(buttonSend);
            Controls.Add(buttonFilePath);
            Controls.Add(richTextBox1);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxMailto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMail";
            Text = "FormMail_寄件範例";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMailto;
        private TextBox textBoxSubject;
        private RichTextBox richTextBox1;
        private Button buttonFilePath;
        private Button buttonSend;
        private Label label5;
    }
}