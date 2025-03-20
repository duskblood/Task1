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
            A obj = new A(2, 1);
            int sumResult = obj.CalculateSum();
            double expressionResult = obj.CalculateExpression();

            Console.WriteLine($"Сумма a и b: {sumResult}");
            Console.WriteLine($"Значение выражения: {expressionResult}");
        }
    }
}
