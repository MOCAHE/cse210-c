using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();

        DisplayWelcome();
        string name = PromptUserName();
        float number = PromptFavoriteNumber();
        DisplayMessage(name, Square(number));
        Console.WriteLine();

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static float PromptFavoriteNumber()
        {
            Console.Write("Please enter your favorite number: ");
            float favNumber = float.Parse(Console.ReadLine());
            return favNumber;
        }

        static float Square(float number)
        {
            float square = number * number;
            return square;
        }

        static void DisplayMessage(string name, float number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number}");
        }
    }
}