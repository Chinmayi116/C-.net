using System;

class Program
{
    static void Main()
    {
        int age = 20;
        bool citizen = true;

        if (age >= 18)
        {
            if (citizen)
            {
                Console.WriteLine("Eligible to vote");
            }
        }
    }
}
