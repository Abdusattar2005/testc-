using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // 2
        Console.WriteLine("Исходный список:");
        PrintList(numbers);

        // 3
        numbers = AddValueToList(numbers, 6);

        // 4
        Console.WriteLine("\nСписок после добавления нового значения:");
        PrintList(numbers);

        Console.ReadLine();
    }

    // 5
    static List<int> AddValueToList(List<int> list, int newValue)
    {
        // 6
        list.Add(newValue);
        return list;

    }

    // 7
    static void PrintList(List<int> list)
    {
        // 8
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}
