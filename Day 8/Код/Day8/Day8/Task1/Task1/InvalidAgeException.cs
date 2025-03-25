using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(): base("Возраст должен быть 18 лет или больше.")
        {
        }

       
        public InvalidAgeException(string message)
            : base(message)
        {
        }

        public InvalidAgeException(string message, Exception innerException): base(message, innerException)
        {
        }
    }
}
