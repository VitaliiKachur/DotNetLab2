using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string sample = "hello world";
        Console.WriteLine("Оригінальний рядок: " + sample);
        Console.WriteLine("Інвертований рядок: " + sample.Invert()); 

        char symbol = 'l';
        Console.WriteLine($"Кількість входжень символу '{symbol}' у рядку: " + sample.CountOccurrences(symbol)); 

        int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };
        Console.WriteLine("\nОригінальний масив: " + string.Join(", ", numbers));

        int searchValue = 4;
        Console.WriteLine($"Кількість входжень значення {searchValue} у масиві: " + numbers.CountOccurrences(searchValue)); 

        var uniqueNumbers = numbers.GetUnique();
        Console.WriteLine("Масив унікальних елементів: " + string.Join(", ", uniqueNumbers)); 

        var dictionary = new ExtendedDictionary<string, int, string>();
        Console.WriteLine("\nДодаємо елемент у словник: (\"item1\", 100, \"value1\")");
        dictionary.Add("item1", 100, "value1");

        Console.WriteLine("Додаємо елемент у словник: (\"item2\", 200, \"value2\")");
        dictionary.Add("item2", 200, "value2");

        Console.WriteLine("Перевіряємо наявність ключа \"item1\": " + dictionary.ContainsKey("item1")); 
        Console.WriteLine("Перевіряємо наявність значень (200, \"value2\"): " + dictionary.ContainsValue(200, "value2")); 

        var element = dictionary["item1"];
        Console.WriteLine($"Елемент зі словника за ключем \"item1\": {element.Key}: {element.Value1}, {element.Value2}");

        Console.WriteLine("Видаляємо елемент з ключем \"item1\" зі словника");
        dictionary.Remove("item1");
        Console.WriteLine("Перевіряємо наявність ключа \"item1\" після видалення: " + dictionary.ContainsKey("item1")); 

        Console.WriteLine("\nПеребираємо всі елементи у словнику:");
        foreach (var elem in dictionary)
        {
            Console.WriteLine($"{elem.Key}: {elem.Value1}, {elem.Value2}");
        }

        Console.ReadLine();
    }
}
    