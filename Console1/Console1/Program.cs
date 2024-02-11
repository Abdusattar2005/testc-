using System;

namespace Console1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int monthNumber;

            while (true)
            {
                Console.Write("Введите номер месяца (от 1 до 12): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out monthNumber))
                {
                    if (monthNumber >= 1 && monthNumber <= 12)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введите число от 1 до 12.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите целое число.");
                }
            }

            string season;
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                season = "весна";
            }
            else if (monthNumber >= 6 && monthNumber <= 8)
            {
                season = "лето";
            }
            else if (monthNumber >= 9 && monthNumber <= 11)
            {
                season = "осень";
            }
            else
            {
                season = "зима";
            }

            Console.WriteLine($"Введенный месяц соответствует времени года: {season}.");

        }
    }
}