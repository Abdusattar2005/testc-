using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ConsoleРабочий.Properties;

class Program
{
    static void Main()
    {
        string result = "Apple";
        Product product = new Product();
        product.Name = "Apple";
        product.Price = 0.99m;
        product.Articul = "123";
        product.Description = "Red apple";
        
        Product product2 = new Product();
        product2.Name = "Banana";
        product2.Price = 1.09m;
        product2.Articul = "125";
        product2.Description = "Banana";

        List<Product> products = new List<Product>();
        products.Add(product);
        
        List<Product> product2s = new List<Product>();
        products.Add(product2);

        foreach (var p in products)
        {
            Console.WriteLine("Name product:");
            product.Name= Console.ReadLine();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Articul);
            Console.WriteLine(p.Description);
            
            
        }
        foreach (var p in product2s)
        {
            
            Console.WriteLine("Name product: ");
             product2.Name= Console.ReadLine();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Articul);
            Console.WriteLine(p.Description);
            
        }
    }
}