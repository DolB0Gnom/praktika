using System;

class Program
{
    static void Main()
    {
        string[] array = { "строка 1", "строка 2", "строка 3", "строка 4" };

        Console.Write("Введите новую строку: ");
        string userInput = Console.ReadLine();

        bool isStringFound = false;
        foreach (var str in array)
        {
            if (str == userInput)
            {
                isStringFound = true;
                break;
            }
        }

        if (isStringFound)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}