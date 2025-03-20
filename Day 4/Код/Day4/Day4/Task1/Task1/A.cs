using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class A
    {
        private int a;
        private int b;

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int CalculateSum()
        {
            return a + b;
        }

        public double CalculateExpression()
        {
          
            return (Math.Sin(b) * b) / (3 * a);
        }
    }
}
