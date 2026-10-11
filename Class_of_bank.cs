using System;
namespace ConsoleApplication1
{
 class Program
 {
 static void Main(string[] args)
 { Amount amt = new Amount();
 amt.Balance();
 amt.GetData();
 Console.ReadLine(); 
 }
 public class Amount
 { double Total = 12000,Deductions=2000,BalanceAmt;
 public void Balance()
 { BalanceAmt = Total - Deductions;
 Console.WriteLine("Your Current Amount is Rs." + BalanceAmt);
 }
 public void Debit()
 { int debitamount = 0;
 Console.Write("Enter Amount");
 debitamount = int.Parse(Console.ReadLine());
 BalanceAmt = BalanceAmt - debitamount;
 Console.WriteLine("Your Balance Amount is Rs." + BalanceAmt);
 }
 public void Credit()
 { int creditamount = 0;
 Console.Write("Enter Amount");
 creditamount = int.Parse(Console.ReadLine());
 BalanceAmt = BalanceAmt + creditamount;
 Console.WriteLine("Your Balance Amount is Rs." + BalanceAmt);
 }
 public void GetData() 2
 {
 char Data;
 Console.WriteLine("Press (d) for Debit and (c) for Credit");
 Data = char.Parse(Console.ReadLine());
 if (Data == 'd')
 {
 Debit();
 }
 if (Data == 'c')
 {
 Credit();
 }
 } } } }
