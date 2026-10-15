using System;

class Palindrome
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int temp = n, rev = 0;

        while (n > 0)
        {
            int digit = n % 10;
            rev = rev * 10 + digit;
            n = n / 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome number");
        else
            Console.WriteLine("Not a palindrome");
    }
}
