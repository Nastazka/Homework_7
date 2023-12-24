// Задача 2:
// Напишите программу вычисления функции Аккермана с
// помощью рекурсии. Даны два неотрицательных числа m и n.

public class Task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter m:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());

        int a = Ackerman(m, n);

        Console.WriteLine("The value of the Ackerman function: {0}", a);
    }

    private static int Ackerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }
}