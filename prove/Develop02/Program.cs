using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new();


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
                    PromptGenerator chatgpt = new PromptGenerator();
                    string randomPrompt = chatgpt.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);


                    Console.WriteLine("Enter your journal entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry();
                    journal.AddEntry(newEntry);
                    break;

                case 2:
                    Console.WriteLine("Entries: ");
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
                    return;
            }
        }
    }
}


// HAY UN PROBLEMA CON LA LOGICA DE ALGUNA DE LAS CLASES.
// NO SE ALMACENAN LOS ARCHIVOS
// CUANDO IMPRIMES LAS ENTRADAS SE IMPRIMEN PROMPT ALEATORIOS (SEGURAMENTE RELACIONADO A LO ANTERIOR)