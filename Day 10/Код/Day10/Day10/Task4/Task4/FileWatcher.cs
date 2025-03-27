using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FileWatcher
    {
        private FileSystemWatcher _fileSystemWatcher;

        public FileWatcher(string path)
        {
         
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException($"Директория {path} не найдена.");
            }

            _fileSystemWatcher = new FileSystemWatcher(path)
            {
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = "*.*" 
            };

           
            _fileSystemWatcher.Created += OnCreated;
            _fileSystemWatcher.Deleted += OnDeleted;

           
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

     
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл {e.Name} создан.");
        }

        
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл {e.Name} удален.");
        }
    }
}
