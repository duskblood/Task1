using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class OrderNotifier
    {
        private readonly OrderManager _orderManager;
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;

        public OrderNotifier(OrderManager orderManager)
        {
            _orderManager = orderManager;
            _emailService = new EmailService();
            _smsService = new SmsService();

           
            _orderManager.OrderPlaced += _emailService.OnOrderPlaced;
            _orderManager.OrderPlaced += _smsService.OnOrderPlaced;
        }
    }
}
