using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_c
{
    class Program
    {
        static void CheckAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative,");
            }
            Console.WriteLine("Your age is:" + age);
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                CheckAge(age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Catch an Exception:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program finished(Finally bloc executed).");
            }
            Console.ReadLine();
        }
    }
}
