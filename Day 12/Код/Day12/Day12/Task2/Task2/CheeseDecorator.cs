using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", с сыром";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.50; // стоимость сыра
        }
    }
}
