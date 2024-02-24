using System;

namespace Угадайка
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int загаданноеЧисло = random.Next(1, 101);
            int попытки = 0;

            Console.WriteLine("Привет! Я загадал число от 1 до 100. Попробуй угадать!");

            do
            {
                Console.Write("Введи свой вариант: ");
                int вариантЧисла = Convert.ToInt32(Console.ReadLine());
                попытки++;

                if (вариантЧисла < загаданноеЧисло)
                {
                    Console.WriteLine("Моё число больше.");
                }
                else if (вариантЧисла > загаданноеЧисло)
                {
                    Console.WriteLine("Моё число меньше.");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Ты угадал число {загаданноеЧисло} за {попытки} попыток.");
                }
            } while (true);
        }
    }
}