// Задача 3:
//Задайте произвольный массив. Выведете его элементы,
//начиная с конца. Использовать рекурсию, не использовать циклы.

public class Task3
{
    public static void Main(string[] args)
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100);
        }

        Console.WriteLine("The source array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();

        Console.WriteLine("Modified array:");
        printArray(array, array.Length - 1); 
    }

    private static void printArray(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.Write($"{array[index]} ");

        printArray(array, index - 1);
    }
}