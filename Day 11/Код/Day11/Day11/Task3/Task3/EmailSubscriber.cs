using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class EmailSubscriber : INewsSubscriber
    {
        private string _email;

        public EmailSubscriber(string email)
        {
            _email = email;
        }

        public void Update(string news)
        {
            Console.WriteLine($"Отправка Email на {_email}: {news}");
        }
    }
}
