
using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30 };

        try
        {
            Console.WriteLine(a[5]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Array index is out of range");
        }

        Console.ReadLine();
    }
}
