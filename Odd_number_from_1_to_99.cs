Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
public static void Main()
{
Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
for(intn =1; n <(99+1); n++)
{
if(n %2!=0)
{
Console.WriteLine(n);
}
}
Console.ReadKey();
}
