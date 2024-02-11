using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число для вывода таблицы умножения:");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            Console.WriteLine($"Таблица умножения для числа {number}:");

            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}