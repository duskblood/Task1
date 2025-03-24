using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    public delegate void MessageHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
        
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("log.txt");

            MessageHandler messageHandler = consoleLogger.Log;
            messageHandler += fileLogger.Log;

            
            messageHandler("Сообщение отправилось.");

            
            Console.WriteLine("в папку log.txt:");
            Console.WriteLine(File.ReadAllText("log.txt"));
        }
    }
}
