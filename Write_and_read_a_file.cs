using System;
using System.IO;

class FileDemo
{
    static void Main()
    {
        File.WriteAllText("sample.txt", "Welcome to C#");

        string data = File.ReadAllText("sample.txt");

        Console.WriteLine(data);
    }
}
