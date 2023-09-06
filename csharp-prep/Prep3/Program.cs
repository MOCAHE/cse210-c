using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        // INICIO PRIMERA PARTE
        // Console.Write("Whats is the magic number?: ");
        // string mNumber = Console.ReadLine();
        // int magicNumber = int.Parse(mNumber);

        // Console.Write("What is your guess?: ");
        // string gNumber = Console.ReadLine();
        // int guessNumber = int.Parse(gNumber);

        // if (guessNumber > magicNumber)
        // {
        //     Console.Write("Lower");
        // }
        // else if (guessNumber < magicNumber)
        // {
        //     Console.Write("Higher");
        // }
        // else
        // {
        //     Console.Write("You guessed it!");
        // }
        // Console.Write();
        // FIN PRIMERA PARTE


        // INICIO SEGUNDA PARTE
        // Console.Write("Whats is the magic number?: ");
        // string mNumber = Console.ReadLine();
        // int magicNumber = int.Parse(mNumber);

        // int guessNumber = -1;

        // while (guessNumber != magicNumber)
        // {
        //     Console.Write("What is your guess?: ");
        //     string gNumber = Console.ReadLine();
        //     guessNumber = int.Parse(gNumber);

        //     if (guessNumber > magicNumber)
        //     {
        //         Console.Write("Lower");
        //     }
        //     else if (guessNumber < magicNumber)
        //     {
        //         Console.Write("Higher");
        //     }
        //     else
        //     {
        //         Console.Write("You guessed it!");
        //     }
        //     Console.WriteLine();
        // }
        // FIN SEGUNDA PARTE


        // INICIO TERCERA PARTE & STRETCH CHALLENGE
        Random randomGenerator = new();
        int number = randomGenerator.Next(1, 100);
        string keepPlaying = "yes";
        int guessNumber = -1;

        while (keepPlaying == "yes")
        {
            Console.Write("What is your guess?: ");
            string gNumber = Console.ReadLine();
            guessNumber = int.Parse(gNumber);

            if (guessNumber > number)
            {
                Console.Write("Lower");
            }
            else if (guessNumber < number)
            {
                Console.Write("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine();
                Console.Write("Do you want to keep playing? (yes/no): ");
                keepPlaying = Console.ReadLine();
            }
            Console.WriteLine();
        }
        // FIN TERCERA PARTE & STRETCH CHALLENGE
    }
}