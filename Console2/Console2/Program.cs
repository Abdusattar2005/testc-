using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");

        float age = GetAge();
        Console.WriteLine($"Вам {age} лет.");

        float height = GetHeight(age);
        Console.WriteLine($"Вам {age} лет, ваш рост: {height}");
    }

    static float GetAge()
    {
        while (true)
        {
            Console.Write("Введите ваш возраст: ");
            if (float.TryParse(Console.ReadLine(), out float age))
            {
                return age;
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }
    }

    static float GetHeight(float age)
    {
        while (true)
        {
            Console.Write($"Вам {age} лет. Введите ваш рост: ");
            if (float.TryParse(Console.ReadLine(), out float height))
            {
                return height;
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }
    }
}