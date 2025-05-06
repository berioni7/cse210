using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Write your second name: ");
        string secondName = Console.ReadLine();
        Console.WriteLine($"Your name is {secondName}, {firstName} {secondName}");
    }
}