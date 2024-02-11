using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите оценку (1-5) либо балл за экзамен (0-100):");

        string userInput = Console.ReadLine();

        // Проверка на корректность ввода числа
        if (int.TryParse(userInput, out int score))
        {
            // Конвертация оценки в американскую оценку успеваемости
            char grade = (score >= 0 && score <= 100) 
                ? (score >= 90) ? 'A' 
                : (score >= 80) ? 'B' 
                : (score >= 70) ? 'C' 
                : (score >= 60) ? 'D' 
                : 'F'
                : throw new ArgumentException("Оценка должна быть в диапазоне от 0 до 100");
            
            Console.WriteLine($"Американская оценка: {grade}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }
}