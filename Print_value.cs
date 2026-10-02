using System;
namespace Value{
staticvoid Main(string[] args)
 {
int value;
Console.WriteLine("Enter A Value:");
 value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
for (int i = 1; i<= value; i++)
 {
for (int j = 1; j <= i; j++)
 {
Console.Write(i);
 }
Console.Write(" ");
 }
Console.Read();
 }
}
