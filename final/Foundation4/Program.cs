using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();

        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 03), 30, 4.8),
            new Cycling(new DateTime(2022, 12, 1), 30, 9.7),
            new Swimming(new DateTime(2021, 12, 31), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            Console.WriteLine("-----------------------------\n");
        }
    }
}