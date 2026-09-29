using System;
namespace Null_Reference_Exception
{
 class Program
 {
Static void Main(string[] args)
 {
string[] list = newstring[5];
list[0] = "Sunday";
list[1] = "Monday";
list[2] = "Tuesday";
list[3] = "Wednesday";
list[4] = "Thursday";
try
 {
for (int i = 0; i<= 5; i++)
 {
Console.WriteLine(list[i].ToString());
 }
Console.ReadLine();
 }
catch (IndexOutOfRangeException dex)
 {
Console.WriteLine("More Details about Error: \n\n" + dex.ToString() + "\n\n");
 }
catch (Exception ex)
 {
Console.WriteLine("Other Exception raised" + ex.ToString() + "\n\n");
 }
//Finally block: it always executes
finally
 {
Console.WriteLine("Finally Block: For Exit Press Enter");
Console.ReadLine();
 }
 }
} }
