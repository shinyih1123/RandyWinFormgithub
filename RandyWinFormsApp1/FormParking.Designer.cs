namespace RandyWinFormsApp1
{
    partial class FormParking
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
            buttonExcel = new Button();
            dataGridViewParkingData = new DataGridView();
            listBoxFileData = new ListBox();
            textBoxURL = new TextBox();
            labelURL = new Label();
            buttonDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkingData).BeginInit();
            SuspendLayout();
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(112, 47);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(94, 29);
            buttonExcel.TabIndex = 11;
            buttonExcel.Text = "轉出EXCEL";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // dataGridViewParkingData
            // 
            dataGridViewParkingData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkingData.Location = new Point(12, 377);
            dataGridViewParkingData.Name = "dataGridViewParkingData";
            dataGridViewParkingData.RowHeadersWidth = 51;
            dataGridViewParkingData.Size = new Size(1333, 346);
            dataGridViewParkingData.TabIndex = 10;
            // 
            // listBoxFileData
            // 
            listBoxFileData.FormattingEnabled = true;
            listBoxFileData.ItemHeight = 19;
            listBoxFileData.Location = new Point(12, 82);
            listBoxFileData.Name = "listBoxFileData";
            listBoxFileData.Size = new Size(1333, 289);
            listBoxFileData.TabIndex = 9;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(70, 14);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(1275, 27);
            textBoxURL.TabIndex = 8;
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(12, 14);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(38, 19);
            labelURL.TabIndex = 7;
            labelURL.Text = "URL";
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(12, 47);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 29);
            buttonDownload.TabIndex = 6;
            buttonDownload.Text = "下載";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // FormParking
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 637);
            Controls.Add(buttonExcel);
            Controls.Add(dataGridViewParkingData);
            Controls.Add(listBoxFileData);
            Controls.Add(textBoxURL);
            Controls.Add(labelURL);
            Controls.Add(buttonDownload);
            Name = "FormParking";
            Text = "FormParking";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkingData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExcel;
        private DataGridView dataGridViewParkingData;
        private ListBox listBoxFileData;
        private TextBox textBoxURL;
        private Label labelURL;
        private Button buttonDownload;
    }
}