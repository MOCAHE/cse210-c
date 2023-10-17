using System;
using System.Threading;

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

            int options;
            if (!int.TryParse(Console.ReadLine(), out options))
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                continue;
            }

            switch (options)
            {
                case 1:
                    BreathingActivity b1 = new BreathingActivity();
                    b1.Run();
                    break;

                case 2:
                    ReflectionActivity r1 = new ReflectionActivity();
                    r1.Run();
                    break;

                case 3:
                    ListingActivity l1 = new ListingActivity();
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

//SOLO FALTA HACER COINCIDIR LOS TEXTOS DEL VIDEO CON EL PROGRAMA VOY EN OPCION 2