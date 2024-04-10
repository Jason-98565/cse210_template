using System;

public class Activity
{
    protected string _name;
    protected string _description;
    public int _duration;
    public string getname()
    {
        return _name;
    }
    public string getdescription()
    {
        return _description;
    }
    public int getduration()
    {
        Console.WriteLine("how long (in seconds) would you like to perform this activity for?");
        string _durline = Console.ReadLine();
        _duration = int.Parse(_durline);
        return _duration;
    }
    public void Startmessage()
    {
        Console.WriteLine($"Welcome to the {_name},{_description}");
    }
    public void Endmessage()
    {
        Console.WriteLine("Well Done!");
        Pause_Speen(3);
    }
    public void Pause_Countdown(int x)
    {
        for (int i = x; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Pause_Speen(int y)
    {
        List<string> spinlist = new List<string>();
        spinlist.Add("|");
        spinlist.Add("/");
        spinlist.Add("-");
        spinlist.Add("\\");
        for (int i = y; i > 0; i--)
        {
            for (int var = 0; var < 4; var++)
            {
                Console.Write(spinlist[var]);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
}