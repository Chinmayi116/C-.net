using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int term = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(term + " ");
            term = term * 3;
        }
    }
}
