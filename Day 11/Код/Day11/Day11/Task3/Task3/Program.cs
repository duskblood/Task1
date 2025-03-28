using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newsPublisher = new NewsPublisher();

            
            var emailSubscriber = new EmailSubscriber("example@example.com");
            var mobileSubscriber = new MobileSubscriber("123-456-7890");

            
            newsPublisher.Subscribe(emailSubscriber);
            newsPublisher.Subscribe(mobileSubscriber);

            
            newsPublisher.PublishNews("Сегодня солнечно!");
            newsPublisher.PublishNews("Завтра будет дождь.");

            newsPublisher.Unsubscribe(emailSubscriber);

            newsPublisher.PublishNews("Погода улучшится к выходным.");
        }
    }
}
