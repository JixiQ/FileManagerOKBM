using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileManagerOKBM
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string path = PathToDirectory.Text.Trim();

            var filesInfo = new List<FileInfoData>();

            try
            {
                foreach (string item in Directory.GetFileSystemEntries(path))
                {
                    string fullPath = Path.Combine(path, item);


                    if (Directory.Exists(fullPath))
                    {
                        // Это папка
                        var dirInfo = new DirectoryInfo(fullPath);
                        filesInfo.Add(new FileInfoData
                        {
                            NameFile = dirInfo.Name,
                            Extension = "Папка",                 
                            SizeBytes = 0,
                            LastWriteTime = dirInfo.LastWriteTime
                        });
                    }
                    else if (File.Exists(fullPath))
                    {
                        // Это файл
                        var fileInfo = new FileInfo(fullPath);
                        filesInfo.Add(new FileInfoData
                        {
                            NameFile = fileInfo.Name,
                            Extension = fileInfo.Extension,      
                            SizeBytes = fileInfo.Length,
                            LastWriteTime = fileInfo.LastWriteTime
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filesInfo;

        }
    
        public class FileInfoData
        {
            public string NameFile { get; set; }
            public string Extension { get; set; }      
            public long SizeBytes { get; set; }  
            public DateTime LastWriteTime { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}
