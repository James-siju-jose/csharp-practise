#include <iostream>// like - ussing system
#include <string>
void INFO();
using namespace std;

int main() { // his acts like Static Void Main(...args){}- declares to start the propgramme here
    int num1 = 0 ,num2 = 0 , output = 0;
    int inum1 = 0, inum2 = 0;
    string hello =  "hello";
    cout << "Hello, Sidiarth !" << endl; // this is Console.Writeline
    cout << "Hello, Sidiarth !\n" << endl;
    cout << "Hello, Sidiarth !\n" << endl;
    cout << "Hello, Sidiarth !\n" << endl; 
    cout << "Enter a value to add 2 number" << endl ;
    cout << "enter a value sigma " << endl ;
    cout << "enter first value" << endl;
    cin >> num1 ;
    //
    cout << "enter second value" << endl; // output  cout "c -out"
    cin >> num2; // input = cin "c -in"
    // input output !!!
    output = num1 +num2 ;
    string strNum1 = to_string(num1);
    string strNum2 = to_string(num2);  // converts to string
    inum1 = strNum1.length();
    inum2 = strNum2.length ();

    cout << output << endl;
    cout <<"the amount of character you used is "<< "" << (inum1+inum2) <<endl; // a spacde between is and athe double speechmarks give a gap :)
    cout << "now this will show you guys the basic \n\n to get an increment of a varaible us 'v'++ this will add one increment to the varible \n\n the same applies with 'v'-- which will decremnt by one \n\n"<< endl;   
    cout <<"% is modulus meaning that it returns the remander '.'so and so on \n"<< endl; 
    cout << "now when assigning varibales you can do  x+  = 5 which adds 5 to x instead of x= x+5 , this applies with all other opperators including  << or >> \n" << endl; 
    cout << "theres a new loop called do {} while (condition); which will force the loop the run and then check the condition and will repeat to the conditions terms \n" << endl;
    INFO();
    
    
    
    
    
    
    
    
    
    
    
    
    
    cin.get();
    cin.get(); // Needed because of leftover newline from previous input

    
    return 0;  // this will return with 0 showing the programme has worked
}

void INFO(){

cout<< " to declare a function YOU NEED IT ABOVE THE MAIN FUNCTION  but you can manipluate the function below main IF the function is DECLARED ABOVE THE MAIN !!!"<< endl;
cout << " also when trying to sepparting varibales from text use << variable >> to seppearte them " << endl;
}
