using System;
namespace ThisKeyword
{ class Student
 {
 private string[] name = new string[3];
 public string this[int index] // declaring an indexer
 {
 get // returns value of array element
 { return name[index]; }
 Set // sets value of array element
 { name[index] = value; }
 } }
 class Program
 { public static void Main()
 { Student s1 = new Student();
 s1[0] = "Ram"; 3
 s1[1] = "Shyam";
 s1[2] = "Gopal";
 for (int i = 0; i < 3; i++)
 { Console.WriteLine(s1[i] + " "); }
 Console.ReadKey();
 } }}
