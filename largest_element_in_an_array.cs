using System;

class LargestArray
{
    static void Main()
    {
        int[] a = { 12, 45, 7, 89, 23 };
        int max = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
                max = a[i];
        }

        Console.WriteLine("Largest element = " + max);
    }
}
