using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by pacing your breathing. Clear your mind and focus.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration; i += 6) // Assuming 3 seconds for each breath in/out cycle
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}