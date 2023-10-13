using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choise from the menu: ");
            int options = int.Parse(Console.ReadLine());

            switch (options)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:
                    Console.WriteLine("See you!");
                    return;

                default:
                    Console.WriteLine("Invalid choise. Please enter a valid option.");
                    break;
            }
        }
    }
}