using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int newNumber =-1;

        // Create a counter to calculate the average at the end of the program 
        int counter = 0;

        // Create a new list to store all the values 
        List<int> numbers = new List<int>();
 
        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());

            numbers.Add(newNumber);
            counter += 1; 

        }

        //Define the variable to sum all the numbers
        int total = 0;
        int average = 0;
        int largest = 0;
        int smallest = 0;

        // Loop trough all the numbers of the list and add them to get the total 
        foreach (int i in numbers){
            total += i;    
        }

        average = total/counter;
        largest = numbers.Max();
        smallest = numbers.Min();

        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine();
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
         foreach (int i in numbers){
            Console.WriteLine(i);  
        }
        
    }
}