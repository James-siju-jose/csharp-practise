bool noint = false;
bool again = true;
Console.WriteLine(" CREATED BY JAMES SIJU JOSE (SUPERIOR CODER) (TESTED BY SIDDAHRTH SANJAY MY G)");
int num1_1 = 0;
int num2_2 = 0;
bool num1_3 = true;
bool num2_3 = true; 

while (again == true)
{
    noint = false;
    Console.WriteLine(" Do you want to ,/,*,+,-");
    string opperation = Console.ReadLine();
    Console.WriteLine("ok, now give me your first number ");
    string num1 = Console.ReadLine();
    Console.WriteLine("ok, now give me your second number ");
    string num2 = Console.ReadLine();


    while (num1_3 == true || num2_3 == true) 
    {
        try
        {
            num1_1 = Convert.ToInt32(num1);
        }
        catch
        {
            Console.WriteLine("FIRST INTERGR NOT AN INPUT");
            num1_3 = false;
            break;
        }

        try
        {
            num2_2 = Convert.ToInt32(num2);
        }
        catch
        {
            Console.WriteLine("SECOND INPUT NOT AN INTERGER");
            num2_3 = false;
            break;
        }
    
        if (opperation == "/" & num1_3 == true & num2_3 == true)
        {
            float answer = (float)num1_1 / num2_2;
            Console.WriteLine("{0:F2}",answer); //Console.WriteLine("{0:F2}", 12);    // 12.00 - two decimal places
            Console.WriteLine("want to do another opperation ?");
            string agin = Console.ReadLine();
            if (agin == "no")
            {
                again = false;
            }

        }
        if (opperation == "*" & num1_3 == true & num2_3 == true)
        {
            float answer = (float)num1_1 * num2_2;
            Console.WriteLine(answer);
            string agin = Console.ReadLine();
            Console.WriteLine("want to do another opperation ?");
            if (agin == "no")
            {
                again = false;
            }
        }
        if (opperation == "-" & num1_3 == true & num2_3 == true)
        {
            float answer = (float)num1_1 - num2_2;
            Console.WriteLine(answer);
            string agin = Console.ReadLine();
            Console.WriteLine("want to do another opperation ?");
            if (agin == "no")
            {
                again = false;
            }
        }
        if(opperation == "+" & num1_3 == true & num2_3 == true)
        {
            float answer = (float)num1_1 + num2_2;
            Console.WriteLine(answer);
            Console.WriteLine("again");

            string agin = Console.ReadLine();
            if (agin == "no")
            {
                again = false;
            }
            
        }
    }
}

    



