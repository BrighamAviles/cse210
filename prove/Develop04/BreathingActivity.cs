using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    { }

    public override void Run()
    {
        base.Run();
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            timeLeft -= 3;
            if (timeLeft <= 0) break;
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            timeLeft -= 3;
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
