using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    { }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }

        DisplayEndingMessage();
    }
}
