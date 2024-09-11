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
            buttonConnect = new Button();
            dataGridView1 = new DataGridView();
            buttonSelect = new Button();
            buttonUpdate = new Button();
            tabControl = new TabControl();
            tabPageBox = new TabPage();
            buttonExcel = new Button();
            buttonUnLoadCSV = new Button();
            buttonLoadCSV = new Button();
            buttonInsert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            textBoxIndex = new TextBox();
            buttonDelete = new Button();
            tabPageGuessNumber = new TabPage();
            tabPage1 = new TabPage();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage2 = new TabPage();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage3 = new TabPage();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl.SuspendLayout();
            tabPageBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabPageGuessNumber.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(17, 18);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(99, 45);
            buttonNew.TabIndex = 0;
            buttonNew.Text = "New Game";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(191, 18);
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
            label.Location = new Point(18, 103);
            label.Name = "label";
            label.Size = new Size(39, 19);
            label.TabIndex = 2;
            label.Text = "輸入";
            // 
            // textBoxInput
            // 
            textBoxInput.Enabled = false;
            textBoxInput.Location = new Point(63, 100);
            textBoxInput.MaxLength = 4;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(111, 27);
            textBoxInput.TabIndex = 3;
            // 
            // buttonGuess
            // 
            buttonGuess.Enabled = false;
            buttonGuess.Location = new Point(180, 98);
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
            labelNo.Location = new Point(18, 137);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(33, 19);
            labelNo.TabIndex = 5;
            labelNo.Text = "No.";
            // 
            // labelGuess
            // 
            labelGuess.AutoSize = true;
            labelGuess.Location = new Point(82, 137);
            labelGuess.Name = "labelGuess";
            labelGuess.Size = new Size(51, 19);
            labelGuess.TabIndex = 6;
            labelGuess.Text = "Guess";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(180, 137);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(52, 19);
            labelResult.TabIndex = 7;
            labelResult.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 76);
            label1.Name = "label1";
            label1.Size = new Size(174, 19);
            label1.TabIndex = 8;
            label1.Text = "猜一個四位不重複的數字";
            // 
            // buttonGiveUp
            // 
            buttonGiveUp.Enabled = false;
            buttonGiveUp.Location = new Point(221, 435);
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
            textBoxResult.Location = new Point(18, 159);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(272, 270);
            textBoxResult.TabIndex = 11;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(21, 15);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(112, 46);
            buttonConnect.TabIndex = 12;
            buttonConnect.Text = "資料庫連線";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(993, 396);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += DataGridView1_CellDoubleClick;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(136, 15);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(111, 46);
            buttonSelect.TabIndex = 14;
            buttonSelect.Text = "查詢";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(488, 15);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 46);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "修改";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageBox);
            tabControl.Controls.Add(tabPageGuessNumber);
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(12, 14);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1031, 555);
            tabControl.TabIndex = 16;
            // 
            // tabPageBox
            // 
            tabPageBox.Controls.Add(buttonExcel);
            tabPageBox.Controls.Add(buttonUnLoadCSV);
            tabPageBox.Controls.Add(buttonLoadCSV);
            tabPageBox.Controls.Add(buttonInsert);
            tabPageBox.Controls.Add(tableLayoutPanel1);
            tabPageBox.Controls.Add(buttonConnect);
            tabPageBox.Controls.Add(buttonDelete);
            tabPageBox.Controls.Add(buttonUpdate);
            tabPageBox.Controls.Add(buttonSelect);
            tabPageBox.Location = new Point(4, 28);
            tabPageBox.Name = "tabPageBox";
            tabPageBox.Padding = new Padding(3);
            tabPageBox.Size = new Size(1023, 523);
            tabPageBox.TabIndex = 0;
            tabPageBox.Text = "勇者物品";
            tabPageBox.UseVisualStyleBackColor = true;
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(845, 15);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(113, 46);
            buttonExcel.TabIndex = 21;
            buttonExcel.Text = "匯出EXCEL";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // buttonUnLoadCSV
            // 
            buttonUnLoadCSV.Location = new Point(726, 15);
            buttonUnLoadCSV.Name = "buttonUnLoadCSV";
            buttonUnLoadCSV.Size = new Size(113, 46);
            buttonUnLoadCSV.TabIndex = 20;
            buttonUnLoadCSV.Text = "匯出CSV";
            buttonUnLoadCSV.UseVisualStyleBackColor = true;
            buttonUnLoadCSV.Click += buttonUnLoadCSV_Click;
            // 
            // buttonLoadCSV
            // 
            buttonLoadCSV.Location = new Point(607, 15);
            buttonLoadCSV.Name = "buttonLoadCSV";
            buttonLoadCSV.Size = new Size(113, 46);
            buttonLoadCSV.TabIndex = 19;
            buttonLoadCSV.Text = "匯入CSV";
            buttonLoadCSV.UseVisualStyleBackColor = true;
            buttonLoadCSV.Click += buttonLoadCSV_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(253, 15);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(113, 46);
            buttonInsert.TabIndex = 17;
            buttonInsert.Text = "新增";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Location = new Point(18, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.07371F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.92629F));
            tableLayoutPanel1.Size = new Size(999, 447);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBoxIndex);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(993, 35);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 15;
            label2.Text = "索引";
            label2.Click += label2_Click;
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(48, 3);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(532, 27);
            textBoxIndex.TabIndex = 14;
            textBoxIndex.TextChanged += textBoxIndex_TextChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(372, 15);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 46);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "刪除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // tabPageGuessNumber
            // 
            tabPageGuessNumber.Controls.Add(buttonNew);
            tabPageGuessNumber.Controls.Add(buttonQuit);
            tabPageGuessNumber.Controls.Add(label);
            tabPageGuessNumber.Controls.Add(textBoxInput);
            tabPageGuessNumber.Controls.Add(buttonGuess);
            tabPageGuessNumber.Controls.Add(labelNo);
            tabPageGuessNumber.Controls.Add(textBoxResult);
            tabPageGuessNumber.Controls.Add(labelGuess);
            tabPageGuessNumber.Controls.Add(buttonGiveUp);
            tabPageGuessNumber.Controls.Add(labelResult);
            tabPageGuessNumber.Controls.Add(label1);
            tabPageGuessNumber.Location = new Point(4, 28);
            tabPageGuessNumber.Name = "tabPageGuessNumber";
            tabPageGuessNumber.Padding = new Padding(3);
            tabPageGuessNumber.Size = new Size(1023, 523);
            tabPageGuessNumber.TabIndex = 1;
            tabPageGuessNumber.Text = "猜數字";
            tabPageGuessNumber.UseVisualStyleBackColor = true;
            tabPageGuessNumber.Click += tabPageGuessNumber_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cartesianChart1);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1023, 523);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "折線圖";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Dock = DockStyle.Fill;
            cartesianChart1.Location = new Point(0, 0);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1023, 523);
            cartesianChart1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cartesianChart2);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1023, 523);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "直條圖";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Dock = DockStyle.Fill;
            cartesianChart2.Location = new Point(0, 0);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(1023, 523);
            cartesianChart2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pieChart1);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1023, 523);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "圓餅圖";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pieChart1
            // 
            pieChart1.Dock = DockStyle.Fill;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(0, 0);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(1023, 523);
            pieChart1.TabIndex = 0;
            pieChart1.Total = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 581);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "勇者物品WinForms";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl.ResumeLayout(false);
            tabPageBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabPageGuessNumber.ResumeLayout(false);
            tabPageGuessNumber.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button buttonConnect;
        private DataGridView dataGridView1;
        private Button buttonSelect;
        private Button buttonUpdate;
        private TabControl tabControl;
        private TabPage tabPageBox;
        private TabPage tabPageGuessNumber;
        private Button buttonInsert;
        private Button buttonDelete;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxIndex;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button buttonLoadCSV;
        private Button buttonUnLoadCSV;
        private Button buttonExcel;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}
