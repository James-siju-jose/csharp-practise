// See https://aka.ms/new-console-template for more information


using System;
using System.Text.RegularExpressions;
using TasksWithMethodsClassword;

class Program
{
    static void Main(string[] args)
    {
        string fin = "";
        bool finished = false;
        string opperation = "";
        while(finished == false)
        {
            fin = "";
        Console.WriteLine("What task do you want to run ,");
        Console.WriteLine("1.Calculator           --c");
        Console.WriteLine("2. Fibonacci Sequence  --f");
        Console.WriteLine("3.Palindrome Checker   --p");
        opperation = (Console.ReadLine()??"").ToLower();
             if(opperation=="" )
            {
                Console.WriteLine("invalid");
            }
            else if (opperation=="c" )
            {
                 Utilities.calculator();
            }
            else if (opperation=="f" )
            {
                Utilities.fibanacci();
            }
            else if (opperation=="p" )
            {
                Utilities.Palidrome_checker();
            }
            Console.Write("you done ? y/n ");
            fin = Console.ReadLine()?.ToLower() ?? "";
            if (fin == "y")
            {
                finished=true;
            }
           }

       
    }
}
