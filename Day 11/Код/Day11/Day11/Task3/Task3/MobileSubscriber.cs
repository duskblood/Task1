using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MobileSubscriber : INewsSubscriber
    {
        private string _phoneNumber;

        public MobileSubscriber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public void Update(string news)
        {
            Console.WriteLine($"Отправка SMS на {_phoneNumber}: {news}");
        }
    }
}
