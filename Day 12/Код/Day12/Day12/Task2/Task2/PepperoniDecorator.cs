using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", с пепперони";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 2.00; 
        }
    }

}
