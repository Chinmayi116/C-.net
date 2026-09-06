using System;

class Program
{
    static void Main()
    {
        int a = 5 * 3 - 8 / 2;
        int b = (20 + 10) % 4;
        int c = 18 - 6 / 3 * 2;
        int d = 4 + 25 / 5 * 2 - 9 % 3;

        Console.WriteLine("Result of 5 * 3 - 8 / 2 = " + a);
        Console.WriteLine("Result of (20 + 10) % 4 = " + b);
        Console.WriteLine("Result of 18 - 6 / 3 * 2 = " + c);
        Console.WriteLine("Result of 4 + 25 / 5 * 2 - 9 % 3 = " + d);
    }
}
