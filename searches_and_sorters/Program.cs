class Program
{
    static int opperation_type = 0;
    static int [] arraynum = {1,21,2,3,4,5,69,7,42,666,1945,};
    static bool Usser_check = false;
    static string usser_sure = "";     
 static void test() 
  {
    Console.WriteLine("hello :)");
  }
   
static void Binary_sc()
{
   Console.WriteLine("this is a place holder");
}
static void Linear_sc()
{
     int i = 0;
    bool found = false;
    int to_find = 0;
    Console.WriteLine("Enter num to find");
    to_find = Convert.ToInt32(Console.ReadLine());
    for (i = 0 ;arraynum.Length>i; i++)
       {
        if (arraynum[i] == to_find)
        {
        found = true;
        break;
        }
        
        }  
    if (found)
    {
        Console.WriteLine($"Number {to_find} found at index {i}.");
    }
    else
    {
        Console.WriteLine($"Number {to_find} not found in the array.");
    }
}

static void Bubble_st()
{
    Console.WriteLine("this is a place holder");
}








static void Main(string[]args)
{

while(Usser_check == false)
{
test();
Console.WriteLine("Would you like to 1-->Binary search 2--> Linear search or 3--> Bubble sort");
opperation_type = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Are you sure about option {opperation_type}? (y/n)");
usser_sure = Console.ReadLine();
if (usser_sure== "y")
Usser_check= true;
else
Usser_check = false;
}

if (opperation_type == 1)
{
Console.WriteLine("\n"); 
     for (int i = 0; i < arraynum.Length; i++)
        {
            Console.Write(arraynum[i]+",");
        }
Console.WriteLine("\n");
Binary_sc();
}
else if (opperation_type == 2)
{
Console.WriteLine("\n"); 
Console.WriteLine("\n"); 
 for (int i = 0; i < arraynum.Length; i++)
        {
            Console.Write(arraynum[i]+",");
        }
Console.WriteLine("\n"); 
Linear_sc(); 
}
else if (opperation_type == 3)
{
Console.WriteLine("\n");     
for (int i = 0; i < arraynum.Length; i++)
 {
     Console.Write(arraynum[i]+",");
 }
Console.WriteLine("\n");
Console.WriteLine("Sorting");
Bubble_st();
}
}
}


// See https://aka.ms/new-console-template for more information

// aimes  . use modules instead of stand alone code 
//        . Do binary and linear sort
//        . Do Bubble sort
//        . play arounf with file managment for arrays ?? This for usser input 