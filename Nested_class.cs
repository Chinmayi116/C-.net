using System;

class Outer
{
    public class Inner
    {
        public void Display()
        {
            Console.WriteLine("This is a nested class");
        }
    }
}

class Program
{
    static void Main()
    {
        Outer.Inner obj = new Outer.Inner();
        obj.Display();
    }
}
