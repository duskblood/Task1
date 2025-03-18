using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Введите количество баллов (от 0 до 100): ");
                int score = Convert.ToInt32(Console.ReadLine());

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Ошибка: Баллы должны быть в диапазоне от 0 до 100.");
                    return;
                }

                string grade;

                switch (score)
                {
                    case int n when (n >= 90 && n <= 100):
                        grade = "Отлично";
                        break;
                    case int n when (n >= 70 && n < 90):
                        grade = "Хорошо";
                        break;
                    case int n when (n >= 50 && n < 70):
                        grade = "Удовлетворительно";
                        break;
                    default:
                        grade = "Неудовлетворительно";
                        break;
                }

                Console.WriteLine($"Оценка: {grade}");
            
          
    }
    }
}
