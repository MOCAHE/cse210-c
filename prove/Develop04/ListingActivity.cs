using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    private int _count;
    public Random _random = new();

    public ListingActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _count = 0;
    }

    public string GetRandomFromList()
    {
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            });
        }

        int index = _random.Next(_prompts.Count);
        string item = _prompts[index];
        _prompts.RemoveAt(index);
        return item;
    }

    public string GetRandomPrompt()
    {
        return GetRandomFromList();
    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> "); // Indicate to the user where to type
            string entry = Console.ReadLine();

            if (DateTime.Now >= endTime)
            {
                break;
            }

            if (!string.IsNullOrWhiteSpace(entry))
            {
                userInput.Add(entry);
                _count++;
            }
        }

        return userInput;
    }


    public void Run()
    {
        _count = 0;
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        CountDown(10);
        Console.WriteLine();

        List<string> userResponses = GetListFromUser();//NO ENTIENDO CUANDO DEBO USAR ESTO AL TRABAJAR CON LISTAS
        Console.WriteLine();

        Console.WriteLine($"You listed {_count} responses");
        Console.WriteLine();

        DisplayEndingMesagge();
    }
}