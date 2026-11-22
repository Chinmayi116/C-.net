using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };

        int even = 0, odd = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even numbers = " + even);
        Console.WriteLine("Odd numbers = " + odd);
    }
}
