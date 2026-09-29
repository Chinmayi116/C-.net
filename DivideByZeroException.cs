using System;
namespace test1
{
class Program
 {
static void Main(string[] args)
 {
try // Try block: The code which may raise exception at runtime
 {
int num1, num2;
decimal result;
Console.WriteLine("Divide Program. Enter 2 number to show result");
Console.WriteLine("Enter 1st Number: ");
 num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd Number: ");
 num2 = Convert.ToInt32(Console.ReadLine());
 result = (decimal)num1 / (decimal)num2;
Console.WriteLine("Division Result : " + result.ToString());
Console.ReadLine();
 }
catch (DivideByZeroException dex) //Multiple Catch block to handle exception
 {
Console.WriteLine("You have Entered 0");
Console.WriteLine("More Details about Error: \n\n" + dex.ToString() + "\n\n");
 }
catch (FormatException fex)
 {
Console.WriteLine("Invalid Input");
Console.WriteLine("More Details about Error: \n\n" + fex.ToString() + "\n\n");
 }
catch (Exception ex) //Parent Exception: Catch all type of exception
 {
Console.WriteLine("Other Exception raised" + ex.ToString() + "\n\n");
 }
finally //Finally block: it always executes
 {
Console.WriteLine("Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
Console.ReadLine();
 }
 }
 }
}
