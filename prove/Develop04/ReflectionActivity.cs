using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public Random _random = new();

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        InitializePromptsAndQuestions();
    }

    private void InitializePromptsAndQuestions()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomFromList(List<string> list)
    {
        if (!list.Any())
        {
            InitializePromptsAndQuestions();
        }
        int index = _random.Next(list.Count);
        string item = list[index];
        list.RemoveAt(index);
        return item;
    }

    public string GetRandomPrompt()
    {
        return GetRandomFromList(_prompts);
    }

    public string GetRandomQuestion()
    {
        return GetRandomFromList(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.Write($" --- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDown(10);
        Console.WriteLine();
        Console.WriteLine();

        int timeForOneQuestionInSeconds = 10;
        int tiempoTotal = 0;

        while (tiempoTotal < _duration)
        {
            if (!_questions.Any())
            {
                InitializePromptsAndQuestions(); // Rellenar la lista si está vacía
            }

            Console.Write($"> {GetRandomQuestion()} ");
            LogIndicator(10);
            Console.WriteLine();

            if (tiempoTotal + timeForOneQuestionInSeconds < _duration)
            {
                tiempoTotal += timeForOneQuestionInSeconds;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine();
        DisplayEndingMesagge();
    }
}