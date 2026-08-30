using System.ComponentModel;

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
            SizeText = new DataGridViewTextBoxColumn();
            NameFile = new DataGridViewTextBoxColumn();
            Extension = new DataGridViewTextBoxColumn();
            LastWriteTime = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchButton.BackColor = Color.Transparent;
            SearchButton.ImageAlign = ContentAlignment.BottomRight;
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
            PathToDirectory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameFile, Extension, SizeText, LastWriteTime });
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1306, 596);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.AutoGenerateColumns = false;
            // 
            // NameFile
            // 

            NameFile.DataPropertyName = "NameFile";
            NameFile.FillWeight = 150F;
            NameFile.HeaderText = "Имя файла";
            NameFile.MinimumWidth = 60;
            NameFile.Name = "NameFile";
            NameFile.ReadOnly = true;
            NameFile.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // SizeText
            // 
            SizeText.DataPropertyName = "SizeText";
            SizeText.FillWeight = 20F;
            SizeText.HeaderText = "Размер файла";
            SizeText.MinimumWidth = 60;
            SizeText.Name = "SizeText";
            SizeText.ReadOnly = true;
            SizeText.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Extension
            // 
            Extension.DataPropertyName = "Extension";
            Extension.FillWeight = 20F;
            Extension.HeaderText = "Тип файла";
            Extension.MinimumWidth = 60;
            Extension.Name = "Extension";
            Extension.ReadOnly = true;
            Extension.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // LastWriteTime
            // 
            LastWriteTime.DataPropertyName = "LastWriteTime";
            LastWriteTime.FillWeight = 20F;
            LastWriteTime.HeaderText = "Дата изменения";
            LastWriteTime.MinimumWidth = 60;
            LastWriteTime.Name = "LastWriteTime";
            LastWriteTime.ReadOnly = true;
            LastWriteTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1306, 651);
            Controls.Add(dataGridView1);
            Controls.Add(PathToDirectory);
            Controls.Add(SearchButton);
            Name = "MainWin";
            Text = "MainWin";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox PathToDirectory;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameFile;
        private DataGridViewTextBoxColumn Extension;
        private DataGridViewTextBoxColumn SizeText;
        private DataGridViewTextBoxColumn LastWriteTime;
    }
}
