using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SmsService
    {
        public void OnOrderPlaced(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Отправлено SMS-сообщение с подробностями заказа: {e.OrderDetails}");
        }
    }
}
