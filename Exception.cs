
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcpetionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number1, number2;
            byte result;
            number1 = 127;
            number2 = 127;
            try
            {
                result = unchecked((byte)(number1 * number2));
                Console.WriteLine("Unchecked result:" + result);
                result = checked((byte)(number1 * number2));
                Console.WriteLine("Checked result:" + result);
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.Write("Press enter to Quit...");
                Console.ReadLine();
            }
        }
    }
}
