using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class SmsNotifier
    {
        public void OnOrderPlaced(string orderDetails)
        {
            Console.WriteLine($"Отправлено SMS-сообщение с подробностями заказа: {orderDetails}");
        }
    }
}
