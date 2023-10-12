using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine();

        Assigment nuevaTarea = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"Nombre: {nuevaTarea.GetStudentName()}");
        Console.WriteLine($"Tema: {nuevaTarea.GetTopic()}");
        Console.WriteLine(nuevaTarea.GetSummary());
        Console.WriteLine();

        MathAssignment tareaMate = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        //Datos de la super clase, metodo .GetSummary();
        Console.WriteLine(tareaMate.GetSummary());
        //Datos de la subclase, método GetHomeworkList();
        Console.WriteLine(tareaMate.GetHomeworkList());
        Console.WriteLine();


        WritingAssignment tareaEscritura = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        //Datos de la super clase, metodo .GetSummary();
        Console.WriteLine(tareaEscritura.GetSummary());
        //Datos de la subclase, método GetWritingInformation();
        Console.WriteLine(tareaEscritura.GetWritingInformation());
    }
}