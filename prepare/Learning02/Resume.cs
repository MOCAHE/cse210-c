using System;

// STEP 6: Create the Resume class
public class Resume
{
    public string _personName;
    public List<Job> _jobs = new();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: ");

        //No puedo usar string porque
        //es un tipo de dato objeto.
        //Aun debo guardarlo en una variable
        //por lo que usaré var.

        //El programa del profesor tiene como
        //tipo de dato Job
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}