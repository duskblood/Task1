using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class NewsPublisher
    {
        private readonly List<INewsSubscriber> _subscribers = new List<INewsSubscriber>();

        
        public void Subscribe(INewsSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(INewsSubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string news)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(news);
            }
        }

        public void PublishNews(string news)
        {
            Console.WriteLine($"Новая новость: {news}");
            NotifySubscribers(news);
        }
    }
}
