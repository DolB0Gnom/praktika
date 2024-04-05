using System;

class Program
{
    static void Main()
    {
        int[] array = { 4, 7, 12, 5, 2, 8, 9, 14, 3 };

        Console.WriteLine("Нечетные числа:");
        foreach (var num in array)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}