// See https://aka.ms/new-console-template for more information


using System;
using System.Text.RegularExpressions;

class Program
{
    
    static void calculator()
    {
        string opperation="";
        int? answer = null;
        int  num1 = 0;
        int num2 = 0;
        Console.WriteLine(" CHECK CHECK");
        while(true)
        {
            Console.WriteLine ("enter first number");
        if (int.TryParse(Console.ReadLine(), out num1))
        {
         break;
        }
        else
        {
            Console.WriteLine("not int !!!");
        }
        }

        Console.WriteLine ("enter secondnumber number");
        Console.WriteLine("Second number");
        while(true)
        {
        try
        {
            num2 = Convert.ToInt32(Console.ReadLine());           
            break;
        }

        catch(FormatException)
        {
         Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        }
        Console.WriteLine("Enter opperation do you want to do, +, -, *, /, ????");
        
        while(true)
        {
            opperation = Console.ReadLine();
            string patern =@"[+\-*/]";
        if (Regex.IsMatch(opperation,patern))
        {
            string sureUser = "";
            Console.WriteLine("you sure? y/n");
            sureUser = Console.ReadLine();
            if(sureUser =="y"||sureUser == "Y")
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
        if(opperation=="/"&& num2 != 0)
        answer = num1/num2;
        else if(opperation=="/"&& num2 == 0)
        Console.WriteLine("infinte");
        else if(opperation=="*")
        answer = num1*num2;
        else if (opperation == "+")
        answer = num1+num2;
        else if (opperation == "-")
        answer = num1-num2;
        

        
        Console.WriteLine(answer);

    }

    static void fibanacci()
    {
        int fib_second = 0;
        int fib_next = 0;
        int sequence_length = 0;
        int fib_start = 1;
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
    static void Palidrome_checker()
    {
        string word = "";
        string reverse = "";
        Console.WriteLine("enter word");
        word = Console.ReadLine();
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









































    static void Main(string[] args)
    {
        bool finished = false;
        string opperation = "";
        while(finished == false)
        {
        Console.WriteLine("What task do you want to run ,");
        Console.WriteLine("1.Calculator");
        Console.WriteLine("2. Fibonacci Sequence");
        Console.WriteLine("3.Palindrome Checker");
        opperation = Console.ReadLine();
    
    
        }

        calculator();
        fibanacci();
        Palidrome_checker();
    }
}
