namespace RandyWinFormsApp1
{
    partial class FormMethods
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
            buttonInScope = new Button();
            buttonInClass = new Button();
            button3 = new Button();
            buttonThreeParams = new Button();
            buttonOptionalParams = new Button();
            buttonNamedParams = new Button();
            buttonDateTimeExtension = new Button();
            buttonCreteTree = new Button();
            treeViewFolders = new TreeView();
            label5 = new Label();
            buttonQ1 = new Button();
            buttonQ2 = new Button();
            label6 = new Label();
            buttonQ3 = new Button();
            label7 = new Label();
            buttonQ4 = new Button();
            label8 = new Label();
            label9 = new Label();
            buttonQ5 = new Button();
            textBoxQ1 = new TextBox();
            textBoxQ2 = new TextBox();
            textBoxQ3 = new TextBox();
            textBoxQ4 = new TextBox();
            textBoxQ5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 56);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "方法定義位置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 114);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 1;
            label2.Text = "參數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 168);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 2;
            label3.Text = "擴充方法";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 238);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 3;
            label4.Text = "遞迴方法";
            // 
            // buttonInScope
            // 
            buttonInScope.Location = new Point(203, 34);
            buttonInScope.Name = "buttonInScope";
            buttonInScope.Size = new Size(94, 29);
            buttonInScope.TabIndex = 4;
            buttonInScope.Text = "在範圍內";
            buttonInScope.UseVisualStyleBackColor = true;
            buttonInScope.Click += buttonInScope_Click;
            // 
            // buttonInClass
            // 
            buttonInClass.Location = new Point(372, 34);
            buttonInClass.Name = "buttonInClass";
            buttonInClass.Size = new Size(94, 29);
            buttonInClass.TabIndex = 5;
            buttonInClass.Text = "在目前類別中";
            buttonInClass.UseVisualStyleBackColor = true;
            buttonInClass.Click += buttonInClass_Click;
            // 
            // button3
            // 
            button3.Location = new Point(556, 34);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "在新類別中";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonThreeParams
            // 
            buttonThreeParams.Location = new Point(203, 104);
            buttonThreeParams.Name = "buttonThreeParams";
            buttonThreeParams.Size = new Size(94, 29);
            buttonThreeParams.TabIndex = 7;
            buttonThreeParams.Text = "三個參數";
            buttonThreeParams.UseVisualStyleBackColor = true;
            buttonThreeParams.Click += buttonThreeParams_Click;
            // 
            // buttonOptionalParams
            // 
            buttonOptionalParams.Location = new Point(372, 104);
            buttonOptionalParams.Name = "buttonOptionalParams";
            buttonOptionalParams.Size = new Size(94, 29);
            buttonOptionalParams.TabIndex = 8;
            buttonOptionalParams.Text = "選擇性參數";
            buttonOptionalParams.UseVisualStyleBackColor = true;
            buttonOptionalParams.Click += buttonOptionalParams_Click;
            // 
            // buttonNamedParams
            // 
            buttonNamedParams.Location = new Point(556, 104);
            buttonNamedParams.Name = "buttonNamedParams";
            buttonNamedParams.Size = new Size(94, 29);
            buttonNamedParams.TabIndex = 9;
            buttonNamedParams.Text = "具名參數";
            buttonNamedParams.UseVisualStyleBackColor = true;
            buttonNamedParams.Click += buttonNamedParams_Click;
            // 
            // buttonDateTimeExtension
            // 
            buttonDateTimeExtension.Location = new Point(203, 168);
            buttonDateTimeExtension.Name = "buttonDateTimeExtension";
            buttonDateTimeExtension.Size = new Size(94, 29);
            buttonDateTimeExtension.TabIndex = 10;
            buttonDateTimeExtension.Text = "時間擴充";
            buttonDateTimeExtension.UseVisualStyleBackColor = true;
            buttonDateTimeExtension.Click += buttonDateTimeExtension_Click;
            // 
            // buttonCreteTree
            // 
            buttonCreteTree.Location = new Point(55, 278);
            buttonCreteTree.Name = "buttonCreteTree";
            buttonCreteTree.Size = new Size(94, 29);
            buttonCreteTree.TabIndex = 11;
            buttonCreteTree.Text = "產出資料夾結構";
            buttonCreteTree.UseVisualStyleBackColor = true;
            buttonCreteTree.Click += buttonCreteTree_Click;
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(203, 278);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(585, 160);
            treeViewFolders.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 452);
            label5.Name = "label5";
            label5.Size = new Size(260, 19);
            label5.TabIndex = 13;
            label5.Text = "1.購物車訊息 (具名參數與選擇性參數)";
            // 
            // buttonQ1
            // 
            buttonQ1.Location = new Point(321, 474);
            buttonQ1.Name = "buttonQ1";
            buttonQ1.Size = new Size(94, 29);
            buttonQ1.TabIndex = 15;
            buttonQ1.Text = "確認";
            buttonQ1.UseVisualStyleBackColor = true;
            buttonQ1.Click += buttonQ1_Click;
            // 
            // buttonQ2
            // 
            buttonQ2.Location = new Point(321, 538);
            buttonQ2.Name = "buttonQ2";
            buttonQ2.Size = new Size(94, 29);
            buttonQ2.TabIndex = 18;
            buttonQ2.Text = "確認";
            buttonQ2.UseVisualStyleBackColor = true;
            buttonQ2.Click += buttonQ2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 516);
            label6.Name = "label6";
            label6.Size = new Size(275, 19);
            label6.TabIndex = 16;
            label6.Text = "2.日曆事件文字 (具名參數與選擇性參數)";
            // 
            // buttonQ3
            // 
            buttonQ3.Location = new Point(321, 600);
            buttonQ3.Name = "buttonQ3";
            buttonQ3.Size = new Size(94, 29);
            buttonQ3.TabIndex = 21;
            buttonQ3.Text = "確認";
            buttonQ3.UseVisualStyleBackColor = true;
            buttonQ3.Click += buttonQ3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 578);
            label7.Name = "label7";
            label7.Size = new Size(376, 19);
            label7.TabIndex = 19;
            label7.Text = "3.用戶帳號擴充方法(判斷該字串是否符合電子郵件格式)";
            // 
            // buttonQ4
            // 
            buttonQ4.Location = new Point(321, 662);
            buttonQ4.Name = "buttonQ4";
            buttonQ4.Size = new Size(94, 29);
            buttonQ4.TabIndex = 24;
            buttonQ4.Text = "確認";
            buttonQ4.UseVisualStyleBackColor = true;
            buttonQ4.Click += buttonQ4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 640);
            label8.Name = "label8";
            label8.Size = new Size(131, 19);
            label8.TabIndex = 22;
            label8.Text = "4.名稱清理 (LINQ)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 710);
            label9.Name = "label9";
            label9.Size = new Size(140, 19);
            label9.TabIndex = 25;
            label9.Text = "5.資料夾結構 (遞迴)";
            // 
            // buttonQ5
            // 
            buttonQ5.Location = new Point(321, 730);
            buttonQ5.Name = "buttonQ5";
            buttonQ5.Size = new Size(94, 29);
            buttonQ5.TabIndex = 26;
            buttonQ5.Text = "產出資料夾";
            buttonQ5.UseVisualStyleBackColor = true;
            buttonQ5.Click += buttonQ5_Click;
            // 
            // textBoxQ1
            // 
            textBoxQ1.Location = new Point(70, 474);
            textBoxQ1.Name = "textBoxQ1";
            textBoxQ1.Size = new Size(245, 27);
            textBoxQ1.TabIndex = 27;
            // 
            // textBoxQ2
            // 
            textBoxQ2.Location = new Point(70, 538);
            textBoxQ2.Name = "textBoxQ2";
            textBoxQ2.Size = new Size(245, 27);
            textBoxQ2.TabIndex = 28;
            // 
            // textBoxQ3
            // 
            textBoxQ3.Location = new Point(70, 600);
            textBoxQ3.Name = "textBoxQ3";
            textBoxQ3.Size = new Size(245, 27);
            textBoxQ3.TabIndex = 29;
            // 
            // textBoxQ4
            // 
            textBoxQ4.Location = new Point(70, 664);
            textBoxQ4.Name = "textBoxQ4";
            textBoxQ4.Size = new Size(245, 27);
            textBoxQ4.TabIndex = 30;
            // 
            // textBoxQ5
            // 
            textBoxQ5.Location = new Point(70, 730);
            textBoxQ5.Name = "textBoxQ5";
            textBoxQ5.Size = new Size(245, 27);
            textBoxQ5.TabIndex = 31;
            textBoxQ5.Text = "E:\\Smartman\\";
            // 
            // FormMethods
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 771);
            Controls.Add(textBoxQ5);
            Controls.Add(textBoxQ4);
            Controls.Add(textBoxQ3);
            Controls.Add(textBoxQ2);
            Controls.Add(textBoxQ1);
            Controls.Add(buttonQ5);
            Controls.Add(label9);
            Controls.Add(buttonQ4);
            Controls.Add(label8);
            Controls.Add(buttonQ3);
            Controls.Add(label7);
            Controls.Add(buttonQ2);
            Controls.Add(label6);
            Controls.Add(buttonQ1);
            Controls.Add(label5);
            Controls.Add(treeViewFolders);
            Controls.Add(buttonCreteTree);
            Controls.Add(buttonDateTimeExtension);
            Controls.Add(buttonNamedParams);
            Controls.Add(buttonOptionalParams);
            Controls.Add(buttonThreeParams);
            Controls.Add(button3);
            Controls.Add(buttonInClass);
            Controls.Add(buttonInScope);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMethods";
            Text = "FormMethods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonInScope;
        private Button buttonInClass;
        private Button button3;
        private Button buttonThreeParams;
        private Button buttonOptionalParams;
        private Button buttonNamedParams;
        private Button buttonDateTimeExtension;
        private Button buttonCreteTree;
        private TreeView treeViewFolders;
        private Label label5;
        private Button buttonQ1;
        private Button buttonQ2;
        private Label label6;
        private Button buttonQ3;
        private Label label7;
        private Button buttonQ4;
        private Label label8;
        private Label label9;
        private Button buttonQ5;
        private TextBox textBoxQ1;
        private TextBox textBoxQ2;
        private TextBox textBoxQ3;
        private TextBox textBoxQ4;
        private TextBox textBoxQ5;
    }
}