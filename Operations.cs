using System.Threading.Tasks;

namespace FileManagerOKBM
{
    public class CreateTable
    {
        public void PopulateGrid(DataGridView grid, string pathText)

        {
            
            var filesInfo = new List<FileInfoData>();

            var currentDirectory = new DirectoryInfo(pathText);
            var parentDirectory = currentDirectory.Parent;

            if (parentDirectory != null)
            {
                filesInfo.Add(new FileInfoData
                {
                    NameFile = "...",
                    Extension = "",
                    SizeBytes = 0,
                    SizeText = "",
                    LastWriteTime = null,
                    FullPath = parentDirectory.FullName
                });
            }

            try
            {
                foreach (string item in Directory.GetFileSystemEntries(pathText))
                {
                    string fullPath = Path.Combine(pathText, item);


                    if (Directory.Exists(fullPath))   // Это папка
                    {
                        var dirInfo = new DirectoryInfo(fullPath);

                        long totalSize = 0;

                        foreach (string file in Directory.EnumerateFiles(fullPath, "*",SearchOption.AllDirectories))
                        {
                            totalSize += new FileInfo(file).Length;
                        }

                        filesInfo.Add(new FileInfoData
                        {
                            NameFile = dirInfo.Name,
                            Extension = "Папка",

                            SizeBytes = totalSize,
                            SizeText = FormatSize(totalSize),

                            LastWriteTime = dirInfo.LastWriteTime,
                            FullPath = fullPath
                        });
                    }
                    else if (File.Exists(fullPath))   // Это файл
                    {
                        var fileInfo = new FileInfo(fullPath);
                        filesInfo.Add(new FileInfoData
                        {
                            NameFile = fileInfo.Name,
                            Extension = fileInfo.Extension,

                            SizeBytes = fileInfo.Length,
                            SizeText = FormatSize(fileInfo.Length),

                            LastWriteTime = fileInfo.LastWriteTime,
                            FullPath = fullPath
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
                                 
            grid.DataSource = filesInfo;
            
        }

        public static string FormatSize(long bytes)
        {
            string[] units = { "Б", "КБ", "МБ", "ГБ", "ТБ" };

            double size = bytes;
            int unitIndex = 0;

            while (size >= 1024 && unitIndex < units.Length - 1)
            {
                size /= 1024;
                unitIndex++;
            }

            return $"{size:F2} {units[unitIndex]}";
        }

        public class FileInfoData
        {
            public string NameFile { get; set; }
            public string Extension { get; set; }
            public long SizeBytes { get; set; } // Чистые байты
            public string SizeText { get; set; } // Отображение
            public DateTime? LastWriteTime { get; set; }
            public string FullPath { get; set; }

        }
    }
}







