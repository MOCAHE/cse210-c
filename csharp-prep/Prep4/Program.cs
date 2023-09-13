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

        // This part is to verify the content of the list
        Console.WriteLine();
        Console.WriteLine("Numbers entered: ");
        foreach (float number in numbers)
        {
            Console.WriteLine(number);
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
        Console.WriteLine();

        //Have the user both positive and negative numbers, 
        //then find the smallest positive number.
        float min = numbers[^1];

        Console.WriteLine(min);
        foreach (float number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimum positive number is {min}");
        //Sort the numbers in the list and display the new
        //sorted list. (Use libraries)
    }
}