using System;
using System.Collections.Generic;

public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4]; 
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count++] = item;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(items, item, 0, count);
        if (index < 0) return false;

        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[--count] = default; 
        return true;
    }

    public T Find(Predicate<T> predicate)
    {
        for (int i = 0; i < count; i++)
        {
            if (predicate(items[i]))
            {
                return items[i];
            }
        }
        return default; 
    }

    public void Sort(Comparison<T> comparison)
    {
        Array.Sort(items, 0, count, Comparer<T>.Create(comparison));
    }

    public int Count => count;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекст в диапозоне.");
            return items[index];
        }
    }

    private void Resize()
    {
        T[] newArray = new T[items.Length * 2];
        Array.Copy(items, newArray, items.Length);
        items = newArray;
    }
}