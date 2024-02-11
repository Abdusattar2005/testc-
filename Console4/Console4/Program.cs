using System;

class Program
{
    static void Main()
    {
        double num1, num2, result = 0;

        while (true)
        {
            Console.Write("[Введите первое число]: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ошибка: введите корректное число.");
                continue;
            }

            Console.Write("[Введите операцию(+, -, /, *)]: ");
            char abu = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("[Введите второе число]: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка: введите корректное число.");
                continue;
            }

            switch (abu)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Некорректная операция. Пожалуйста, введите '+', '-', '*' или '/'.");
                    continue;
            }

            Console.WriteLine($"[результат] {num1} {abu} {num2} = {result}");
            break;
        }
    }
}