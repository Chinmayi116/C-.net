using System;
// public class
public class C1
{ 
 // public data members
 public int rn;
 public string name; 
}
// another public class
public class C2
{ 
// Main Method
public static void Main(string[] args)
{ // Creating object of C1 class
 C1 obj = new C1();
 
 // setting values to publicdata members of class C1
 obj.rn = 10000;
 obj.name = null;
 
 // display result
 Console.WriteLine("Name: {0} \nRoll No: {1}", obj.name, obj.rn); 
}
}
