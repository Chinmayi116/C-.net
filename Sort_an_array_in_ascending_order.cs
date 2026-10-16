using System;

class SortArray
{
    static void Main()
    {
        int[] a = { 50, 20, 40, 10, 30 };

        Array.Sort(a);

        Console.WriteLine("Sorted array:");

        foreach (int n in a)
        {
            Console.Write(n + " ");
        }
    }
}
