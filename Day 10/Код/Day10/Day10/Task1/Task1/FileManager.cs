using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileManager
    {
        public void CreateFile(string filename, string content)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            File.WriteAllText(filename, content);
        }

        public void DeleteFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            else
            {
                Console.WriteLine($"Ошибка: Файл {filename} не существует.");
            }
        }

        public void CopyFile(string src, string dst)
        {
            File.Copy(src, dst, true);
        }

        public void MoveFile(string src, string dst)
        {
            File.Move(src, dst);
        }

        public void RenameFile(string oldName, string newName)
        {
            File.Move(oldName, newName);
        }

        public void DeleteFilesWithPattern(string directory, string pattern)
        {
            var files = Directory.GetFiles(directory, $"*{pattern}");
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        public string[] ListFiles(string directory)
        {
            return Directory.GetFiles(directory);
        }
    }
}
