using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderManager orderManager = new OrderManager();
            OrderNotifier orderNotifier = new OrderNotifier(orderManager);

            orderManager.PlaceOrder("Заказ №1234: 2 виджета A, 1 виджет B");
        }
    }
}
