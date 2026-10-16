using System;

class FinallyDemo
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Program completed");
        }
    }
}
