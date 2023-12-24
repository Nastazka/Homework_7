// Задача 1:
//Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N. Использовать рекурсию,
//не использовать циклы.

public class Task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter M:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());

        printNumbers(m, n);
    }

    private static void printNumbers(int m, int n)
    {
        if (m > n)
        {
            return;
        }

        Console.Write($"{m} ");

        printNumbers(m + 1, n);
    }
}