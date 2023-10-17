using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    { }

    public void Run()
    {
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