// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
bool nta = false;
bool nts = false;
bool a1_1 = true;
int point = 0;
int g1 = 0, g2 = 0, g3 = 0, g4 = 0; 
 int f1 = 0, f2 = 0, f3 = 0, f4 = 0;

while (nta == false)
{
    
    while (nts == false)
    {
         g1 = rnd.Next(1,10);
         g2 = rnd.Next(1,10);
         g3 = rnd.Next(1,10);
         g4 = rnd.Next(1,10);
        if ( g1 != g2 &g1 != g3 &g1 != g4 &g2 != g3 &g2 != g4 &g3 != g4)
        nts = true;

    }
    Console.WriteLine();
    Console.WriteLine("##############################################################");
    Console.WriteLine("##############################################################");
    Console.WriteLine();
    Console.WriteLine("Welcome to Cows and Bulls were you will guess 4 unique numbers");
    Console.WriteLine("Can you beat the highscore ???");
    Console.WriteLine();
     Console.WriteLine("##############################################################");
    Console.WriteLine("##############################################################");
    Console.WriteLine();
   Console.WriteLine($"Numbers: {g1}, {g2}, {g3}, {g4}");    
 while (a1_1) 
    {
       try
            {
                Console.WriteLine("1st integer: ");
                f1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2nd integer: ");
                f2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("3rd integer: ");
                f3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("4th integer: ");
                f4 = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter integers only.");
                continue;
            }

    }
    if ( f1 == g1 && f2 == g2 && f3 == g3 && f4 == g4)
    {
        Console.WriteLine("Thats.... right!!!!");
        point++;
        Console.WriteLine("again? y/n");
        string yes = Console.ReadLine();
        if( yes == "n"){
        nta = false;
        break;
        }

        else if( yes == "y")
        nts = false;
       
       
    }
    Console.WriteLine("Thats WRONG !!!");
    Console.WriteLine();
    Console.WriteLine("##############################################################");
    Console.WriteLine("##############################################################");
    
}

Console.WriteLine("Well done, you earned " + point + " points.");