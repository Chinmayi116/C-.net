
using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 0;

        try
        {
            int c = a / b;
            Console.WriteLine("Result = " + c);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        Console.ReadLine();
    }
}
