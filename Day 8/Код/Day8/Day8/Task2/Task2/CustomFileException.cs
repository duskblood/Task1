using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CustomFileException : Exception
    {
        public CustomFileException(string message, Exception innerException): base(message, innerException)
        {
        }

    }
}
