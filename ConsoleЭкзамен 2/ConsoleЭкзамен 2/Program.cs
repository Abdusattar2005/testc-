using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string ff;
        int a, d, f;
        Console.WriteLine("привет");
        ff = Console.ReadLine();
        a = Convert.ToInt32(ff);
        Console.WriteLine(" ведите сифры");
        ff = Console.ReadLine();
        d = Convert.ToInt32(ff);
        Console.WriteLine("ведите сифры");
        ff = Console.ReadLine();
        f = Convert.ToInt32(ff);
        int result = a *(d +f);
        Console.WriteLine(result);
        Console.WriteLine();

    }
}
