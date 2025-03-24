using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class OrderEventArgs : EventArgs
    {
        public string OrderDetails { get; }

        public OrderEventArgs(string orderDetails)
        {
            OrderDetails = orderDetails;
        }
    }
}
