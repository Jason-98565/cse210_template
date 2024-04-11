using System;
using System.Diagnostics;

public class Eternal : Goal
{
    private int _count;
    public Eternal(int pointvalue,string goalname,string description,bool ending = false,bool complete = false) :base(pointvalue,goalname,description)
    {
        _pointvalue = pointvalue;
        _goalname = goalname;
        _description = description;
        _ending = ending;
        _complete = complete;
    }
    public override string ToString()
    {
        string Gu =  ($"[] {_goalname} ({_description})");
        return Gu;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}