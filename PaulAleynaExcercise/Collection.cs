using System.Collections;

namespace PaulAleynaExcercise;

/*
    Eine Collection ist eine Gruppe von Objekten, die zusammengefasst werden.
    In C# gibt es verschiedene Arten von Collections, wie z.B. List, Dictionary, Queue, Stack.
    Eine Collection kann auch benutzerdefiniert sein, wie in diesem Beispiel.
    Wichtig ein Array und eine Collection ist nicht das gleiche!. Eine Collection ist meistens Flexibler als ein Array da es Methoden wie Add, Remove, Contains, etc. hat.
    Ein Array hat eine feste Größe und kann nicht verändert werden. Collections bieten auch die Möglichkeit, Elemente zu sortieren, zu filtern, zu durchsuchen, etc 
    was bei einem Array nicht direkt so möglich ist. 
 */

public class SimpleCollection<T> : ICollection<T>
{
    private readonly List<T> _items = new();

    public int Count => _items.Count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Clear()
    {
        _items.Clear();
    }

    public bool Contains(T item)
    {
        return _items.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        _items.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Remove(T item)
    {
        return _items.Remove(item);
    }
}

