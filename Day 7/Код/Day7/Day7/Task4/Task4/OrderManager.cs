using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class OrderManager
    {
        public event EventHandler<OrderEventArgs> OrderPlaced;

        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine("Заказ был размещен");
            OnOrderPlaced(new OrderEventArgs(orderDetails));
        }


        protected virtual void OnOrderPlaced(OrderEventArgs e)
        {
            OrderPlaced?.Invoke(this, e);
        }
    }
}
