using System;

class SumDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        while (n > 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}
