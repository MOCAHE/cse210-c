using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        // Crea el objeto Scripture.
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine($"{reference.GetDisplayText()} {scriptureText}");

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }

            // //CHATGPT
            // string input = Console.ReadLine();
            // if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            // {
            //     break;
            // }

            // Oculta algunas palabras aleatorias.
            scripture.HideRandomWords(3);

            // Limpia la pantalla de la consola y muestra la referencia y el texto actualizado.
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
        }
        Console.WriteLine("Program finished");
    }
}
