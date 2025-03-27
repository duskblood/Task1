using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileInfoProvider
    {
        public FileInfo GetFileInfo(string filename)
        {
            if (File.Exists(filename))
            {
                var fileInfo = new FileInfo(filename);
                return fileInfo;
            }
            else
            {
                Console.WriteLine($"Ошибка: Файл {filename} не существует.");
                return null;
            }
        }
    }

}
