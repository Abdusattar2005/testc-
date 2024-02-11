using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Для выхода нажмите клавишу E.");
        Random random = new Random();
        int secretMessageInterval = random.Next(10, 30); 
        int colorChangeInterval = 5; 
        while (true)
        {
            int randomDigit = random.Next(2);

            Console.Write(randomDigit);

            if (DateTime.Now.Second % colorChangeInterval == 0)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(16); 
                Console.BackgroundColor = (ConsoleColor)random.Next(16); 
            }

            if (DateTime.Now.Second % secretMessageInterval == 0)
            {
                Console.WriteLine("\nСекретное сообщение!");
                Thread.Sleep(2000); 
            }

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.E)
                break;

            Thread.Sleep(100); 
        }

        Console.ResetColor();
    }
}
