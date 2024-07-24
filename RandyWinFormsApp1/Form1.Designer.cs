using Microsoft.VisualBasic;

namespace RandyWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNew = new Button();
            buttonQuit = new Button();
            label = new Label();
            textBoxInput = new TextBox();
            buttonGuess = new Button();
            labelNo = new Label();
            labelGuess = new Label();
            labelResult = new Label();
            label1 = new Label();
            buttonGiveUp = new Button();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(12, 12);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(99, 45);
            buttonNew.TabIndex = 0;
            buttonNew.Text = "New Game";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(186, 12);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(99, 46);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(13, 97);
            label.Name = "label";
            label.Size = new Size(39, 19);
            label.TabIndex = 2;
            label.Text = "輸入";
            // 
            // textBoxInput
            // 
            textBoxInput.Enabled = false;
            textBoxInput.Location = new Point(58, 94);
            textBoxInput.MaxLength = 4;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(111, 27);
            textBoxInput.TabIndex = 3;
            // 
            // buttonGuess
            // 
            buttonGuess.Location = new Point(175, 92);
            buttonGuess.Enabled = false;
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(54, 29);
            buttonGuess.TabIndex = 4;
            buttonGuess.Text = "OK";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // labelNo
            // 
            labelNo.AutoSize = true;
            labelNo.Location = new Point(13, 131);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(33, 19);
            labelNo.TabIndex = 5;
            labelNo.Text = "No.";
            // 
            // labelGuess
            // 
            labelGuess.AutoSize = true;
            labelGuess.Location = new Point(77, 131);
            labelGuess.Name = "labelGuess";
            labelGuess.Size = new Size(51, 19);
            labelGuess.TabIndex = 6;
            labelGuess.Text = "Guess";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(175, 131);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(52, 19);
            labelResult.TabIndex = 7;
            labelResult.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(174, 19);
            label1.TabIndex = 8;
            label1.Text = "猜一個四位不重複的數字";
            // 
            // buttonGiveUp
            // 
            buttonGiveUp.Enabled = false;
            buttonGiveUp.Location = new Point(216, 429);
            buttonGiveUp.Name = "buttonGiveUp";
            buttonGiveUp.Size = new Size(69, 29);
            buttonGiveUp.TabIndex = 10;
            buttonGiveUp.Text = "GiveUp";
            buttonGiveUp.UseVisualStyleBackColor = true;
            buttonGiveUp.Click += buttonGiveUp_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Enabled = false;
            textBoxResult.Location = new Point(13, 153);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(272, 270);
            textBoxResult.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 473);
            Controls.Add(textBoxResult);
            Controls.Add(buttonGiveUp);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(labelGuess);
            Controls.Add(labelNo);
            Controls.Add(buttonGuess);
            Controls.Add(textBoxInput);
            Controls.Add(label);
            Controls.Add(buttonQuit);
            Controls.Add(buttonNew);
            Name = "Form1";
            Text = "1A2B猜數字遊戲";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNew;
        private Button buttonQuit;
        private Label label;
        private TextBox textBoxInput;
        private Button buttonGuess;
        private Label labelNo;
        private Label labelGuess;
        private Label labelResult;
        private Label label1;
        private Button buttonGiveUp;
        private TextBox textBoxResult;
    }
}
