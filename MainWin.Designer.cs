namespace FileManagerOKBM
{
    partial class MainWin
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
            SearchButton = new Button();
            PathToDirectory = new TextBox();
            dataGridView1 = new DataGridView();
            NameFile = new DataGridViewTextBoxColumn();
            Extension = new DataGridViewTextBoxColumn();
            SizeBytes = new DataGridViewTextBoxColumn();
            LastWriteTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Location = new Point(1201, 614);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(89, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Применить";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.MouseClick += SearchButton_Click;
            // 
            // PathToDirectory
            // 
            PathToDirectory.Location = new Point(12, 615);
            PathToDirectory.Name = "PathToDirectory";
            PathToDirectory.PlaceholderText = "Введите путь до каталога";
            PathToDirectory.Size = new Size(1183, 23);
            PathToDirectory.TabIndex = 1;
            PathToDirectory.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameFile, Extension, SizeBytes, LastWriteTime });
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1278, 596);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameFile
            // 
            NameFile.DataPropertyName = "NameFile";
            NameFile.FillWeight = 5000F;
            NameFile.HeaderText = "Имя файла";
            NameFile.Name = "NameFile";
            NameFile.ReadOnly = true;
            NameFile.SortMode = DataGridViewColumnSortMode.NotSortable;
            NameFile.Width = 975;
            // 
            // Extension
            // 
            Extension.DataPropertyName = "Extension";
            Extension.HeaderText = "Тип файла";
            Extension.Name = "Extension";
            Extension.ReadOnly = true;
            Extension.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SizeBytes
            // 
            SizeBytes.DataPropertyName = "SizeBytes";
            SizeBytes.HeaderText = "Размер файла";
            SizeBytes.Name = "SizeBytes";
            SizeBytes.ReadOnly = true;
            SizeBytes.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // LastWriteTime
            // 
            LastWriteTime.DataPropertyName = "LastWriteTime";
            LastWriteTime.HeaderText = "Дата изменения";
            LastWriteTime.Name = "LastWriteTime";
            LastWriteTime.ReadOnly = true;
            LastWriteTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1301, 649);
            Controls.Add(dataGridView1);
            Controls.Add(PathToDirectory);
            Controls.Add(SearchButton);
            Name = "MainWin";
            Text = "MainWin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox PathToDirectory;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameFile;
        private DataGridViewTextBoxColumn Extension;
        private DataGridViewTextBoxColumn SizeBytes;
        private DataGridViewTextBoxColumn LastWriteTime;
    }
}
