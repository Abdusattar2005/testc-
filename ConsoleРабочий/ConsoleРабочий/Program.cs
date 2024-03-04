using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string aa;
        Console.WriteLine("добро пожаловат ");
        Console.ReadLine();
        Console.WriteLine("как вас завут");
        aa=Console.ReadLine();
        Console.WriteLine("как вам помоч   "+aa);
        Console.ReadLine();
        Console.WriteLine("хорошо");
        string ff;
        int a, b;
        Console.WriteLine("ведите свой цифры");
        ff = Console.ReadLine();
        a = Convert.ToInt32(ff);
        Console.WriteLine("ведите свой второй цифры");
        ff = Console.ReadLine();
        b = Convert.ToInt32(ff);
        int result = a * b;
        Console.WriteLine( result);
        
        


    }
}