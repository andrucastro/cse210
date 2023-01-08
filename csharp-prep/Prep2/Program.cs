using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hi, This progrram is going to calculate your grade. ");
        Console.Write("Please enter your grade portcentage (number form 1 to 100 ): ");
        string percentage = Console.ReadLine();
        int percentageInt = int.Parse(percentage);
        string grade = "";


        if(percentageInt >= 90 ){
             grade = "A";
        }
        else if(percentageInt >= 80){
             grade = "B";;
        }
        else if(percentageInt >= 70){
             grade = "C";;
        }
        else if(percentageInt >= 60){
             grade = "D";;
        }
        else if(percentageInt < 60){
             grade = "F";
        };

        int sign = percentageInt % 10;


        if(percentageInt < 60){

            Console.WriteLine($"Your grade is: {grade}");
        }

        else if(percentageInt >= 93){

            Console.WriteLine($"Your grade is: {grade}");
        
        }

         else if(sign>= 7)
        {
            Console.WriteLine($"Your grade is: {grade}+");
        }
        
        else if(sign < 3)
        {
            Console.WriteLine($"Your grade is: {grade}-");
        }

        else{
            Console.WriteLine($"Your grade is: {grade}");
        }
   

        if (percentageInt  >= 70){
            Console.WriteLine("Class Aproved");
        }
        else{
            Console.WriteLine("Sorry, You failed the class!");
        }    



    }

   
}