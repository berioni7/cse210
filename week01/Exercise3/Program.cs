using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write a magic number: ");
        string number = Console.ReadLine();
        int answer = int.Parse(number);

        int guess;

        do
        {
            Console.Write("Write your guess: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess < answer)
            {
                Console.WriteLine("Higher.");
            }
            else if (guess > answer)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != answer);
    }
}
