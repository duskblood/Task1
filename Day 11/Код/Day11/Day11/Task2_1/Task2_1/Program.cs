using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 6, 2 };

            ArraySorter sorter = new ArraySorter(new BubbleSort());
            sorter.SortArray(array);
            Console.WriteLine("Bubble Sort: " + string.Join(", ", array));

            array = new[] { 5, 3, 8, 6, 2 };
            sorter.SetSortingStrategy(new QuickSort());
            sorter.SortArray(array);
            Console.WriteLine("Quick Sort: " + string.Join(", ", array));

            array = new[] { 5, 3, 8, 6, 2 };
            sorter.SetSortingStrategy(new MergeSort());
            sorter.SortArray(array);
            Console.WriteLine("Merge Sort: " + string.Join(", ", array));
        }
    }
}
