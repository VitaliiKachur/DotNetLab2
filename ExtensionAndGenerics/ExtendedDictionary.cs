using System;
using System.Collections.Generic;
using System.Linq;

public class ExtendedDictionaryElement<T, U, V>
{
    public T Key { get; set; }
    public U Value1 { get; set; }
    public V Value2 { get; set; }

    public ExtendedDictionaryElement(T key, U value1, V value2)
    {
        Key = key;
        Value1 = value1;
        Value2 = value2;
    }
}

public class ExtendedDictionary<T, U, V>
{
    private readonly List<ExtendedDictionaryElement<T, U, V>> elements = new List<ExtendedDictionaryElement<T, U, V>>();

    public int Count => elements.Count;

    public void Add(T key, U value1, V value2)
    {
        if (elements.Any(e => e.Key.Equals(key)))
            throw new ArgumentException("Key already exists.");
        elements.Add(new ExtendedDictionaryElement<T, U, V>(key, value1, value2));
    }

    public void Remove(T key)
    {
        var element = elements.FirstOrDefault(e => e.Key.Equals(key));
        if (element != null)
            elements.Remove(element);
    }

    public bool ContainsKey(T key) => elements.Any(e => e.Key.Equals(key));

    public bool ContainsValue(U value1, V value2) =>
        elements.Any(e => e.Value1.Equals(value1) && e.Value2.Equals(value2));

    public ExtendedDictionaryElement<T, U, V> this[T key]
    {
        get => elements.FirstOrDefault(e => e.Key.Equals(key))
               ?? throw new KeyNotFoundException("Key not found.");
    }

    public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
    {
        return elements.GetEnumerator();
    }
}
