
using System;

class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        int age = 16;

        try
        {
            if (age < 18)
                throw new AgeException("Age must be 18 or above");

            Console.WriteLine("Eligible");
        }
        catch (AgeException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}
