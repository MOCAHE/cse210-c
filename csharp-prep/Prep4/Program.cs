using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        //Assigment
        float addingNumbers = -1;
        List<float> numbers = new();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (addingNumbers != 0)
        {
            Console.Write("Enter a number: ");
            addingNumbers = float.Parse(Console.ReadLine());

            if (addingNumbers != 0)
            {
                numbers.Add(addingNumbers);
            }
        }

        //Compute the sum, or total, of the numbers in the list.
        Console.WriteLine();
        float sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Compute the average of the numbers in the list.
        float average = (sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        //Find the maximum, or largest, number in the list.
        Console.WriteLine($"The largest number is: {numbers.Max()}");

        //Have the user both positive and negative numbers, 
        //then find the smallest positive number.
        // THIS CODE DOESN'T WORK IF YOU USE ONLY NEGATIVE NUMBERS
        float min = float.MaxValue;
        foreach (float number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimum positive number is: {min}");
        Console.WriteLine();

        //Sort the numbers in the list and display the new
        //sorted list. (Use libraries)
        Console.WriteLine("Entered numbers sorted: ");
        numbers.Sort();
        foreach (float number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}