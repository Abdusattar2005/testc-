using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");

        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Введенное число четное.");
            }
            else
            {
                Console.WriteLine("Введенное число нечетное.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}