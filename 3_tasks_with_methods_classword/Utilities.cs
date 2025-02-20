namespace TasksWithMethodsClassword

{
using System;
using System.Text.RegularExpressions;
    using System.Xml.XPath;

    public static class Utilities
    {

    public static void calculator()
    {
        string? operation=null;
        int? answer = null;
        int  num1 = 0;
        int num2 = 0;

        while(true)
        {
            Console.WriteLine ("enter first number");
        num1=Getusserint();
        Console.WriteLine ("enter secondnumber number");
        num2=Getusserint();
        
        

        while(true)
        {
            Console.WriteLine("Enter opperation do you want to do, +, -, *, /, ????");
            operation = Console.ReadLine()?.Trim();;
            string patern =@"[+\-*/]";
        if (Regex.IsMatch(operation??"",patern))
        {
            string sureUser = "";
            Console.WriteLine("you sure? y/n");
            sureUser = Console.ReadLine()?.ToLower().Trim()??"no";
            if(sureUser =="y"||sureUser == "yes")
            {
            break;
            }
            else
            {
                Console.WriteLine("opperation cancelled!!!");
            }
        
        }
          else
            {
                Console.WriteLine("Invalid operation. Please enter a valid operator.");
            }
        }
        if(operation=="/"&& num2 != 0)
        answer = num1/num2;
        else if(operation=="/"&& num2 == 0)
        Console.WriteLine("infinte");
        else if(operation=="*")
        answer = num1*num2;
        else if (operation == "+")
        answer = num1+num2;
        else if (operation == "-")
        answer = num1-num2;
        

        
        Console.WriteLine(answer);
        break;
     }
    }
        public static void fibanacci()
    {
        long fib_second = 0;
        long fib_next = 0;
        long sequence_length = 0;
        long fib_start = 1;
        Console.WriteLine("Enter input number of sequences you want");
        sequence_length = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < sequence_length; i++) 
        {
            fib_next = fib_start + fib_second;
            fib_second = fib_start;  
            fib_start = fib_next;
            Console.WriteLine(fib_second);
        }
        
     
    }
     public static void Palidrome_checker()
    {
        string word = "";
        string reverse = "";
        Console.WriteLine("enter word");
        word = Console.ReadLine()??"";
        word = word.ToLower();
        foreach (char c in word) 
        {
            reverse = c + reverse;
            
        }
        if (word == reverse)
        {
            Console.WriteLine("is a pallidrome");
        }
        else
        {
            Console.WriteLine("is not a  pallidrome");
        }












       
    }
        
        
        
        
    private static  int  Getusserint()
        {
            int usserinput= 0;
            while (!int.TryParse(Console.ReadLine() ?? "", out usserinput))
            {
                 Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return usserinput;
        }

    }
}