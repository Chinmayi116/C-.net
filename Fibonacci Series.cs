using System;

class Program
{
    static void Main()
    {
        int a = 0, b = 1;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }
    }
}
