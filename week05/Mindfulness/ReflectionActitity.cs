using System;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself through this experience?",
        "How can you apply this experience in the future?",
        "What made this experience stand out?"
    };

    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on your strengths and resilience.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
            ShowSpinner(3);

            foreach (var question in _questions)
            {
                Console.WriteLine(question);
                ShowSpinner(3);
                elapsed += 3;
                if (elapsed >= _duration) break;
            }
        }

        DisplayEndingMessage();
    }
}