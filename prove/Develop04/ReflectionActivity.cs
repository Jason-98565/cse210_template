using System;

public class Reflection:Activity
{
    public Reflection()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect reflect on times in your life when you have shown strength and resillience. This will help you recognize the power within you and how you can apply it to other parts of your life";
        Startmessage();
        getduration();
        Pause_Speen(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Reflect();
        do
        {
            reflecty();
            currentTime = DateTime.Now;
        }
        while (currentTime < endTime);
        Endmessage();
    }
    public void Reflect()
    {
        List<string> stri = new List<string>();
        stri.Add("Think of a time when you stood up for someone else.");
        stri.Add("Think of a time when you did something really difficult.");
        stri.Add("Think of a time when you helped someone in need.");
        stri.Add("Think of a time when you did something truly selfless.");
        Random ran = new Random();
        int value = ran.Next(0,stri.Count);
        string str = stri[value];
        Console.WriteLine(str);
    }
    public void reflecty()
    {
        List<string> strings = new List<string>();
        strings.Add("Why was this experience meaningful to you?");
        strings.Add("Have you ever done anything like this before?");
        strings.Add("How did you get started?");
        strings.Add("How did you feel when it was complete?");
        strings.Add("What made this time different than other times when you were not as successful?");
        strings.Add("What is your favorite thing about this experience?");
        strings.Add("What could you learn from this experience that applies to other situations?");
        strings.Add("What did you learn about yourself through this experience?");
        strings.Add("How can you keep this experience in mind in the future?");
        Random ran = new Random();
        int value = ran.Next(0,strings.Count);
        string strin = strings[value];
        Console.WriteLine(strin);
        Pause_Speen(10);
    }
}