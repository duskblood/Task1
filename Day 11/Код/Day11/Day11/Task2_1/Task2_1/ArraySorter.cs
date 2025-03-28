using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class ArraySorter 
    {
        private ISortingStrategy _sortingStrategy;

        public ArraySorter(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public void SetSortingStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public void SortArray(int[] array)
        {
            _sortingStrategy.Sort(array);
        }
    }
}
