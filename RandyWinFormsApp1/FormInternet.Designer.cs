namespace RandyWinFormsApp1
{
    partial class FormInternet
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
            buttonDownload = new Button();
            labelURL = new Label();
            textBoxURL = new TextBox();
            listBoxFileData = new ListBox();
            dataGridViewStockData = new DataGridView();
            buttonExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockData).BeginInit();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(33, 58);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 29);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "下載";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(33, 25);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(38, 19);
            labelURL.TabIndex = 1;
            labelURL.Text = "URL";
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(91, 25);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(553, 27);
            textBoxURL.TabIndex = 2;
            // 
            // listBoxFileData
            // 
            listBoxFileData.FormattingEnabled = true;
            listBoxFileData.ItemHeight = 19;
            listBoxFileData.Location = new Point(33, 93);
            listBoxFileData.Name = "listBoxFileData";
            listBoxFileData.Size = new Size(959, 289);
            listBoxFileData.TabIndex = 3;
            // 
            // dataGridViewStockData
            // 
            dataGridViewStockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStockData.Location = new Point(33, 388);
            dataGridViewStockData.Name = "dataGridViewStockData";
            dataGridViewStockData.RowHeadersWidth = 51;
            dataGridViewStockData.Size = new Size(959, 346);
            dataGridViewStockData.TabIndex = 4;
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(133, 58);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(94, 29);
            buttonExcel.TabIndex = 5;
            buttonExcel.Text = "轉出EXCEL";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // FormInternet
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 586);
            Controls.Add(buttonExcel);
            Controls.Add(dataGridViewStockData);
            Controls.Add(listBoxFileData);
            Controls.Add(textBoxURL);
            Controls.Add(labelURL);
            Controls.Add(buttonDownload);
            Name = "FormInternet";
            Text = "FormInternet";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private Label labelURL;
        private TextBox textBoxURL;
        private ListBox listBoxFileData;
        private DataGridView dataGridViewStockData;
        private Button buttonExcel;
    }
}