using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Logger
    {
        private static Logger _instance;

        private List<string> _logs;

        private Logger()
        {
            _logs = new List<string>();
        }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            _logs.Add($"{DateTime.Now}: {message}");
        }

        public void ShowLogs()
        {
            foreach (var log in _logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
