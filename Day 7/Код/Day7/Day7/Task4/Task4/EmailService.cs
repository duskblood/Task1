using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class EmailService
    {
        public void OnOrderPlaced(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Отправлено электронное письмо с подробной информацией о заказе: {e.OrderDetails}");
        }
    }
}
