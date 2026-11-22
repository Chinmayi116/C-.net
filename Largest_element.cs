using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 25, 5, 40, 15 };

        int max = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
        }

        Console.WriteLine("Largest element = " + max);
    }
}
