using System;
using System.Linq;
using Task3;

public class RepositoryManager<T>
{
    private readonly IRepository<T> repository;

    public RepositoryManager(IRepository<T> repository)
    {
        this.repository = repository;
    }

    public void DisplayAll()
    {
        var allItems = repository.GetAll();
        foreach (var item in allItems)
        {
            Console.WriteLine(item);
        }
    }

    public T Find(Func<T, bool> predicate)
    {
        return repository.GetAll().FirstOrDefault(predicate);
    }
}