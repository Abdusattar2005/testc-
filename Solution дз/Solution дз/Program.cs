using System;

class Program
{
    static void Main()
    {
        int day, month, year;

        // Запросить пользователя ввести день
        while (true)
        {
            Console.Write("Введите день: ");
            if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число от 1 до 31.");
            }
        }

        // Запросить пользователя ввести месяц
        while (true)
        {
            Console.Write("Введите месяц: ");
            if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
            {
                // Проверка корректности дня в выбранном месяце
                if (IsValidDayInMonth(day, month))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введенный день некорректен для выбранного месяца.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число от 1 до 12.");
            }
        }

        // Запросить пользователя ввести год
        while (true)
        {
            Console.Write("Введите год (от 0 до 2024): ");
            if (int.TryParse(Console.ReadLine(), out year) && year >= 0 && year <= 2024)
            {
                // Проверка корректности дня в выбранном году
                if (IsValidDayInYear(day, month, year))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введенный день некорректен для выбранного года.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число от 0 до 2024.");
            }
        }

        // Определить День недели, Время года и Високосность года
        DateTime inputDate = new DateTime(year, month, day);
        string dayOfWeek = inputDate.DayOfWeek.ToString();
        string season = GetSeason(month);
        bool isLeapYear = DateTime.IsLeapYear(year);

        // Вывести информацию
        Console.WriteLine($"День недели: {dayOfWeek}");
        Console.WriteLine($"Время года: {season}");
        Console.WriteLine($"Високосный год: {(isLeapYear ? "Да" : "Нет")}");
    }

    // Метод для определения времени года
    static string GetSeason(int month)
    {
        if (month >= 3 && month <= 5)
            return "весна";
        else if (month >= 6 && month <= 8)
            return "лето";
        else if (month >= 9 && month <= 11)
            return "осень";
        else
            return "зима";
    }

    // Метод для проверки корректности дня в выбранном месяце
    static bool IsValidDayInMonth(int day, int month)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2)
        {
            // Проверка для февраля
            return day <= daysInMonth[1];
        }
        else
        {
            return day <= daysInMonth[month - 1];
        }
    }

    // Метод для проверки корректности дня в выбранном году
    static bool IsValidDayInYear(int day, int month, int year)
    {
        if (month == 2)
        {
            // Проверка для февраля в високосном году
            if (DateTime.IsLeapYear(year))
                return day <= 29;
            else
                return day <= 28;
        }
        else
        {
            return true;
        }
    }
}
