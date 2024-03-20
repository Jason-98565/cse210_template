using System;

public class Reference
{
    public string _Book;
    public string _Chap;
    public string _Verse;
    override
    public string ToString()
    {
        string _reference = $"{_Book} {_Chap}:{_Verse}";
        return _reference;
    }
    public void display_ref()
    {
        string Value = ToString();
        Console.WriteLine(Value);
    }
}