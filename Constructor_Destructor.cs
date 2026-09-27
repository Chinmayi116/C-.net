using System;

namespace Constructor
{
    class cons
    {
        public cons()
        {
            int a = 10;
            int b = 20;
            int c = a * b;

            Console.WriteLine("No Parameter: {0}", c);
        }

        public cons(int a, int b)
        {
            int c = a * b;

            Console.WriteLine("With Parameter: {0}", c);
        }

        ~cons()
        {
            Console.WriteLine("Destructor Called...!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            cons c1 = new cons();
            cons c2 = new cons(3, 4);

            Console.ReadKey();
        }
    }
}
