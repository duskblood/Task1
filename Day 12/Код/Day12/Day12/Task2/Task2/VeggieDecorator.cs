using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class VeggieDecorator : PizzaDecorator
    {
        public VeggieDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", с овощами";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.00; 
        }
    }
}
