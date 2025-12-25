using System;

public partial class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите числа через пробел:");
            string input = Console.ReadLine();

            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            int result = SumPositive(numbers);
            Console.WriteLine($"Сумма положительных элементов: {result}");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода данных");
        }
    }

    public static int SumPositive(int[] array)
    {
        int sum = 0;
        foreach (int x in array)
            if (x > 0)
                sum += x;
        return sum;
    }
}
//