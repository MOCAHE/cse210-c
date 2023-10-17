using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    { }

    public void Run()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        DisplayStartingMessage();

        int cycleDuration = 6;
        int totalCycles = _duration / cycleDuration;
        for (int i = 0; i < totalCycles; i++)
        {
            Console.Write("Breathe in... ");
            CountDown(3);
            Console.WriteLine();

            Console.Write("Now breath out... ");
            CountDown(3);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMesagge();
    }
}