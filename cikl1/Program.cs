using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            depositAmount += depositAmount * 0.07m;
        }

        Console.WriteLine($"Сумма вклада после {months} месяцев: {depositAmount}");
    }
}
