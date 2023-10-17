using System;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready ...");
        LogIndicator();
        Console.WriteLine();
    }

    public void DisplayEndingMesagge()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        LogIndicator();
        Console.WriteLine();
    }

    public void LogIndicator(int durationInSeconds = 5)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationInSeconds);
        DateTime currentTime = DateTime.Now;

        char[] chars = { '|', '/', '-', '\\', '|', '/', '-', '\\' };
        while (currentTime < futureTime)
        {
            foreach (char c in chars)
            {
                Console.Write(c);
                Thread.Sleep(400); // Esta pausa hace que cada ciclo del bucle dure 3.2 segundos (8 caracteres * 400 ms)
                Console.Write("\b \b");
                currentTime = DateTime.Now;
                if (currentTime >= futureTime)
                    break;
            }
        }
    }

    public void CountDown(int num)
    {
        for (int i = num; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            int digits = i.ToString().Length; // Obtener la cantidad de dígitos del número
            for (int j = 0; j < digits; j++) // Borrar solo la cantidad de dígitos del número
            {
                Console.Write("\b \b");
            }
        }
    }
}