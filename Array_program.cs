using System;

class Program
{
    static void Main()
    {
        int[] a = new int[5];

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array elements:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
