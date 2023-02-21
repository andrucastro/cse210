using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMenu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listening activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choise from the menu: ");
        }
    
    //Start
    Console.WriteLine("Welcome to the mindfulness program. This program has 3 activities to help you punder and refelt during the day");
    
        int runProgram = 0;
        while(runProgram != 4){
            DisplayMenu();
            // Read user imput 
            string userSelection = Console.ReadLine();
            //parse imput to int
            int activity = Int16.Parse(userSelection);


            switch(activity)
            {
            //Breathing activity
            case 1:
                Console.Clear();
                Breathing breathing = new Breathing(0,"Breathing");
                breathing.WelcomMesage();
                breathing.displayDescription();
                int getDuration = breathing.getDuration();
                breathing.pauseProgram(3);
                breathing.Breath(getDuration);
                
            break;

            //Reflecting activity
            case 2:
                Console.WriteLine("activity 2");
            break;
            
            //Reflecting listening
            case 3:
                Console.WriteLine("activity 3");
            break;

            //Stop the  program
            case 4:
                runProgram = 4;
            break;
            } 
        }

    }
}