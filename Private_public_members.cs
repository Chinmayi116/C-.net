using System;

class Student
{
    // Private data members
    private int id;
    private string name;

    // Public property for ID
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    // Public property for Name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // Assigning values using properties
        s.Id = 101;
        s.Name = "Chinmayi";

        // Reading values using properties
        Console.WriteLine("Student ID: " + s.Id);
        Console.WriteLine("Student Name: " + s.Name);
    }
}
