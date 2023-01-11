using System;

class Program
{
    static void Main(string[] args)
    {
      static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
    }
}