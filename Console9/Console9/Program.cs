using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("Для выхода нажмите клавишу E.");

        while (true)
        {
            int i= random.Next(10);

            Console.Write(i);

            if
            
                (Console.KeyAvailable &&
                 Console.ReadKey(true).Key == ConsoleKey.E)
            
            break;
        }
    
    }
}