using System;

public class Assigment
{
    private string _studentName;
    private string _topic;

    public Assigment(string nombreEstudiante, string tema)
    {
        _studentName = nombreEstudiante;
        _topic = tema;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }
}