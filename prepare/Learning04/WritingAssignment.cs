using System;

public class WritingAssignment : Assigment
{
    private string _title;

    //Constructor
    public WritingAssignment(string nombreEstudiante, string tema, string titulo)
    : base(nombreEstudiante, tema)
    {
        _title = titulo;
    }

    public string GetWritingInformation()
    {
        string nombreDelEstudiante = GetStudentName();
        return ($"{_title} by {nombreDelEstudiante}");
    }
}