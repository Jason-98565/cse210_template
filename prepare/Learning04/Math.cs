using System;

public class Math : Assignment
{
    protected string _textbookSection;
    protected string _problems;
    public Math(string studentName,string topic,string textbookSection,string problems)
    : base(studentName,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string Homework()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}