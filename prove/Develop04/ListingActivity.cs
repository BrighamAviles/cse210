using System;
using System.Collections.Generic;
using System.Threading;

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

    public ListingActivity() 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
    { }

    public override void Run()
    {
        base.Run();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);
        int timeLeft = _duration;
        List<string> items = new List<string>();
        while (timeLeft > 0)
        {
            Console.Write("List item: ");
            items.Add(Console.ReadLine());
            timeLeft -= 3;
        }
        Console.WriteLine($"You listed {items.Count} items.");
    }
}
