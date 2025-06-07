using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    { }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DisplayEndingMessage();
    }
}
