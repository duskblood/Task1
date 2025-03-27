using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            FileInfoProvider fileInfoProvider = new FileInfoProvider();

            string filename = "Kozel.en";

            // 1. Создать файл, записать в него текст, прочитать и вывести в консоль.
            fileManager.CreateFile(filename, "Привет, мир!");
            Console.WriteLine(File.ReadAllText(filename));

            // 2. Проверить существование файла перед его удалением.
            fileManager.DeleteFile(filename);

            // 3. Получить информацию о файле (размер, даты).
            fileManager.CreateFile(filename, "Тестовый файл");
            var info = fileInfoProvider.GetFileInfo(filename);
            if (info != null)
            {
                Console.WriteLine($"Размер: {info.Length} байт, Дата создания: {info.CreationTime}, Дата изменения: {info.LastWriteTime}");
            }

            // 4. Скопировать файл и убедиться, что копия существует.
            string copyFilename = "Kozel_copy.en";
            fileManager.CopyFile(filename, copyFilename);
            Console.WriteLine(File.Exists(copyFilename) ? "Копия существует." : "Копия не найдена.");

            // 5. Переместить файл в новую директорию.
            string newDirectory = "new_folder";
            Directory.CreateDirectory(newDirectory);
            fileManager.MoveFile(copyFilename, Path.Combine(newDirectory, copyFilename));

            // 6. Переименовать файл в файл familiya.io
            fileManager.RenameFile(Path.Combine(newDirectory, copyFilename), Path.Combine(newDirectory, "familiya.io"));

            // 7. Обработать ошибку при удалении несуществующего файла.
            fileManager.DeleteFile("non_existent_file.ii");

            // 8. Сравнить два файла по размеру.
            string anotherFile = "another_file.ii";
            fileManager.CreateFile(anotherFile, "Другой файл");
            if (new FileInfo(filename).Length == new FileInfo(anotherFile).Length)
            {
                Console.WriteLine("Файлы имеют одинаковый размер.");
            }
            else
            {
                Console.WriteLine("Файлы имеют разные размеры.");
            }

            // 9. Удалить все файлы в папке, соответствующие определенному шаблону. С расширением ii.
            fileManager.DeleteFilesWithPattern(newDirectory, ".ii");

            // 10. Вывести список всех файлов в заданной директории.
            var files = fileManager.ListFiles(newDirectory);
            Console.WriteLine("Список файлов:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            // 11. Запретить запись в файл и попытаться записать в него.
            File.SetAttributes(filename, FileAttributes.ReadOnly);
            try
            {
                File.AppendAllText(filename, "Попытка записи.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ошибка: Запись запрещена.");
            }

            // 12. Проверить доступные права к файлу (чтение, запись, выполнение).
            var attributes = File.GetAttributes(filename);
            Console.WriteLine($"Права файла {filename}: {attributes}");
        }
    }
    }

