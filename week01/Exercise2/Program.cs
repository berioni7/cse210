using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        float conversion = float.Parse(grade);
        
        string letter = "";
        
        if (conversion >= 90)
        {
            letter = "A";
        }
        else if (conversion >= 80)
        {
            letter = "B";
        }
        else if (conversion >= 70)
        {
            letter = "C";
        }
        else if (conversion >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (conversion >= 70)
        {
            Console.WriteLine("Congratulations, you've passed!");
        }
        else 
        {
            Console.WriteLine("You didn't pass. Try again!");
        }    
    }
}
