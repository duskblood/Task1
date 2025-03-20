using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class ArrayUtils
    {
        public static int GetMaxValue(Person[] people)
        {
            int maxAge = people[0].Age;

            foreach (var person in people)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                }
            }

            return maxAge;
        }
    }
}
