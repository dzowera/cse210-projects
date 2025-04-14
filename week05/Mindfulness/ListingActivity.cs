using System;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some things you are grateful for?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing", "This activity helps you think about positive aspects in your life.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        ShowSpinner(3);

        Console.WriteLine("Start listing items (press Enter after each one). Type 'done' when finished.");
        int count = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }
}