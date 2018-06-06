using System;

class GenericMethod
{
    static void Main()
    {
        //Arrays
        int[] intArray = { 1, 2, 3, 4, 5, 6 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
        char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

        Console.Write("Array intArray contains: ");
        DisplayArray(intArray);
        Console.Write("Array doubleArray contains: ");
        DisplayArray(doubleArray);
        Console.Write("Array charArray contains: ");
        DisplayArray(charArray);
    }

    //Output
    private static void DisplayArray<T>(T[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}