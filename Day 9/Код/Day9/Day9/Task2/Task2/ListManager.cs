using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ListManager<T>
    {
        private MyList<T> myList;

        public ListManager()
        {
            myList = new MyList<T>();
        }

        public void AddItem(T item)
        {
            myList.Add(item);
        }

        public void RemoveItem(T item)
        {
            if (!myList.Remove(item))
            {
                Console.WriteLine("Предмет не найден.");
            }
        }

        public T FindItem(Predicate<T> predicate)
        {
            return myList.Find(predicate);
        }

        public void SortItems(Comparison<T> comparison)
        {
            myList.Sort(comparison);
        }

        public void DisplayItems()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
