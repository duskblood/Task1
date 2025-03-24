using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task1
{
    internal class FileLogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        public void Log(string message)
        {
            File.AppendAllText(filePath, $"File Log: {message}\n");
        }
    }
}
