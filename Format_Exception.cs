using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the First number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result of division:" + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error:Please enter only numeric values. ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error:Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Program execution finished (Finally block always runs)");
            }
            Console.ReadLine();
        }
    }
}
