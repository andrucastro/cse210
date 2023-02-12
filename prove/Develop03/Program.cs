using System;
using System.IO;


class Program
{
    static void Main(string[] args)

    {   
        Console.Clear();
        Console.WriteLine("Do you want to type an scriture? type:");
        Console.WriteLine("type yes/no");;
        Console.Write("Type an option: ");
        string response =  Console.ReadLine();
        Console.WriteLine();
        Console.Write("The program will pick an scripture: ");
        

        // If the user say yes the user will type the scripture 
        if(response == "yes"){
            Logic scripture = new Logic();
            Scripture userScripture = scripture.getScripture();
            
            scripture.hideWords(userScripture);
        }
        // program will run with the scripture 
        else{
            Logic scripture = new Logic();
            Scripture userScripture = new Scripture();
            scripture.hideWords(userScripture);
        }    
    }   
}