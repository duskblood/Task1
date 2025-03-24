using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate void OrderPlacedEventHandler(string orderDetails);
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderManager orderManager = new OrderManager();

            EmailNotifier emailNotifier = new EmailNotifier();
            SmsNotifier smsNotifier = new SmsNotifier();

            orderManager.OrderPlaced += emailNotifier.OnOrderPlaced;
            orderManager.OrderPlaced += smsNotifier.OnOrderPlaced;

            orderManager.PlaceOrder("Заказ №1234: 2 виджета A, 1 виджет B");
        }
    }
}
