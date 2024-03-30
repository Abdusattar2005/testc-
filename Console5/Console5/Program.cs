using System;

class Program
{
    static string[] expenseCategories = { "Продукты", "Транспорт", "Учеба", "Жилье", "Развлечения" };
    static double[] expenses = new double[expenseCategories.Length];
    static double budget;

    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в Менеджер Расходов!");

        Console.Write("Введите ваш стартовый бюджет: ");
        budget = double.Parse(Console.ReadLine());

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Просмотреть категории расходов");
            Console.WriteLine("2. Добавить расход");
            Console.WriteLine("3. Просмотреть текущий бюджет и расходы");
            Console.WriteLine("4. Выйти");

            Console.Write("Ваш выбор: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowExpenseCategories();
                    break;
                case 2:
                    AddExpense();
                    break;
                case 3:
                    ShowBudgetAndExpenses();
                    break;
                case 4:
                    exit = true;
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void ShowExpenseCategories()
    {
        Console.WriteLine("\nКатегории расходов:");
        for (int i = 0; i < expenseCategories.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {expenseCategories[i]}");
        }
    }

    static void AddExpense()
    {
        Console.WriteLine("\nВведите номер категории расходов:");
        int categoryIndex = int.Parse(Console.ReadLine()) - 1;

        if (categoryIndex >= 0 && categoryIndex < expenseCategories.Length)
        {
            Console.Write("Введите сумму расхода: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= budget)
            {
                expenses[categoryIndex] += amount;
                budget -= amount;
                Console.WriteLine("Расход успешно добавлен!");
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
        }
        else
        {
            Console.WriteLine("Неверный номер категории!");
        }
    }

    static void ShowBudgetAndExpenses()
    {
        Console.WriteLine($"\nТекущий бюджет: {budget}");
        Console.WriteLine("Расходы по категориям:");
        for (int i = 0; i < expenseCategories.Length; i++)
        {
            Console.WriteLine($"{expenseCategories[i]}: {expenses[i]}");
        }
    }
}