using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class AgeRestrictionException : Exception
    {
        public AgeRestrictionException(): base("Возраст должен быть 18 лет или старше для регистрации.")
        {
        }

        public AgeRestrictionException(string message): base(message)
        {
        }
    }
}
