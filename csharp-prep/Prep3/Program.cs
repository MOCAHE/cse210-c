using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();

        // INICIO PRIMERA PARTE
        // Console.WriteLine("Whats is the magic number?: ");
        // string mNumber = Console.ReadLine();
        // int magicNumber = int.Parse(mNumber);

        // Console.WriteLine("What is your guess?: ");
        // string gNumber = Console.ReadLine();
        // int guessNumber = int.Parse(gNumber);

        // if (guessNumber > magicNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (guessNumber < magicNumber)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }
        // Console.WriteLine();
        // FIN PRIMERA PARTE

        // INICIO SEGUNDA PARTE
        Console.Write("Whats is the magic number?: ");
        string mNumber = Console.ReadLine();
        int magicNumber = int.Parse(mNumber);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess?: ");
            string gNumber = Console.ReadLine();
            guessNumber = int.Parse(gNumber);

            if (guessNumber > magicNumber)
            {
                Console.Write("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.Write("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            Console.WriteLine();
        }
        // FIN SEGUNDA PARTE
    }
}