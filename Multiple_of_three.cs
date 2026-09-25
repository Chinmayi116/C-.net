Write a C# program to check if a given positive number is a multiple of 3 or 7.
static void Main(string[] args)
 {
Console.WriteLine("\nInput first integer:"); 
int x = Convert.ToInt32(Console.ReadLine());
 if (x > 0)
 {
Console.WriteLine(x % 3 == 0 || x % 7 == 0);
 }
Console.ReadKey();
 }
Input first integer: 
15 
True
