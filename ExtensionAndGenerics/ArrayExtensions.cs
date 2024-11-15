using System;
using System.Linq;

public static class ArrayExtensions
{
    public static int CountOccurrences<T>(this T[] array, T value) where T : IEquatable<T>
    {
        return array.Count(item => item.Equals(value));
    }

    public static T[] GetUnique<T>(this T[] array)
    {
        return array.Distinct().ToArray();
    }
}
