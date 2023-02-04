using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(userName,number);

       static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
       };

       static string PromptUserName(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
       }

        static int PromptUserNumber(){
        Console.Write("Enter your a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
       }



       static int SquareNumber(int number){

        int result = number * number;
        return result;

       };

       static void DisplayResult(string userName, int number){

        Console.WriteLine($"{userName},the square of your number is {number}");

       }

    TextWriter Write = new StreamWriter("mytext.txt"); 
    Write.WriteLine("This is an entry");
    Write.Close();


    }
}