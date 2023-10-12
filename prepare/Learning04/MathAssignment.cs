using System;

public class MathAssignment : Assigment
{
    private string _textBookSection;
    private string _problems;

    //Constructor
    public MathAssignment(string nombreEstudiante, string tema, string seccionLibro, string problemas)
    : base(nombreEstudiante, tema)
    {
        _textBookSection = seccionLibro;
        _problems = problemas;
    }

    public string GetHomeworkList()
    {
        return ($"Section: {_textBookSection} Problems: {_problems}");
    }
}