using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();

        Address address1 = new Address("123 Main St", "Anytown", "CA", 12345);
        Address address2 = new Address("456 Elm St", "Somewhere", "TX", 67890);
        Address address3 = new Address("789 Oak St", "Everywhere", "NY", 11223);

        Lectures lecture = new Lectures("Science Talk", "A talk about science.", "11/01/2023", "2:00 PM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Wedding Reception", "Celebration after wedding.", "11/10/2023", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGatherings gathering = new OutdoorGatherings("Park Meetup", "Casual meetup in the park.", "11/20/2023", "10:00 AM", address3, "Sunny");

        DisplayEventDetails(lecture);
        DisplayEventDetails(reception);
        DisplayEventDetails(gathering);
    }

    public static void DisplayEventDetails(Event eventos)
    {
        Console.WriteLine("---- Standard Details ----");
        Console.WriteLine(eventos.StandardDetails());
        Console.WriteLine("\n---- Full Details ----");
        Console.WriteLine(eventos.FullDetails());
        Console.WriteLine("\n---- Short Description ----");
        Console.WriteLine(eventos.ShortDescription());
        Console.WriteLine("-----------------------------\n");
    }
}