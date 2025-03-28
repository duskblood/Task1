using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Logger logger = Logger.Instance;

            logger.Log("Приложение запущено");
            logger.Log("Приложение работает");
            logger.Log("Приложение завершено");

            logger.ShowLogs();
        }
    }
}
