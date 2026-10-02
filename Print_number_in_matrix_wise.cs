using System;
namespace Value{
staticvoid Main(string[] args)
 {
int num;
int next;
int first = 0;
int second = 1;
Console.WriteLine("Enter The Number Of Terms Of Fibonacci Series You Want:");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i<num; i++)
 {
if (i<= 1)
 {
 next = i;
 }
else
 {
 next = first + second;
 first = second;
 second = next;
 }
Console.Write(next);
Console.Write(" ");
 }
Console.ReadKey();
Console.Read();
 }}
