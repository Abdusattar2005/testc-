using System;
class Program {
    static void Main()
    {

        Console.Write("Введите ваше имя: ");
        string имя = Console.ReadLine();

        Console.WriteLine($"Привет, {имя}!");

        Console.Write($"Введите ваш возраст, {имя}: ");
        string возраст = (Console.ReadLine());

        Console.WriteLine($"{имя}, вам {возраст} лет.");

        Console.Write($"Введите ваш рост, {имя}: ");
        string рост = (Console.ReadLine());
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();Console.WriteLine();

        Console.WriteLine($"{имя}, вам {возраст} лет, ваш рост: {рост} см.");
    }
    
}