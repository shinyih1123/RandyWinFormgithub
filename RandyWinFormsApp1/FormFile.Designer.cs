namespace RandyWinFormsApp1
{
    partial class FormFile
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            labelFileName = new Label();
            buttonCreate = new Button();
            buttonLoad = new Button();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            listBoxFileData = new ListBox();
            tabPage2 = new TabPage();
            dataGridViewFileData = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFileData).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4444447F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.55556F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelFileName);
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(buttonLoad);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 68);
            panel1.TabIndex = 0;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Location = new Point(306, 45);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(0, 19);
            labelFileName.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(154, 13);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(139, 51);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "產出檔案";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(9, 13);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(139, 51);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "讀取檔案";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(3, 77);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(794, 370);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxFileData);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 338);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CSV";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxFileData
            // 
            listBoxFileData.Dock = DockStyle.Fill;
            listBoxFileData.FormattingEnabled = true;
            listBoxFileData.ItemHeight = 19;
            listBoxFileData.Location = new Point(3, 3);
            listBoxFileData.Name = "listBoxFileData";
            listBoxFileData.Size = new Size(780, 332);
            listBoxFileData.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewFileData);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gridview";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFileData
            // 
            dataGridViewFileData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFileData.Dock = DockStyle.Fill;
            dataGridViewFileData.Location = new Point(3, 3);
            dataGridViewFileData.Name = "dataGridViewFileData";
            dataGridViewFileData.RowHeadersWidth = 51;
            dataGridViewFileData.Size = new Size(780, 341);
            dataGridViewFileData.TabIndex = 0;
            // 
            // FormFile
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormFile";
            Text = "FormFile";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFileData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonCreate;
        private Button buttonLoad;
        private Label labelFileName;
        private ListBox listBoxFileData;
        private DataGridView dataGridViewFileData;
    }
}