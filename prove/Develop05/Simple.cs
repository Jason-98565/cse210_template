using System;
using System.Text;

public class Simple : Goal
{
    private bool _done;
    public bool Complete()
    {
        if (_complete)
        {
            Console.WriteLine("You've already completed that one!");
            return _complete;
        }
        else
        {
            _done = true;
            return _done;
        }
    }
    public override string ToString()
    {
        string ge;
        if (_complete)
            {
                ge = "[X]";
            }
        else
            {
                ge = "[]";
            }
        string U = ge + $" {_goalname} ({_description})";
        return U;
    }
    public Simple(int pointvalue,string goalname,string description,bool ending = true,bool complete = false) :base(pointvalue,goalname,description)
    {
        _pointvalue = pointvalue;
        _goalname = goalname;
        _description = description;
        _ending = ending;
        _complete = complete;
    }
}