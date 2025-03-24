using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class OrderManager
    {
        public event OrderPlacedEventHandler OrderPlaced;

       
        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine("Заказ был размещен");
            OnOrderPlaced(orderDetails);
        }

        protected virtual void OnOrderPlaced(string orderDetails)
        {
            OrderPlaced?.Invoke(orderDetails);
        }
    }
}
