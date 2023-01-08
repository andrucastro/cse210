using System;

class Program
{
    static void Main(string[] args)
    {
        //Priting on the console
        Console.WriteLine("Hello World!");

        //Create a conditional 
        int number = 2;
        if(number < 4){
            Console.WriteLine(number);
        }

        //String interpolation
        string test ="Esta Funcionando";
        Console.WriteLine($"This to prove that my code {test}.");

        //Create a user input comand line 
        Console.WriteLine("Insert a color");
        string color = Console.ReadLine();


    }
}