using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 11, 13, 18, 23 };

        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое значение элементов массива: " + average);
    }
}