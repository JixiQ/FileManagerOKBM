using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileManagerOKBM
{
    public partial class MainWin : Form
    {
        private readonly CreateTable _CreateTable = new CreateTable();

        public MainWin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string pathText = PathToDirectory.Text.Trim();

            _CreateTable.PopulateGrid(dataGridView1, pathText);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = dataGridView1.Rows[e.RowIndex];
            var fileData = row.DataBoundItem as CreateTable.FileInfoData;
            //MessageBox.Show(fileData.FullPath);

            if (e.RowIndex < 0) return; // по столбцу

            if (Directory.Exists(fileData.FullPath))   // Это папка
            {
                string pathText = fileData.FullPath;
                _CreateTable.PopulateGrid(dataGridView1, pathText);
            }

            // если файл
        }

    }

}
