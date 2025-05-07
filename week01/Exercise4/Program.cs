using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) 
            {
                numbers.Add(number);
            }
        }

        Console.WriteLine("You entered:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        
        int sum = numbers.Sum();
        Console.WriteLine($"The sum of all the numbers is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average of all the numbers is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}
