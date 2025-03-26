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
            IRepository<int> repository = new MemoryRepository<int>();
            RepositoryManager<int> manager = new RepositoryManager<int>(repository);

            repository.Add(1);
            repository.Add(2);
            repository.Add(3);

            Console.WriteLine("Все элементы в хранилище:");
            manager.DisplayAll();

            int foundItem = manager.Find(x => x == 2);
            Console.WriteLine($"\nНайденнй элемент: {foundItem}");

            bool removed = repository.Remove(2);
            Console.WriteLine($"\nУдален второй элемент: {removed}");

            Console.WriteLine("Элементы после удаление :");
            manager.DisplayAll();
        }
    }
}
