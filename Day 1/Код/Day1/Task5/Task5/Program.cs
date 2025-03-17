using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

        
            if (number >= 1000 && number <= 9999)
            {
                int sum = 0;


                sum += number / 1000; 
                number %= 1000;      

                sum += number / 100;  
                number %= 100;

                sum += number / 10;
                number %= 10;        

                sum += number;       

               
                Console.WriteLine($"Сумма цифр четырехзначного числа: {sum}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите четырехзначное число.");
            }
        }
    }
}
