using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел в последовательности Фибоначчи:");
        
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Пожалуйста, введите положительное целое число.");
        }

        GenerateFibonacciSequence(n);
    }

    static void GenerateFibonacciSequence(int n)
    {
        int firstNumber = 0;
        int secondNumber = 1;

        Console.WriteLine("Последовательность чисел Фибоначчи:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{firstNumber} ");

            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp + secondNumber;
        }
    }
}