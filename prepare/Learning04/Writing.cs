using System;

public class Writing : Assignment
{
     protected string _title;
     public Writing(string studentName,string topic,string title)
    : base(studentName,topic)
    {
        _title = title;
    }
    public string titlename()
    {
        string studentName = GetStudentName();
        return ($"{_title} by {studentName}");
    }
}