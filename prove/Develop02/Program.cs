using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Entry nuevaEntrada = new Entry();
                    PromptGenerator nuevoGet = new PromptGenerator();
                    nuevaEntrada._promptText = nuevoGet.GetRandomPrompt();
                    Console.WriteLine(nuevaEntrada._promptText);
                    nuevaEntrada._entryText = Console.ReadLine();
                    journal.AddEntry(nuevaEntrada);
                    Console.WriteLine();
                    break;

                case 2:
                    journal.DisplayAllEntries();
                    break;

                case 3:
                    Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case 4:
                    Console.WriteLine("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case 5:
                    Console.WriteLine("See you!");
                    Console.WriteLine();
                    return;
            }
        }
    }
}