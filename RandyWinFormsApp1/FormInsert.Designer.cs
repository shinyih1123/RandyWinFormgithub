namespace RandyWinFormsApp1
{
    partial class FormInsert
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
            buttonInsertClose = new Button();
            buttonInsertSave = new Button();
            textBoxInsertType = new TextBox();
            labelInsertType = new Label();
            textBoxInsertQuantity = new TextBox();
            labelInsertQuantity = new Label();
            textBoxInsertMkValue = new TextBox();
            labelInsertMkValue = new Label();
            textBoxInsertDesc = new TextBox();
            labelInsertDesc = new Label();
            textBoxInsertName = new TextBox();
            labelInsertName = new Label();
            textBoxInsertId = new TextBox();
            labelInsertId = new Label();
            SuspendLayout();
            // 
            // buttonInsertClose
            // 
            buttonInsertClose.Location = new Point(183, 275);
            buttonInsertClose.Name = "buttonInsertClose";
            buttonInsertClose.Size = new Size(94, 29);
            buttonInsertClose.TabIndex = 27;
            buttonInsertClose.Text = "取消";
            buttonInsertClose.UseVisualStyleBackColor = true;
            buttonInsertClose.Click += buttonUpdateClose_Click;
            // 
            // buttonInsertSave
            // 
            buttonInsertSave.Location = new Point(69, 275);
            buttonInsertSave.Name = "buttonInsertSave";
            buttonInsertSave.Size = new Size(94, 29);
            buttonInsertSave.TabIndex = 26;
            buttonInsertSave.Text = "存檔";
            buttonInsertSave.UseVisualStyleBackColor = true;
            buttonInsertSave.Click += buttonUpdateSave_Click;
            // 
            // textBoxInsertType
            // 
            textBoxInsertType.Location = new Point(69, 232);
            textBoxInsertType.Name = "textBoxInsertType";
            textBoxInsertType.Size = new Size(208, 27);
            textBoxInsertType.TabIndex = 25;
            // 
            // labelInsertType
            // 
            labelInsertType.AutoSize = true;
            labelInsertType.Location = new Point(24, 235);
            labelInsertType.Name = "labelInsertType";
            labelInsertType.Size = new Size(39, 19);
            labelInsertType.TabIndex = 24;
            labelInsertType.Text = "種類";
            // 
            // textBoxInsertQuantity
            // 
            textBoxInsertQuantity.Location = new Point(69, 188);
            textBoxInsertQuantity.Name = "textBoxInsertQuantity";
            textBoxInsertQuantity.Size = new Size(208, 27);
            textBoxInsertQuantity.TabIndex = 23;
            // 
            // labelInsertQuantity
            // 
            labelInsertQuantity.AutoSize = true;
            labelInsertQuantity.Location = new Point(24, 191);
            labelInsertQuantity.Name = "labelInsertQuantity";
            labelInsertQuantity.Size = new Size(39, 19);
            labelInsertQuantity.TabIndex = 22;
            labelInsertQuantity.Text = "數量";
            // 
            // textBoxInsertMkValue
            // 
            textBoxInsertMkValue.Location = new Point(69, 145);
            textBoxInsertMkValue.Name = "textBoxInsertMkValue";
            textBoxInsertMkValue.Size = new Size(208, 27);
            textBoxInsertMkValue.TabIndex = 21;
            // 
            // labelInsertMkValue
            // 
            labelInsertMkValue.AutoSize = true;
            labelInsertMkValue.Location = new Point(24, 148);
            labelInsertMkValue.Name = "labelInsertMkValue";
            labelInsertMkValue.Size = new Size(39, 19);
            labelInsertMkValue.TabIndex = 20;
            labelInsertMkValue.Text = "價值";
            // 
            // textBoxInsertDesc
            // 
            textBoxInsertDesc.Location = new Point(69, 100);
            textBoxInsertDesc.Name = "textBoxInsertDesc";
            textBoxInsertDesc.Size = new Size(208, 27);
            textBoxInsertDesc.TabIndex = 19;
            // 
            // labelInsertDesc
            // 
            labelInsertDesc.AutoSize = true;
            labelInsertDesc.Location = new Point(24, 103);
            labelInsertDesc.Name = "labelInsertDesc";
            labelInsertDesc.Size = new Size(39, 19);
            labelInsertDesc.TabIndex = 18;
            labelInsertDesc.Text = "描述";
            // 
            // textBoxInsertName
            // 
            textBoxInsertName.Location = new Point(69, 55);
            textBoxInsertName.Name = "textBoxInsertName";
            textBoxInsertName.Size = new Size(208, 27);
            textBoxInsertName.TabIndex = 17;
            // 
            // labelInsertName
            // 
            labelInsertName.AutoSize = true;
            labelInsertName.Location = new Point(24, 58);
            labelInsertName.Name = "labelInsertName";
            labelInsertName.Size = new Size(39, 19);
            labelInsertName.TabIndex = 16;
            labelInsertName.Text = "名稱";
            // 
            // textBoxInsertId
            // 
            textBoxInsertId.Enabled = false;
            textBoxInsertId.Location = new Point(69, 12);
            textBoxInsertId.Name = "textBoxInsertId";
            textBoxInsertId.Size = new Size(208, 27);
            textBoxInsertId.TabIndex = 15;
            // 
            // labelInsertId
            // 
            labelInsertId.AutoSize = true;
            labelInsertId.Location = new Point(24, 15);
            labelInsertId.Name = "labelInsertId";
            labelInsertId.Size = new Size(39, 19);
            labelInsertId.TabIndex = 14;
            labelInsertId.Text = "編號";
            // 
            // FormInsert
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInsertClose);
            Controls.Add(buttonInsertSave);
            Controls.Add(textBoxInsertType);
            Controls.Add(labelInsertType);
            Controls.Add(textBoxInsertQuantity);
            Controls.Add(labelInsertQuantity);
            Controls.Add(textBoxInsertMkValue);
            Controls.Add(labelInsertMkValue);
            Controls.Add(textBoxInsertDesc);
            Controls.Add(labelInsertDesc);
            Controls.Add(textBoxInsertName);
            Controls.Add(labelInsertName);
            Controls.Add(textBoxInsertId);
            Controls.Add(labelInsertId);
            Name = "FormInsert";
            Text = "勇者物品新增";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInsertClose;
        private Button buttonInsertSave;
        private TextBox textBoxInsertType;
        private Label labelInsertType;
        private TextBox textBoxInsertQuantity;
        private Label labelInsertQuantity;
        private TextBox textBoxInsertMkValue;
        private Label labelInsertMkValue;
        private TextBox textBoxInsertDesc;
        private Label labelInsertDesc;
        private TextBox textBoxInsertName;
        private Label labelInsertName;
        private TextBox textBoxInsertId;
        private Label labelInsertId;
    }
}