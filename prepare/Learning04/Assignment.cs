using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Assignment
{
    private string _studentName;
    private string _topic;
    public string GetTopic()
    {
    return _topic;
    }
    public string GetStudentName()
    {
    return _studentName;
    }
    public Assignment(string studentName,string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}