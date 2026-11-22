using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Reverse array:");

        for (int i = a.Length - 1; i >= 0; i--)
        {
            Console.Write(a[i] + " ");
        }
    }
}
