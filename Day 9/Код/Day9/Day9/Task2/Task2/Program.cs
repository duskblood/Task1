using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListManager<int> listManager = new ListManager<int>();

            listManager.AddItem(5);
            listManager.AddItem(2);
            listManager.AddItem(8);
            listManager.AddItem(1);

            Console.WriteLine("Объекты в листе:");
            listManager.DisplayItems();

            listManager.SortItems((x, y) => x.CompareTo(y));
            Console.WriteLine("\nОтсортированные объекты:");
            listManager.DisplayItems();

            listManager.RemoveItem(2);
            Console.WriteLine("\nУдален второй объект");
            listManager.DisplayItems();

            int foundItem = listManager.FindItem(x => x == 8);
            Console.WriteLine($"\nнайденый объект: {foundItem}");
        
    }
    }
}
