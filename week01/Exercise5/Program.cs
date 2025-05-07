using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        Console.WriteLine($"Your name is: {userName}");

        int number = PromptUserNumber();
        Console.WriteLine($"Your favorite number is: {number}");

        Console.WriteLine("Type a random number: ");
        string answer = Console.ReadLine();
        int number_ = int.Parse(answer);

        int result = SquareNumber(number);
        Console.WriteLine($"The number you've typed was squared and the result is: {result}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName ()
    {
       Console.Write("Enter your name: ");
       string name = Console.ReadLine();
       return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        return number;
    }

    static int SquareNumber(int a)
    {
       return a * a;
    }

    static void DisplayResult(string name, int square)
    {
    Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
