using System;

public abstract class Goal
{
    public int _pointvalue;
    public string _goalname;
    public string _description;
    public bool _ending;
    public bool _complete;
    

    public abstract override string ToString();

    public Goal(int point,string name,string description)
    {}
}