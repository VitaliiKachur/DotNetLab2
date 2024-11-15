using System;
using System.Linq;

public static class StringExtensions
{
    public static string Invert(this string str)
    {
        if (string.IsNullOrEmpty(str)) return str;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static int CountOccurrences(this string str, char symbol)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.Count(c => c == symbol);
    }
}
