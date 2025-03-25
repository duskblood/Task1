using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class FileProcessor
    {
        private readonly FileReader _fileReader;

        public FileProcessor()
        {
            _fileReader = new FileReader();
        }

        public void ProcessFile(string path)
        {
            try
            {
                _fileReader.ReadFile(path);
            }
            catch (FileNotFoundException ex)
            {
                throw new CustomFileException("Ошибка при чтении файла.", ex);
            }
        }
    }
}
