using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class EmailNotifier
    {
        public void OnOrderPlaced(string orderDetails)
        {
            Console.WriteLine($"Отправлено электронное письмо с подробной информацией о заказе: {orderDetails}");
        }
    }
}
