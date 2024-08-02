namespace RandyWinFormsApp1
{
    partial class FormUpdate
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
            labelUpdateId = new Label();
            textBoxUpdateId = new TextBox();
            textBoxUpdateName = new TextBox();
            labelUpdateName = new Label();
            textBoxUpdateDesc = new TextBox();
            labelUpdateDesc = new Label();
            textBoxUpdateMkValue = new TextBox();
            labelUpdateMkValue = new Label();
            textBoxUpdateQuantity = new TextBox();
            labelUpdateQuantity = new Label();
            textBoxUpdateType = new TextBox();
            labelUpdateType = new Label();
            buttonUpdateSave = new Button();
            buttonUpdateClose = new Button();
            SuspendLayout();
            // 
            // labelUpdateId
            // 
            labelUpdateId.AutoSize = true;
            labelUpdateId.Location = new Point(23, 15);
            labelUpdateId.Name = "labelUpdateId";
            labelUpdateId.Size = new Size(39, 19);
            labelUpdateId.TabIndex = 0;
            labelUpdateId.Text = "編號";
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Enabled = false;
            textBoxUpdateId.Location = new Point(68, 12);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(208, 27);
            textBoxUpdateId.TabIndex = 1;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(68, 55);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(208, 27);
            textBoxUpdateName.TabIndex = 3;
            // 
            // labelUpdateName
            // 
            labelUpdateName.AutoSize = true;
            labelUpdateName.Location = new Point(23, 58);
            labelUpdateName.Name = "labelUpdateName";
            labelUpdateName.Size = new Size(39, 19);
            labelUpdateName.TabIndex = 2;
            labelUpdateName.Text = "名稱";
            // 
            // textBoxUpdateDesc
            // 
            textBoxUpdateDesc.Location = new Point(68, 100);
            textBoxUpdateDesc.Name = "textBoxUpdateDesc";
            textBoxUpdateDesc.Size = new Size(208, 27);
            textBoxUpdateDesc.TabIndex = 5;
            // 
            // labelUpdateDesc
            // 
            labelUpdateDesc.AutoSize = true;
            labelUpdateDesc.Location = new Point(23, 103);
            labelUpdateDesc.Name = "labelUpdateDesc";
            labelUpdateDesc.Size = new Size(39, 19);
            labelUpdateDesc.TabIndex = 4;
            labelUpdateDesc.Text = "描述";
            // 
            // textBoxUpdateMkValue
            // 
            textBoxUpdateMkValue.Location = new Point(68, 145);
            textBoxUpdateMkValue.Name = "textBoxUpdateMkValue";
            textBoxUpdateMkValue.Size = new Size(208, 27);
            textBoxUpdateMkValue.TabIndex = 7;
            // 
            // labelUpdateMkValue
            // 
            labelUpdateMkValue.AutoSize = true;
            labelUpdateMkValue.Location = new Point(23, 148);
            labelUpdateMkValue.Name = "labelUpdateMkValue";
            labelUpdateMkValue.Size = new Size(39, 19);
            labelUpdateMkValue.TabIndex = 6;
            labelUpdateMkValue.Text = "價值";
            // 
            // textBoxUpdateQuantity
            // 
            textBoxUpdateQuantity.Location = new Point(68, 188);
            textBoxUpdateQuantity.Name = "textBoxUpdateQuantity";
            textBoxUpdateQuantity.Size = new Size(208, 27);
            textBoxUpdateQuantity.TabIndex = 9;
            // 
            // labelUpdateQuantity
            // 
            labelUpdateQuantity.AutoSize = true;
            labelUpdateQuantity.Location = new Point(23, 191);
            labelUpdateQuantity.Name = "labelUpdateQuantity";
            labelUpdateQuantity.Size = new Size(39, 19);
            labelUpdateQuantity.TabIndex = 8;
            labelUpdateQuantity.Text = "數量";
            // 
            // textBoxUpdateType
            // 
            textBoxUpdateType.Location = new Point(68, 232);
            textBoxUpdateType.Name = "textBoxUpdateType";
            textBoxUpdateType.Size = new Size(208, 27);
            textBoxUpdateType.TabIndex = 11;
            // 
            // labelUpdateType
            // 
            labelUpdateType.AutoSize = true;
            labelUpdateType.Location = new Point(23, 235);
            labelUpdateType.Name = "labelUpdateType";
            labelUpdateType.Size = new Size(39, 19);
            labelUpdateType.TabIndex = 10;
            labelUpdateType.Text = "種類";
            // 
            // buttonUpdateSave
            // 
            buttonUpdateSave.Location = new Point(68, 275);
            buttonUpdateSave.Name = "buttonUpdateSave";
            buttonUpdateSave.Size = new Size(94, 29);
            buttonUpdateSave.TabIndex = 12;
            buttonUpdateSave.Text = "存檔";
            buttonUpdateSave.UseVisualStyleBackColor = true;
            buttonUpdateSave.Click += buttonUpdateSave_Click;
            // 
            // buttonUpdateClose
            // 
            buttonUpdateClose.Location = new Point(182, 275);
            buttonUpdateClose.Name = "buttonUpdateClose";
            buttonUpdateClose.Size = new Size(94, 29);
            buttonUpdateClose.TabIndex = 13;
            buttonUpdateClose.Text = "取消";
            buttonUpdateClose.UseVisualStyleBackColor = true;
            buttonUpdateClose.Click += buttonUpdateClose_Click;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdateClose);
            Controls.Add(buttonUpdateSave);
            Controls.Add(textBoxUpdateType);
            Controls.Add(labelUpdateType);
            Controls.Add(textBoxUpdateQuantity);
            Controls.Add(labelUpdateQuantity);
            Controls.Add(textBoxUpdateMkValue);
            Controls.Add(labelUpdateMkValue);
            Controls.Add(textBoxUpdateDesc);
            Controls.Add(labelUpdateDesc);
            Controls.Add(textBoxUpdateName);
            Controls.Add(labelUpdateName);
            Controls.Add(textBoxUpdateId);
            Controls.Add(labelUpdateId);
            Name = "FormUpdate";
            Text = "勇者物品修改";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUpdateId;
        private TextBox textBoxUpdateId;
        private TextBox textBoxUpdateName;
        private Label labelUpdateName;
        private TextBox textBoxUpdateDesc;
        private Label labelUpdateDesc;
        private TextBox textBoxUpdateMkValue;
        private Label labelUpdateMkValue;
        private TextBox textBoxUpdateQuantity;
        private Label labelUpdateQuantity;
        private TextBox textBoxUpdateType;
        private Label labelUpdateType;
        private Button buttonUpdateSave;
        private Button buttonUpdateClose;
    }
}