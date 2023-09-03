using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?: ");
        string grade = Console.ReadLine();
        int nGrade = int.Parse(grade);
        Console.WriteLine();

        string letter = "";
        if (nGrade >= 90)
        {
            letter = "A";
        }
        else if (nGrade >= 80)
        {
            letter = "B";
        }
        else if (nGrade >= 70)
        {
            letter = "C";
        }
        else if (nGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        float lastDigit = nGrade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+" || letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");


        if (nGrade >= 70)
        {
            Console.WriteLine($"Congratulations, you pass the class");
        }
        else
        {
            Console.WriteLine($"You need to try harder the next time");
        }

        Console.WriteLine();
        // Está fue la primer manera en que
        // trate de resolver el problema

        // if (nGrade>=90)
        // {
        //     Console.WriteLine($"Your grade is A");
        // }
        // else if (nGrade>=80)
        // {
        //     Console.WriteLine($"Your grade is B");
        // }
        // else if (nGrade>=70)
        // {
        //     Console.WriteLine($"Your grade is C");
        // }
        // else if (nGrade>=60)
        // {
        //     Console.WriteLine($"Your grade is D");
        // }
        // else
        // {
        //     Console.WriteLine($"{nGrade}");
        // }
    }
}